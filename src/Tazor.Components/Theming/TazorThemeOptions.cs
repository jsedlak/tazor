namespace Tazor.Components.Theming;

public sealed class TazorThemeOptions
{
    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public bool IsDefault { get; set; }
}