using Microsoft.Extensions.DependencyInjection;

namespace Tazor.Components.Builder;

/// <summary>
/// Provides a fluent interface for registering and configuring the Tazor SDK
/// </summary>
public interface ITazorBuilder : ICanRegisterNotificationProvider, ICanRegisterTheme
{
    /// <summary>
    /// Registers a provider type with the builder, replacing any existing provider with the new registration callback
    /// </summary>
    /// <param name="register"></param>
    /// <typeparam name="TService"></typeparam>
    /// <returns></returns>
    ITazorBuilder With<TService>(Action<IServiceCollection> register);

    /// <summary>
    /// Registers any services with the IServiceCollection
    /// </summary>
    /// <returns></returns>
    IServiceCollection Build();
}
