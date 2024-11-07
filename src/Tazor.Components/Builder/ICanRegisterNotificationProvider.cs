using Tazor.Components.App;

namespace Tazor.Components.Builder;

/// <summary>
/// Provides notification provider fluent API
/// </summary>
public interface ICanRegisterNotificationProvider
{
    /// <summary>
    /// Registers a notification provider type
    /// </summary>
    /// <typeparam name="TProvider"></typeparam>
    /// <returns></returns>
    ITazorBuilder WithNotifications<TProvider>()
        where TProvider : class, INotificationProvider;

    /// <summary>
    /// Registers a notification provider type with a registration callback
    /// </summary>
    /// <param name="create"></param>
    /// <typeparam name="TProvider"></typeparam>
    /// <returns></returns>
    ITazorBuilder WithNotifications<TProvider>(Func<IServiceProvider, TProvider> create)
        where TProvider : class, INotificationProvider;
}
