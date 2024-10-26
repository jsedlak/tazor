using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Theming;

namespace Tazor.Wasm;

/// <summary>
/// Extends the host builder with Tazor methods
/// </summary>
public static class HostExtensions
{
    /// <summary>
    /// Applies theming to the app
    /// </summary>
    /// <param name="host"></param>
    /// <returns></returns>
    public static async Task<WebAssemblyHost> UseTazor(this WebAssemblyHost host)
    {
        var themeManager = host.Services.GetRequiredService<IThemeManager>();
        await themeManager.Initialize();

        return host;
    }

    /// <summary>
    /// Applies theming with a specific theme to the app
    /// </summary>
    /// <param name="host"></param>
    /// <param name="themeName"></param>
    /// <returns></returns>
    public static async Task<WebAssemblyHost> UseTazor(this WebAssemblyHost host, string themeName)
    {
        var themeManager = host.Services.GetRequiredService<IThemeManager>();
        await themeManager.Initialize();

        await themeManager.SetThemeAsync(themeName);

        return host;
    }
}
