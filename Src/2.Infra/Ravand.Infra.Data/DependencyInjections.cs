using Ravand.Core.Domain.Entities.Security;
using Ravand.Infra.Data.DataContext;
using Ravand.Infra.Data.DataContext.Interceptors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ravand.Infra.Data;

public static class DependencyInjections
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //  Register Database Context
        services.AddDbContext<DatabaseContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                sql => sql.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)
            );
            options.AddInterceptors(new ShadowPropertySaveChangesInterceptor());
        });

        

        return services;
    }
}
