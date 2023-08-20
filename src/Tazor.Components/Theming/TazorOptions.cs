namespace Tazor.Components.Theming;

public sealed class TazorOptions
{
    public IEnumerable<TazorThemeOptions> Themes { get; set; } = Enumerable.Empty<TazorThemeOptions>();
}
