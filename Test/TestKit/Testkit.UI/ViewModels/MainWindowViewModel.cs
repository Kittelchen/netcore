using Avalonia.Platform;
using Common.Interfaces;

namespace Testkit.UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly IPlatformService _platformService;
    private readonly IShellService _shellService;

    public MainWindowViewModel(IPlatformService platformService, IShellService shellService)
    {
        _platformService = platformService;
        _shellService = shellService;
        SetGreetingMessage();
    }
        
    public string Greeting { get; private set;  } = $"Welcome to Avalonia!";

    private void SetGreetingMessage()
    {
        Greeting =  $"Welcome to Avalonia! {_shellService.RunShell("uname -r")}";
    }
}