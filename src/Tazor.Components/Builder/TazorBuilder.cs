﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
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

    public ITazorBuilder WithDefaults(bool isServer = false)
    {
        this.WithTheme("Tazor", () =>
        {
            using var stream = new MemoryStream(IncludedThemes.tazor_theme);
            var theme = JsonSerializer.Deserialize<TazorTheme>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true })!;
            theme.CssFiles = [ "_content/Tazor.Components/tazor.theme.css"];
            return theme;
        }, true);

        return this
            .With<INotificationProvider>(services => services.AddSingleton<INotificationProvider, InMemoryNotificationProvider>())
            .With<IThemeManager>(services => services.AddSingleton<IThemeManager, ThemeManager>(sp =>
            {
                var jsRuntime = isServer ? null : sp.GetService<IJSRuntime>();
                return new ThemeManager(jsRuntime)
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
        return this.With<INotificationProvider>(
            services => services.AddSingleton<INotificationProvider, TProvider>()
        );
    }

    public ITazorBuilder WithNotifications<TProvider>(Func<IServiceProvider, TProvider> create)
        where TProvider : class, INotificationProvider
    {
        return this.With<INotificationProvider>(
            services => services.AddSingleton<INotificationProvider, TProvider>(create)
        );
    }
}
