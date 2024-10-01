using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using Tazor.Components.App;
using Tazor.Components.Theming;

namespace Tazor.Components.Builder;

internal sealed class TazorBuilder : ITazorBuilder
{
    private readonly IServiceCollection _services;
    private readonly Dictionary<Type, Action<IServiceCollection>> _registrations = new();
    private readonly List<ITheme> _themes = new();

    internal TazorBuilder(IServiceCollection services)
    {
        _services = services;
    }

    public IServiceCollection Build()
    {
        foreach (var registrationCallback in _registrations.Values)
        {
            registrationCallback(_services);
        }

        return _services;
    }

    public ITazorBuilder WithDefaults()
    {
        this.WithTheme("Tazor", () =>
        {
            using var stream = new MemoryStream(IncludedThemes.tazor_theme);
            return JsonSerializer.Deserialize<TazorTheme>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
        }, true);

        return this
            .With<INotificationProvider>(services => services.AddSingleton<INotificationProvider, InMemoryNotificationProvider>())
            .With<IThemeManager>(services => services.AddSingleton<IThemeManager, ThemeManager>(sp =>
            {
                return new ThemeManager()
                {
                    Themes = _themes,
                    Current = _themes.FirstOrDefault(m => m.IsDefault) ?? _themes.FirstOrDefault() ?? new TazorTheme()
                };
            }));
    }

    public ITazorBuilder With<TService>(Action<IServiceCollection> register)
    {
        _registrations[typeof(TService)] = register;
        return this;
    }

    public ITazorBuilder WithTheme(string name, Func<ITheme> create, bool isDefault = false)
    {
        // namecheck
        if (_themes.Any(m => m.Name == name))
        {
            throw new InvalidOperationException("Cannot add a theme that already exists.");
        }

        var theme = create();

        // setup the metadata
        theme.Name = name;
        theme.IsDefault = isDefault;

        _themes.Add(theme);

        return this;
    }

    public ITazorBuilder WithNotifications<TProvider>()
        where TProvider : class, INotificationProvider
    {

        return this;
    }

    public ITazorBuilder WithNotifications<TProvider>(Func<IServiceProvider, TProvider> create)
        where TProvider : class, INotificationProvider
    {
        _services.AddSingleton<INotificationProvider, TProvider>(create);
        return this;
    }
}
