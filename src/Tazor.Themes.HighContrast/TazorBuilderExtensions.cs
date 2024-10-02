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
            return JsonSerializer.Deserialize<TazorTheme>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }, false);

        return builder;
    }
}
