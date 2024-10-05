using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Builder;
using Tazor.Components.Theming;
using Tazor.Components.Utility;
using Tazor.ServiceModel;
using Tazor.Services;

namespace Tazor.Components;

public static class ServiceCollectionExtensions
{
    public static ITazorBuilder AddTazor(this IServiceCollection services)
    {
        var builder = new TazorBuilder(services)
            .WithDefaults();

        services.AddScoped<OnlineStatusInterop>();
        services.AddScoped<BreakpointInterop>();

        services.AddCascadingValue<ITheme>(serviceProvider =>
        {
            return new CascadingValueSource<ITheme>("Theme", serviceProvider.GetRequiredService<IThemeManager>().Current, false);
        });


        return builder;
    }

    public static ITazorBuilder WithGravatars(this ITazorBuilder builder)
    {
        return builder.With<IAvatarProvider>(
            services => services.AddSingleton<IAvatarProvider, GravatarAvatarProvider>()
        );
    }
}
