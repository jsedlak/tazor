namespace Tazor.Components.Theming;

/// <summary>
/// Provides a dependency injectable manager for themes
/// </summary>
public interface IThemeManager
{
    /// <summary>
    /// Gets or Sets the current theme
    /// </summary>
    ITheme Current { get; set; }

    /// <summary>
    /// Gets or Sets the list of themes available for the application
    /// </summary>
    IEnumerable<ITheme> Themes { get; set; }
}
