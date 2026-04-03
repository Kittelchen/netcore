using Common.Interfaces;

namespace Common.Services;

public class PlatformService : IPlatformService
{
    private const string Unix = "unix";
    private const string Windows = "windows";
    
    public string GetOS() => Environment.OSVersion.Platform.ToString();
    public bool IsWindows() => false;  // main focus not on Windows right now
    public bool IsLinux() => GetOS().Equals(Unix, StringComparison.InvariantCultureIgnoreCase);
}