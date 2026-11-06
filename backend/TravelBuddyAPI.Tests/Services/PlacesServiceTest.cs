using Microsoft.EntityFrameworkCore;
using Moq;
using TravelBuddyAPI.Data;
using TravelBuddyAPI.DTOs.Place;
using TravelBuddyAPI.Interfaces;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services;

public class PlacesServiceTest
{
    private readonly TravelBuddyDbContext _dbContext;
    private readonly Mock<IGeoapifyService> _mockGeoapifyService;
    private readonly Mock<ITravelBuddyDbCache> _mockDbCache;
    private readonly PlacesService _placesService;

    public PlacesServiceTest()
    {
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new TravelBuddyDbContext(options);
        _mockGeoapifyService = new Mock<IGeoapifyService>();
        _mockDbCache = new Mock<ITravelBuddyDbCache>();
        _placesService = new PlacesService(_dbContext, _mockGeoapifyService.Object, _mockDbCache.Object);
    }

    [Fact]
    public async Task GetAutocompleteDestinationsAsync_ReturnsPlaceOverviewDTOs()
    {
        // Arrange
        var query = "New York";
        var providerPlaces = new List<ProviderPlace>
        {
            new ProviderPlace { ProviderId = "1", Name = "New York", Country = "USA", City = "New York" }
        };
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.city, null, null, null, "json"))
            .ReturnsAsync(providerPlaces);

        // Act
        var result = await _placesService.GetAutocompleteDestinationsAsync(query);

        // Assert
        Assert.Single(result);
        Assert.Equal("New York", result[0].Name);
        Assert.Equal("USA", result[0].Country);
        Assert.Equal("New York", result[0].City);
    }

    [Fact]
    public async Task GetAutocompleteDestinationsAsync_ReturnsEmptyListOnHttpRequestException()
    {
        // Arrange
        var query = "New York";
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.city, null, null, null, "json"))
            .ThrowsAsync(new HttpRequestException());

        // Act
        var result = await _placesService.GetAutocompleteDestinationsAsync(query);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public async Task GetAutocompletePlacesAsync_ReturnsPlaceOverviewDTOs()
    {
        // Arrange
        var query = "Central Park";
        var latitude = 40.785091m;
        var longitude = -73.968285m;
        var bias = $"proximity:{longitude},{latitude}";
        var providerPlaces = new List<ProviderPlace>
        {
            new ProviderPlace { ProviderId = "1", Name = "Central Park", Country = "USA", City = "New York" }
        };
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, null, null, bias, "json"))
            .ReturnsAsync(providerPlaces);

        // Act
        var result = await _placesService.GetAutocompletePlacesAsync(query, latitude, longitude);

        // Assert
        Assert.Single(result);
        Assert.Equal("Central Park", result[0].Name);
        Assert.Equal("USA", result[0].Country);
        Assert.Equal("New York", result[0].City);
    }

    [Fact]
    public async Task GetAutocompletePlacesAsync_ReturnsEmptyListOnHttpRequestException()
    {
        // Arrange
        var query = "Central Park";
        var latitude = 40.785091m;
        var longitude = -73.968285m;
        var bias = $"proximity:{longitude},{latitude}";
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, null, null, bias, "json"))
            .ThrowsAsync(new HttpRequestException());

        // Act
        var result = await _placesService.GetAutocompletePlacesAsync(query, latitude, longitude);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public async Task GetAutocompletePlacesAsync_MatchesExistingPlacesByProviderIdOrFullAddress()
    {
        // Arrange
        var query = "Cafe";
        var byProviderId = new ProviderPlace { Id = Guid.NewGuid(), ProviderId = "p1", Name = "Old Name", Country = "Poland", City = "Kraków" };
        var byAddress = new ProviderPlace { Id = Guid.NewGuid(), ProviderId = "db-2", Name = "Cafe Two", Country = "Poland", City = "Kraków", Street = "Floriańska", HouseNumber = "2" };
        var sameNameOtherCity = new ProviderPlace { Id = Guid.NewGuid(), ProviderId = "db-3", Name = "Cafe Three", Country = "Poland", City = "Gdańsk", Street = "Długa", HouseNumber = "3" };
        var unrelated = new ProviderPlace { Id = Guid.NewGuid(), ProviderId = "db-4", Name = "Museum", Country = "Poland", City = "Warszawa" };

        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        using (var seedContext = new TravelBuddyDbContext(options))
        {
            await seedContext.Places.AddRangeAsync(byProviderId, byAddress, sameNameOtherCity, unrelated);
            await seedContext.SaveChangesAsync();
        }

        // Fresh context: after the call its change tracker holds only the rows the query loaded.
        using var serviceContext = new TravelBuddyDbContext(options);
        var placesService = new PlacesService(serviceContext, _mockGeoapifyService.Object, _mockDbCache.Object);

        var providerPlaces = new List<ProviderPlace>
        {
            new ProviderPlace { ProviderId = "p1", Name = "Cafe One", Country = "Poland", City = "Kraków" },
            new ProviderPlace { ProviderId = "p2", Name = "Cafe Two", Country = "Poland", City = "Kraków", Street = "Floriańska", HouseNumber = "2" },
            new ProviderPlace { ProviderId = "p3", Name = "Cafe Three", Country = "Poland", City = "Kraków", Street = "Długa", HouseNumber = "3" },
        };
        _mockGeoapifyService.Setup(s => s.GetAddressAutocompleteAsync(query, Enums.AddressLevel.amenity, null, null, null, "json"))
            .ReturnsAsync(providerPlaces);

        // Act
        var result = await placesService.GetAutocompletePlacesAsync(query, null, null);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal(byProviderId.Id, result.Single(r => r.ProviderId == "p1").Id);
        Assert.Equal(byAddress.Id, result.Single(r => r.ProviderId == "p2").Id);
        Assert.Null(result.Single(r => r.ProviderId == "p3").Id);

        var loadedIds = serviceContext.ChangeTracker.Entries<ProviderPlace>().Select(e => e.Entity.Id).ToList();
        Assert.DoesNotContain(unrelated.Id, loadedIds);
        Assert.DoesNotContain(sameNameOtherCity.Id, loadedIds);
    }

    [Fact]
    public async Task AddPlaceAsync_ShouldAddProviderPlace()
    {
        // Arrange
        var placeRequest = new PlaceRequestDTO
        {
            ProviderId = Guid.NewGuid().ToString(),
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            Street = "Test Street",
            HouseNumber = "123",
            Latitude = 50.0m,
            Longitude = 20.0m,
        };

        _mockDbCache.Setup(x => x.GetCategoriesAsync()).ReturnsAsync(new List<PlaceCategory>());
        _mockGeoapifyService.Setup(x => x.GetPlaceDetailsAsync(It.IsAny<string>())).ReturnsAsync(new ProviderPlace
        {
            ProviderId = placeRequest.ProviderId,
            Name = placeRequest.Name,
            Country = placeRequest.Country,
            City = placeRequest.City,
            Street = placeRequest.Street,
            HouseNumber = placeRequest.HouseNumber,
            Latitude = placeRequest.Latitude,
            Longitude = placeRequest.Longitude,
        });

        // Act
        var result = await _placesService.AddPlaceAsync(placeRequest);


        // Assert
        var addedPlace = await _dbContext.Places.FirstOrDefaultAsync();
        Assert.NotNull(addedPlace);
        Assert.Equal(placeRequest.Name, addedPlace.Name);
        Assert.Equal(placeRequest.Country, addedPlace.Country);
        Assert.Equal(placeRequest.City, addedPlace.City);
        Assert.Equal(placeRequest.Street, addedPlace.Street);
        Assert.Equal(placeRequest.HouseNumber, addedPlace.HouseNumber);
        Assert.Equal(placeRequest.Latitude, addedPlace.Latitude);
        Assert.Equal(placeRequest.Longitude, addedPlace.Longitude);
    }

    [Fact]
    public async Task AddPlaceAsync_ShouldAddCustomPlace()
    {
        // Arrange
        var placeRequest = new PlaceRequestDTO
        {
            Name = "Test Place",
            Country = "Test Country",
            City = "Test City",
            // Street = "Test Street",
            // HouseNumber = "123",
            Latitude = 50.0m,
            Longitude = 20.0m,
            SuperCategoryId = Guid.NewGuid()
        };

        var supercategory = new PlaceCategory { Id = placeRequest.SuperCategoryId.Value, Name = "Test Category" };
        await _dbContext.PlaceCategories.AddAsync(supercategory);
        await _dbContext.SaveChangesAsync();

        _mockDbCache.Setup(x => x.GetCategoriesAsync()).ReturnsAsync([supercategory]);

        // Act
        var result = await _placesService.AddPlaceAsync(placeRequest);

        // Assert
        var addedPlace = await _dbContext.Places.FirstOrDefaultAsync();
        Assert.NotNull(addedPlace);
        Assert.Equal(placeRequest.Name, addedPlace.Name);
        Assert.Equal(placeRequest.Country, addedPlace.Country);
        Assert.Equal(placeRequest.City, addedPlace.City);
        Assert.Equal(placeRequest.Street, addedPlace.Street);
        Assert.Equal(placeRequest.HouseNumber, addedPlace.HouseNumber);
        Assert.Equal(placeRequest.Latitude, addedPlace.Latitude);
        Assert.Equal(placeRequest.Longitude, addedPlace.Longitude);
        Assert.NotNull(result.SuperCategory);
        Assert.Equal(placeRequest.SuperCategoryId, result.SuperCategory.Id);
    }
}