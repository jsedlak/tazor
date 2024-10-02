
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

        await _jsRuntime.InvokeVoidAsync("applyCss", $"_content/themes/{theme.Name}.css");

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
