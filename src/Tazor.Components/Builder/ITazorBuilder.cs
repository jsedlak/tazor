using Microsoft.Extensions.DependencyInjection;

namespace Tazor.Components.Builder;

public interface ITazorBuilder : ICanRegisterNotificationProvider, ICanRegisterTheme
{
    ITazorBuilder With<TService>(Action<IServiceCollection> register);

    IServiceCollection Build();
}
