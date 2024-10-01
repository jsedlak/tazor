using System.Text.Json;
using Tazor.Components.Builder;
using Tazor.Components.Theming;

namespace Tazor.Themes.VisualStudio;

public static class TazorBuilderExtensions
{
    public static ITazorBuilder WithVisualStudioThemes(this ITazorBuilder builder)
    {
        builder.WithTheme("Visual Studio", () =>
        {
            using var stream = new MemoryStream(ThemeFiles.visual_studio);
            return JsonSerializer.Deserialize<TazorTheme>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }, false);

        return builder;
    }
}
