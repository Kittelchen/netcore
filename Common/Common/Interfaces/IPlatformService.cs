namespace Common.Interfaces;

public interface IPlatformService
{
    public string GetOS();
    public bool IsWindows();
    public bool IsLinux();
}