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
                DialogOverlay = "fixed inset-0 bg-gray-800 bg-opacity-75 overflow-y-auto h-full w-full",
                DialogWindow = "relative top-10 mx-auto  {ComponentBackground} {ComponentPadding} rounded",
                DialogWindowInner = "",
                DialogHeader = "flex justify-between items-center mb-3 pb-2 border-b border-b-white",
                DialogContent = "",
                DialogFooter = "mt-3 flex justify-end items-center gap-4",
                Button = "cursor-pointer px-3 py-2 inline-block rounded",
                ButtonInner = "flex items-center gap-1 w-full",
                Menu = "",
                MenuAnchor = "cursor-pointer whitespace-nowrap",
                MenuDropdownWrapper = "bg-{PrimaryColor}-500 text-white p-3",
                MenuItem = "mb-2",
                MenuHeadingAnchor = "cursor-pointer whitespace-nowrap",
                MenuHeadingItem = "hover:bg-{PrimaryColor}-500 text-white px-5 py-2 rounded-t rounded-b hover:rounded-b-none",
                VerticalMenu = "",
                HorizontalMenu = "",
                TextBox = "px-3 py-2 w-full border rounded dark:border-gray-900 dark:bg-gray-800 dark:text-white",
                SelectInput = "px-3 py-2 w-full border rounded dark:border-gray-900 dark:bg-gray-800 dark:text-white",
                Label = "mb-1 block",
                SubLabel = "mb-2 block text-sm",

                AlertGlobal = "my-3 rounded px-4 py-3 shadow-md flex items-center justify-between",
                AlertError = "bg-red-100 border-l-4 border-red-500 text-red-700",
                AlertInfo = "bg-blue-100 border-l-4 border-blue-500 text-blue-700",
                AlertSuccess = "bg-green-100 border-l-4 border-green-500 text-green-700",
                AlertWarning = "bg-yellow-100 border-l-4 border-yellow-500 text-yellow-700"
            };

            if(configureTheme != null) {
                configureTheme(theme);
            }

            return theme;
        });
    }
}

