namespace Tazor.Components.Theming;

public class ThemeManager : IThemeManager
{
    public ITheme Current { get; set; } = null!;

    public IEnumerable<ITheme> Themes { get; set; } = Enumerable.Empty<ITheme>();
}
