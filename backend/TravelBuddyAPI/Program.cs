using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;
using TravelBuddyAPI.Data;
using Microsoft.OpenApi.Models;
using TravelBuddyAPI.Endpoints;
using RestSharp;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Services;
using Microsoft.IdentityModel.Tokens;

namespace TravelBuddyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMemoryCache();

            builder.Services.AddScoped<INBPService, NBPClient>();
            builder.Services.AddScoped<IGeoapifyService, GeoapifyClient>();
            builder.Services.AddScoped<IRestClient>(sp =>
                new RestClient(builder.Configuration["GeoapifyBaseUrl"] ?? ""));
            builder.Services.AddScoped<ITravelBuddyDbCache, TravelBuddyDbCache>();
            builder.Services.AddScoped<IPlacesService, PlacesService>();
            builder.Services.AddScoped<ITripsService, TripsService>();
            builder.Services.AddScoped<ICategoryProfilesService, CategoryProfilesService>();
            builder.Services.AddScoped<IConditionProfilesService, ConditionProfilesService>();
            builder.Services.AddScoped<ITransferPointsService, TransferPointsService>();
            builder.Services.AddScoped<ITripPointsService, TripPointsService>();
            builder.Services.AddScoped<IFavouritesService, FavouritesService>();
            builder.Services.AddScoped<IAvailableOptionsService, AvailableOptionsService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "TravelBuddyAPI", Version = "v1" });

                // Add Bearer token authentication
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            builder.Services.AddAuthentication(options =>
           {
               options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
           })
           .AddJwtBearer(options =>
           {
               options.Authority = builder.Configuration["Cognito:Authority"];
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidIssuer = builder.Configuration["Cognito:Authority"],
                   ValidateAudience = false,
                   ValidAudience = builder.Configuration["Cognito:Audience"],
                   ValidateLifetime = true,
                   RequireExpirationTime = true,
                   ValidateIssuerSigningKey = true
               };
           });

            builder.Services.AddAuthorization();


            var databaseConnectionString = builder.Configuration.GetConnectionString("TravelBuddyDb");
            if (builder.Environment.IsDevelopment())
            {
                databaseConnectionString = databaseConnectionString?.Replace("{MSSQL_SA_PASSWORD}", builder.Configuration["MSSQL_SA_PASSWORD"]);
            }

            builder.Services.AddDbContext<TravelBuddyDbContext>(options =>
            {
                options.UseSqlServer(databaseConnectionString);
            });

            var app = builder.Build();

            // Migrate the database
            try
            {
                using var scope = app.Services.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<TravelBuddyDbContext>();
                dbContext.Database.Migrate();
            }
            catch (Exception ex) when (ex is InvalidOperationException || ex is Microsoft.EntityFrameworkCore.Storage.RetryLimitExceededException || ex is Microsoft.Data.SqlClient.SqlException)
            {
                var logger = app.Services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred while migrating the database: {Message}", ex.Message);
                if (ex.InnerException != null)
                    logger.LogError("Inner exception: {InnerMessage}", ex.InnerException.Message);
            }

            // Development configuration
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();

            app.UseAuthorization();

            // Mapping endpoints
            app.MapTripsEndpoints();
            app.MapCategoryProfilesEndpoints();
            app.MapConditionProfilesEndpoints();
            app.MapTransferPointsEndpoints();
            app.MapTripPointsEndpoints();
            app.MapPlacesEndpoints();
            app.MapFavouriteProfilesEndpoints();

            // Development enpoints
            if (app.Environment.IsDevelopment())
            {
                app.MapGeoapifyEndpoints();
                app.MapNBPEndpoints();
            }

            // Set the culture to US
            var cultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            app.Run();
        }
    }

}
