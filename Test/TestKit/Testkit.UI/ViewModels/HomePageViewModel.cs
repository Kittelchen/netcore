using Common.Interfaces;

namespace Testkit.UI.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    private readonly IPlatformService _platformService;

    public HomePageViewModel(IPlatformService platformService)
    {
        _platformService = platformService;
    }
}