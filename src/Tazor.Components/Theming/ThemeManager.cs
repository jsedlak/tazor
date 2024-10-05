
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Theming;

/// <summary>
/// Provides basic theming for the application
/// </summary>
public class ThemeManager : IThemeManager
{
    private readonly IJSRuntime _jsRuntime;

    public ThemeManager(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    /// <summary>
    /// Applies the css files to the application
    /// </summary>
    /// <param name="cssFiles">The list of css files to set in the head element</param>
    private ValueTask SetThemeCssFiles(IEnumerable<string> cssFiles)
    {
        if(cssFiles is null || !cssFiles.Any())
        {
            cssFiles = [];
        }

        return _jsRuntime.InvokeVoidAsync("applyCss", cssFiles.ToArray());
    }

    /// <inheritdoc/>
    public async Task Initialize()
    {
        await SetThemeCssFiles(Current.CssFiles);
    }


    /// <summary>
    /// Sets the current theme by looking up the theme by name
    /// </summary>
    /// <param name="themeName">The name of the theme</param>
    /// <returns></returns>
    public Task SetThemeAsync(string themeName)
    {
        var result = Themes.First(x => x.Name == themeName);

        return SetThemeAsync(result);
    }

    /// <summary>
    /// Sets the current theme using a theme object
    /// </summary>
    /// <param name="theme">The theme</param>
    /// <returns></returns>
    public async Task SetThemeAsync(ITheme theme)
    {
        Current = theme;
        await SetThemeCssFiles(theme.CssFiles);

        if (ThemeChanged != null)
        {
            ThemeChanged.Invoke(this, Current);
        }
    }

    /// <summary>
    /// Gets or Sets the current theme
    /// </summary>
    public ITheme Current { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the event that is triggered when the current theme changes
    /// </summary>
    public EventHandler<ITheme>? ThemeChanged { get; set; }

    /// <summary>
    /// Gets or Sets the themes available for the application
    /// </summary>
    public IEnumerable<ITheme> Themes { get; set; } = Enumerable.Empty<ITheme>();   
}
