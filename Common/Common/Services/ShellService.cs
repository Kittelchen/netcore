using System.Diagnostics;
using Common.Interfaces;

namespace Common.Services;

public class ShellService : IShellService
{
    private readonly IPlatformService _platformService;

    public ShellService(IPlatformService platformService)
    {
        _platformService = platformService;
    }
    public string RunShell(string cmd)
    {
        if (_platformService.IsWindows()) return "Windows not supported";
        
        var psi = new ProcessStartInfo
        {
            UseShellExecute = false,
            CreateNoWindow = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            FileName = "/bin/bash",
            Arguments = $"-c \"{cmd}\""
        };
        
        using var process = Process.Start(psi);
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return output.Trim();
    }
}