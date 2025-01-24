using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Builder;
using Tazor.Components.Theming;
using Tazor.Components.Layout;
using Tazor.Components.Utility;
using Tazor.ServiceModel;
using Tazor.Services;
using Tazor.Components.DragAndDrop;

namespace Tazor.Components;

/// <summary>
/// Adds fluent tazor capabilities to the service collection
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds tazor to the application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static ITazorBuilder AddTazorServer(this IServiceCollection services)
    {
        return AddTazor(services, true);
    }

    /// <summary>
    /// Adds tazor to the application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static ITazorBuilder AddTazor(this IServiceCollection services)
    {
        return AddTazor(services, false);
    }

    /// <summary>
    /// Adds tazor to the application
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static ITazorBuilder AddTazor(this IServiceCollection services, bool isServer)
    {
        var builder = new TazorBuilder(services)
            .WithDefaults(isServer);

        services.AddScoped<OnlineStatusInterop>();
        services.AddScoped<BreakpointInterop>();

        services.AddCascadingValue<ITheme>(serviceProvider =>
        {
            return new CascadingValueSource<ITheme>("Theme", serviceProvider.GetRequiredService<IThemeManager>().Current, false);
        });

        return builder;
    }

    /// <summary>
    /// Adds the gravatar avatar provider to the tazor engine 
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static ITazorBuilder WithGravatars(this ITazorBuilder builder)
    {
        return builder.With<IAvatarProvider>(
            services => services.AddSingleton<IAvatarProvider, GravatarAvatarProvider>()
        );
    }
    
    /// <summary>
    /// Adds drag and drop capabilities to tazor
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static ITazorBuilder WithDragAndDrop(this ITazorBuilder builder)
    {
        builder.With<IDragProvider>(services =>
        {
            services.AddSingleton<IDragProvider, DefaultDragProvider>();
            services.AddCascadingValue<IDragProvider>("DragProvider", sp => sp.GetRequiredService<IDragProvider>());
        });

        return builder;
    }
}
