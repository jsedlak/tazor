using Tazor.Components.App;

namespace Tazor.Components.Builder;

public interface ICanRegisterNotificationProvider
{
    ITazorBuilder WithNotifications<TProvider>()
        where TProvider : class, INotificationProvider;

    ITazorBuilder WithNotifications<TProvider>(Func<IServiceProvider, TProvider> create)
        where TProvider : class, INotificationProvider;
}
