using Microsoft.Extensions.DependencyInjection;
using Tazor.Components.Theming;

namespace Tazor.Components;

public static class ServiceCollectionExtensions
{
    public static void AddTazor(this IServiceCollection services)
    {
        services.AddScoped<OnlineStatusInterop>();
        services.AddScoped<BreakpointInterop>();
    }

    public static void AddTazorTheme(this IServiceCollection services, string primaryColor, string? secondaryColor = null, Action<IBaseTheme>? configureBase = null, Action<ITazorTheme>? configureTheme = null)
    {
        if(secondaryColor == null) 
        {
            secondaryColor = primaryColor;
        }

        var baseTheme = new BaseTheme
        {
            PrimaryColor = secondaryColor,
            SecondaryColor = primaryColor,
            SuccessColor = "green",
            WarningColor = "orange",
            ErrorColor = "red",
            InfoColor = "blue",
            ComponentPadding = "p-3",
            ComponentSpacing = "mb-5 mt-5"
        };

        if(configureBase != null) {
            configureBase(baseTheme);
        }

        services.AddSingleton<ITazorTheme>(sp =>
        {
            var theme = new TazorTheme(baseTheme)
            {
                ComponentHeader = "bg-{PrimaryColor}-500 text-white {ComponentPadding}",
                CodeBlock = "{ComponentPadding} {ComponentSpacing} font-monospace text-sm bg-gray-200 dark:bg-gray-800 border border-gray-500 rounded",
                Table = "min-w-full",
                TableSpacing = "{ComponentSpacing}",
                TableHeader = "bg-{PrimaryColor}-500 text-white",
                TableFooter = "bg-{PrimaryColor}-500 text-white {ComponentPadding}",
                TableCell = "{ComponentPadding}",
                TableHeaderCell = "{ComponentPadding} font-medium cursor-pointer text-sm",
                TableEvenRow = "text-sm text-gray-900 dark:text-white font-light whitespace-nowrap",
                TableOddRow = "text-sm text-gray-900 dark:text-white font-light whitespace-nowrap",
                TableToolbar = "bg-{PrimaryColor}-700 text-white {ComponentPadding} flex justify-between items-center"  
            };

            if(configureTheme != null) {
                configureTheme(theme);
            }

            return theme;
        });
    }
}

