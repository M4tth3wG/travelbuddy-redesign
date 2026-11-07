using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TravelBuddyAPI.Data;

namespace TravelBuddyAPI.Tests.Data;

public class ModelSnapshotTest
{
    [Fact]
    public void Model_ShouldMatchMigrationsSnapshot()
    {
        // No connection is opened: the SQL Server provider is only needed to build the relational model.
        var options = new DbContextOptionsBuilder<TravelBuddyDbContext>()
            .UseSqlServer("Server=localhost;Database=design_time_only")
            .Options;
        using var dbContext = new TravelBuddyDbContext(options);

        var snapshotModel = dbContext.GetService<IMigrationsAssembly>().ModelSnapshot?.Model;
        Assert.NotNull(snapshotModel);
        if (snapshotModel is IMutableModel mutableModel)
            snapshotModel = mutableModel.FinalizeModel();
        snapshotModel = dbContext.GetService<IModelRuntimeInitializer>().Initialize(snapshotModel);

        var differences = dbContext.GetService<IMigrationsModelDiffer>().GetDifferences(
            snapshotModel.GetRelationalModel(),
            dbContext.GetService<IDesignTimeModel>().Model.GetRelationalModel());

        // Non-deterministic seed values (e.g. Guid.NewGuid()) or a missing migration show up here.
        Assert.True(differences.Count == 0,
            "Model differs from the migrations snapshot: " +
            string.Join(", ", differences.Select(d => d.GetType().Name).Distinct()));
    }
}
