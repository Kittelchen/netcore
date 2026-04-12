using Common.Interfaces;
using Common.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Testkit.UI.ViewModels;
using  Testkit.UI.Views;

namespace Testkit.UI;

public class Setup
{
    public static IServiceCollection AddServices(IServiceCollection services)
    {
        services.AddSingleton<ITestService, TestService>();
        services.AddSingleton<IPlatformService, PlatformService>();
        services.AddSingleton<IShellService, ShellService>();
        // ------------------------------------------------------
        // -- SEPERATOR------------------------------------------
        // ------------------------------------------------------
        services.AddTransient<MainWindow>();
        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<HomePageViewModel>();
        services.AddTransient<HomePageView>();
        services.AddTransient<ButtonViewModel>();
        services.AddTransient<ButtonView>();
        
        return services;
    }
}