﻿using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Theming;

namespace Tazor.Wasm;

public static class HostExtensions
{
    public static async Task<WebAssemblyHost> UseTazor(this WebAssemblyHost host)
    {
        var themeManager = host.Services.GetRequiredService<IThemeManager>();
        await themeManager.Initialize();

        return host;
    }

    public static async Task<WebAssemblyHost> UseTazor(this WebAssemblyHost host, string themeName)
    {
        var themeManager = host.Services.GetRequiredService<IThemeManager>();
        await themeManager.Initialize();

        await themeManager.SetThemeAsync(themeName);

        return host;
    }
}
