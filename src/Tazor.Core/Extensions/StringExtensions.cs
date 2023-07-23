using System.Text.RegularExpressions;

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

    public static string CamelCase(this string s)
    {
        var x = s.Replace("_", "");
        if (x.Length == 0) return "null";
        x = Regex.Replace(x, "([A-Z])([A-Z]+)($|[A-Z])",
            m => m.Groups[1].Value + m.Groups[2].Value.ToLower() + m.Groups[3].Value);
        return char.ToLower(x[0]) + x.Substring(1);
    }

    public static string PascalCase(this string s)
    {
        var x = CamelCase(s);
        return char.ToUpper(x[0]) + x.Substring(1);
    }

    public static string TrimStart(this string input, string trim)
    {
        if (!input.StartsWith(trim, StringComparison.OrdinalIgnoreCase))
        {
            return input;
        }

        return input.Substring(trim.Length);
    }
}
