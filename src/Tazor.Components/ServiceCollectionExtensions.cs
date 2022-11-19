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
            ComponentSpacing = "mb-5 mt-5",
            ComponentBackground = "bg-gray-500",
            Paragraph = "mt-3 mb-3",
            Lead = "mt-3 mb-3 leading-loose text-lg",
            Heading1 = "font-medium text-4xl",
            Heading2 = "font-medium text-2xl",
            Heading3 = "font-medium text-xl",
            Heading4 = "font-medium text-lg",
            Callout = $"border border-{primaryColor}-200 rounded p-3 mt-3 mb-3",
            Quote = $"border-l-4 border-{primaryColor}-200 mx-5 my-3 pl-3 text-justified",
            InlineCode = "inline font-monospace text-sm bg-gray-200 dark:bg-gray-800 border border-gray-500 rounded",
            CodeBlock = "mb-5 mt-5 p-3 font-monospace text-sm bg-gray-200 dark:bg-gray-800 border border-gray-500 rounded",
        };

        if(configureBase != null) {
            configureBase(baseTheme);
        }

        services.AddSingleton<ITazorTheme>(sp =>
        {
            var theme = new TazorTheme(baseTheme)
            {
                ComponentHeader = "bg-{PrimaryColor}-500 dark:bg-{PrimaryColor}-700 text-white {ComponentPadding}",
                
                Table = "min-w-full",
                TableSpacing = "{ComponentSpacing}",
                TableHeader = "bg-{PrimaryColor}-500 dark:bg-{PrimaryColor}-800 text-white",
                TableFooter = "bg-{PrimaryColor}-500 dark:bg-{PrimaryColor}-700 text-white {ComponentPadding}",
                TableSummary = "bg-{PrimaryColor}-500 dark:bg-{PrimaryColor}-800 text-white {ComponentPadding}",
                TableCell = "{ComponentPadding}",
                TableHeaderCell = "{ComponentPadding} font-medium cursor-pointer text-sm",
                TableEvenRow = "bg-gray-100 dark:bg-gray-800 text-sm text-gray-900 dark:text-white font-light whitespace-nowrap",
                TableOddRow = "bg-gray-200 dark:bg-gray-900 text-sm text-gray-900 dark:text-white font-light whitespace-nowrap",
                TableToolbar = "bg-{PrimaryColor}-700 text-white {ComponentPadding} flex justify-between items-center",
                Panel = "{ComponentBackground} {ComponentSpacing} {ComponentPadding} rounded",
                DialogWindow = "{ComponentBackground} {ComponentPadding} rounded",
                Button = "cursor-pointer px-3 py-2 inline-block rounded",
                ButtonInner = "flex items-center gap-1 w-full",
                Menu = "",
                MenuAnchor = "cursor-pointer whitespace-nowrap",
                MenuDropdownWrapper = "bg-{PrimaryColor}-500 text-white p-3",
                MenuItem = "mb-2",
                MenuHeadingAnchor = "cursor-pointer whitespace-nowrap",
                MenuHeadingItem = "hover:bg-{PrimaryColor}-500 text-white px-5 py-2 rounded-t rounded-b hover:rounded-b-none",
                VerticalMenu = "",
                HorizontalMenu = ""
            };

            if(configureTheme != null) {
                configureTheme(theme);
            }

            return theme;
        });
    }
}

