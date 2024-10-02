using Tazor.Components.Theming;

namespace Tazor.Components.Builder;

public interface ICanRegisterTheme
{
    ITazorBuilder WithTheme(string name, Func<ITheme> create, bool isDefault = false);
}