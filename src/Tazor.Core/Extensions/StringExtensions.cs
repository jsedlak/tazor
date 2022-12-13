namespace Tazor.Extensions;

public static class StringExtensions
{
    public static string ToSlug(this string value)
    {
        return value
            .Replace(" ", "-")
            .Replace("\t", "")
            .Replace("\r", "")
            .Replace("\n", "")
            .ToLowerInvariant();
    }
}
