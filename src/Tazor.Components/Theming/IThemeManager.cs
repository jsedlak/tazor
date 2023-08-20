namespace Tazor.Components.Theming;

public interface IThemeManager
{
    ITheme Current { get; set; }

    IEnumerable<ITheme> Themes { get; set; }
}
