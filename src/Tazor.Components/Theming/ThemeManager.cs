namespace Tazor.Components.Theming;

/// <summary>
/// Provides basic theming for the application
/// </summary>
public class ThemeManager : IThemeManager
{
    /// <summary>
    /// Gets or Sets the current theme
    /// </summary>
    public ITheme Current { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the themes available for the application
    /// </summary>
    public IEnumerable<ITheme> Themes { get; set; } = Enumerable.Empty<ITheme>();
}
