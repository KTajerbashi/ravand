using Ravand.Core.Application;
using Ravand.Infra.Data;
using Microsoft.AspNetCore.Identity;

namespace Ravand.EndPoint.WebApi;

public static class DependencyInjections
{
    public static IServiceCollection AddWebApi(this IServiceCollection services, IConfiguration configuration)
    {
        var assemblies = ("Ravand").GetAssemblies().ToArray();
        services.AddInfrastructure(configuration);
        services.AddApplication(configuration, assemblies);
        return services;
    }
}
