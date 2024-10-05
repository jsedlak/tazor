using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Theming;

/// <summary>
/// Provides a dependency injectable manager for themes
/// </summary>
public interface IThemeManager
{
    /// <summary>
    /// Initializes the theme manager by deploying the default theme
    /// </summary>
    /// <returns></returns>
    Task Initialize();

    /// <summary>
    /// Sets the current theme by looking the name up in the loaded theme list and propagates the changes
    /// </summary>
    /// <param name="themeName"></param>
    /// <returns></returns>
    Task SetThemeAsync(string themeName);

    /// <summary>
    /// Sets the current theme and propagates the changes
    /// </summary>
    /// <param name="theme"></param>
    /// <returns></returns>
    Task SetThemeAsync(ITheme theme);

    /// <summary>
    /// Gets or Sets the current theme
    /// </summary>
    ITheme Current { get; set; }

    /// <summary>
    /// Gets or Sets the list of themes available for the application
    /// </summary>
    IEnumerable<ITheme> Themes { get; set; }

    /// <summary>
    /// Gets or Sets the event that is triggered when the current theme changes
    /// </summary>
    EventHandler<ITheme>? ThemeChanged { get; set; }
}
