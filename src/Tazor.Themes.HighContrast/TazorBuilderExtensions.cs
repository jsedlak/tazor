using System.Text.Json;
using Tazor.Components.Builder;
using Tazor.Components.Theming;

namespace Tazor.Themes.HighContrast;

public static class TazorBuilderExtensions
{
    public static ITazorBuilder WithHighContrastThemes(this ITazorBuilder builder)
    {
        builder.WithTheme("High Contrast", () =>
        {
            using var stream = new MemoryStream(ThemeFiles.high_contrast);

            // load the theme from the resource file
            var theme = JsonSerializer.Deserialize<TazorTheme>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;

            // register our css file
            theme.CssFiles = ["_content/Tazor.Themes.HighContrast/high-contrast.theme.css"];

            return theme;
        }, isDefault: false);

        return builder;
    }
}
