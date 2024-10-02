using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Builder;

namespace Tazor.Components.App;

public static class TazorBuilderExtensions
{
    public static ITazorBuilder WithInMemoryNotifications(this ITazorBuilder builder)
    {
        return builder.With<INotificationProvider>(services => services.AddSingleton<INotificationProvider, InMemoryNotificationProvider>());
    }
}