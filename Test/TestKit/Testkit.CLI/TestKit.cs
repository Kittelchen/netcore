using Common.Interfaces;
namespace Testkit.CLI;

public class TestKit
{
    private readonly ITestService _testService;
    private readonly IPlatformService _platformService;

    public TestKit(ITestService testService,
        IPlatformService platformService)
    {
        _testService = testService;
        _platformService = platformService;
    }

    public void Run()
    {
        if (_platformService.IsLinux()) 
            Console.WriteLine($"{_testService.GetMessage()} from {_platformService.GetOS()}");
    }
}