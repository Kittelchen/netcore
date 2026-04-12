using Common.Interfaces;

namespace Common.Services;

public class TestService : ITestService
{
    public string GetMessage()
    {
        return "Hello, World!";
    }
}