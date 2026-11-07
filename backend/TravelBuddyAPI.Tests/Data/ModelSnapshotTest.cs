using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using TravelBuddyAPI.Data;

namespace TravelBuddyAPI.Tests.Data;

public class ModelSnapshotTest
{
    private const int MaxKeysPerOperation = 5;

    // Mirrors Database.HasPendingModelChanges() from EF Core 9.
    // After upgrading EF Core, replace the body with that single call.
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
        snapshotModel = dbContext.GetService<IModelRuntimeInitializer>().Initialize(snapshotModel, designTime: true);

        var differences = dbContext.GetService<IMigrationsModelDiffer>().GetDifferences(
            snapshotModel.GetRelationalModel(),
            dbContext.GetService<IDesignTimeModel>().Model.GetRelationalModel());

        // Non-deterministic seed values (e.g. Guid.NewGuid()) or a missing migration show up here.
        Assert.True(differences.Count == 0,
            "Model differs from the migrations snapshot:" + Environment.NewLine +
            string.Join(Environment.NewLine, differences.Select(Describe)));
    }

    private static string Describe(MigrationOperation operation) => operation switch
    {
        InsertDataOperation insert => $"InsertData {insert.Table} [{insert.Columns[0]}={FormatKeys(insert.Values, keyColumns: 1)}]",
        DeleteDataOperation delete => $"DeleteData {delete.Table} [{FormatKeys(delete.KeyValues, delete.KeyColumns.Length)}]",
        UpdateDataOperation update => $"UpdateData {update.Table} [{FormatKeys(update.KeyValues, update.KeyColumns.Length)}]",
        ITableMigrationOperation table => $"{operation.GetType().Name} {table.Table}",
        _ => operation.GetType().Name
    };

    private static string FormatKeys(object?[,] values, int keyColumns)
    {
        var rows = values.GetLength(0);
        var keys = Enumerable.Range(0, Math.Min(rows, MaxKeysPerOperation))
            .Select(row => string.Join("/", Enumerable.Range(0, keyColumns).Select(column => values[row, column])));
        var formatted = string.Join(", ", keys);
        return rows > MaxKeysPerOperation ? $"{formatted} (+{rows - MaxKeysPerOperation})" : formatted;
    }
}
