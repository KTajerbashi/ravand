using Ravand.Infra.Data.DataContext;
using Ravand.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Ravand.EndPoint.WebApi.Extensions;

public static class DatabaseInitializerExtensions
{
    public static async Task InitialDatabaseWithSeedDataAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var services = scope.ServiceProvider;
        var logger = services.GetRequiredService<ILoggerFactory>()
                             .CreateLogger("DatabaseInitializer");

        try
        {
            var dbContext = services.GetRequiredService<DatabaseContext>();
            // 1. Apply migrations
            await dbContext.Database.MigrateAsync();

            // 2. Seed data
            await ApplicationDbContextSeed.SeedAsync(dbContext, services);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while initializing the database.");
            throw;
        }
    }
}
