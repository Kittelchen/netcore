using Common.Interfaces;
namespace Testkit.CLI;

public class TestKit
{
    private readonly ITestService _testService;
    private readonly IPlatformService _platformService;
    private readonly IShellService _shellService;

    public TestKit(ITestService testService,
        IPlatformService platformService,
        IShellService shellService)
    {
        _testService = testService;
        _platformService = platformService;
        _shellService = shellService;
    }

    public void Run()
    {
       Console.WriteLine(_shellService.RunShell("uname -r"));
    }
}