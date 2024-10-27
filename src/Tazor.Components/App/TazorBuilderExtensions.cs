using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Builder;

namespace Tazor.Components.App;

/// <summary>
/// Adds common app services via the fluent api
/// </summary>
public static class TazorBuilderExtensions
{
    /// <summary>
    /// Registers the <see cref="InMemoryNotificationProvider"/> as the <see cref="INotificationProvider"/>
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static ITazorBuilder WithInMemoryNotifications(this ITazorBuilder builder)
    {
        return builder.With<INotificationProvider>(services => services.AddSingleton<INotificationProvider, InMemoryNotificationProvider>());
    }
}