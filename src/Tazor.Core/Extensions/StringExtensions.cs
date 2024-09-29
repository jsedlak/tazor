﻿using System.Text.RegularExpressions;

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

    /// <summary>
    /// Gets the first N letters of each word in the input string.
    /// </summary>
    /// <param name="input">The string to parse</param>
    /// <param name="maxInitials">The number of initials to return</param>
    /// <returns>Returns initials for a name, e.g. John Doe returns JD</returns>
    public static string GetInitials(this string input, int maxInitials = 2)
    {
        var initials = input.Split([" ", "-", "_"], StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x[0].ToString().ToUpperInvariant())
            .Take(maxInitials);

        return string.Join("", initials);
    }
}
