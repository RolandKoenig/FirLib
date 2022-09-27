using FirLib.Core.Services.ConfigurationFiles;
using FirLib.Core.Services.SingleApplicationInstance;
using Microsoft.Extensions.DependencyInjection;

namespace FirLib.Core.Hosting;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMutexBasedSingleApplicationInstance(this IServiceCollection services,
        string mutexName)
    {
        services.AddSingleton<ISingleApplicationInstanceService, MutexBasedSingleApplicationInstanceService>(
            _ => new MutexBasedSingleApplicationInstanceService(mutexName));
        return services;
    }

    public static IServiceCollection AddApplicationConfigurationFileAccessors(
        this IServiceCollection services, string appName)
    {
        services.AddSingleton<IConfigurationFileAccessors, ConfigurationFileAccessors>(
            _ => new ConfigurationFileAccessors(appName));
        return services;
    }
}