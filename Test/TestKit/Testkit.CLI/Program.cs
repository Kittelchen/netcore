using Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Testkit.CLI;

class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => Setup.AddServices(services))
            .Build();

        var testkit = host.Services.GetRequiredService<TestKit>();
        testkit.Run();
    }
}