using Tazor.Components.Theming;

namespace Tazor.Components.Builder;

/// <summary>
/// Provides theming support as a fluent interface with the ITazorBuilder
/// </summary>
public interface ICanRegisterTheme
{
    /// <summary>
    /// Includes a theme in the Tazor SDK for selection via code or ThemeSwitcher component
    /// </summary>
    /// <param name="name"></param>
    /// <param name="create"></param>
    /// <param name="isDefault"></param>
    /// <returns></returns>
    ITazorBuilder WithTheme(string name, Func<ITheme> create, bool isDefault = false);
}