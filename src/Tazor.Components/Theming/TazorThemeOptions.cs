namespace Tazor.Components.Theming;

/// <summary>
/// Describes the options for a Tazor theme to be loaded into the ThemeManager
/// </summary>
public sealed class TazorThemeOptions
{
    /// <summary>
    /// Gets or Sets the name of the theme
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the path to the theme file
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Gets or Sets whether or not the theme should be the default
    /// </summary>
    public bool IsDefault { get; set; }
}