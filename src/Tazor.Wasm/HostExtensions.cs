using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Theming;

namespace Tazor.Wasm;

public static class HostExtensions
{
    public static async Task<WebAssemblyHost> UseTazor(this WebAssemblyHost host)
    {
        var themeManager = host.Services.GetRequiredService<IThemeManager>();
        var defaultTheme = themeManager.Themes.FirstOrDefault(m => m.IsDefault) ?? themeManager.Themes.FirstOrDefault() ?? new TazorTheme();

        await themeManager.SetThemeAsync(defaultTheme);

        return host;
    }
}
