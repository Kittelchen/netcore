namespace Common.Extensions;

public static class StringExtension
{
    public static bool IsEQ(this string str) => str.Equals(str, StringComparison.InvariantCultureIgnoreCase);
}