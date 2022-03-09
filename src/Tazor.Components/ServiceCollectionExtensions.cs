using Microsoft.Extensions.DependencyInjection;

namespace Tazor.Components;

public static class ServiceCollectionExtensions
{
    public static void AddTazor(this IServiceCollection services)
    {
        services.AddScoped<OnlineStatusInterop>();
        services.AddScoped<BreakpointInterop>();
    }
}

