using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using Tazor.Components;
using Tazor.Components.Theming;

namespace Tazor.Wasm;

public static class BuilderExtensions
{
    public static async Task AddTazorAsync(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddTazor();

        var http = new HttpClient
        {
            BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        };

        using var response = await http.GetAsync("tazor.config.json");
        using var stream = await response.Content.ReadAsStreamAsync();
        builder.Configuration.AddJsonStream(stream);

        var options = new TazorOptions();
        builder.Configuration.GetSection("tazor").Bind(options);

        Console.WriteLine("Theme Count: " + options.Themes.Count());

        var themes = new List<ITheme>();

        foreach(var themeOptions in options.Themes)
        {
            using var themeFileResponse = await http.GetAsync(themeOptions.Path);
            var themeJson = await themeFileResponse.Content.ReadAsStringAsync();

            var theme = JsonSerializer.Deserialize<TazorTheme>(themeJson, new JsonSerializerOptions {  PropertyNameCaseInsensitive = true });

            if (theme == null)
            {
                throw new InvalidDataException("Cannot parse the theme.");
            }

            theme.Name = themeOptions.Name;
            theme.IsDefault = themeOptions.IsDefault;

            themes.Add(theme);
        }

        var themeManager = new ThemeManager
        {
            Themes = themes,
            Current =
                    themes.FirstOrDefault(m => m.IsDefault) ??
                    themes.FirstOrDefault() ??
                    new TazorTheme()
        };

        builder.Services.AddSingleton<IThemeManager>(themeManager);
    }

}