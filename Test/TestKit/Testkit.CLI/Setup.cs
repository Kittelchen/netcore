using Common.Interfaces;
using Common.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Testkit.CLI;

public static class Setup
{
    public static IServiceCollection AddServices(IServiceCollection services)
    {
        services.AddSingleton<ITestService, TestService>();
        services.AddSingleton<IPlatformService, PlatformService>();
        // ------------------------------------------------------
        // -- SEPERATOR------------------------------------------
        // ------------------------------------------------------
        services.AddTransient<TestKit>();
        return services;
    }
}