using Common.Interfaces;
namespace Testkit.CLI;

public class TestKit
{
    private readonly ITestService _testService;

    public TestKit(ITestService testService)
    {
        _testService = testService;
    }

    public void Run()
    {
        Console.WriteLine(_testService.GetMessage());
    }
}