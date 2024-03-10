namespace Tazor.Components.Theming;

/// <summary>
/// Injectable configuration based options for loading themes
/// </summary>
public sealed class TazorOptions
{
    /// <summary>
    /// Gets or Sets a list of themes that may be loaded into the application
    /// </summary>
    public IEnumerable<TazorThemeOptions> Themes { get; set; } = Enumerable.Empty<TazorThemeOptions>();
}
