using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tazor.Docs;
using Tazor.Components;
using Tazor.Components.Theming;
using System.Text;
using System.Diagnostics;
using Tazor.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.AddTazorAsync();
// builder.Services.AddTazor();
// builder.Services.AddTazorTheming();

//builder.Services.AddTazorTheme(
//    primaryColor: "indigo",
//    secondaryColor: "violet",
//    configureBase: null,
//    configureTheme: (theme) => {
//        theme["IntroParagraph"] = "leading-loose text-lg";

//        //theme.TableToolbar = "bg-brand-bg-300 text-white rounded-t {ComponentPadding} flex justify-between items-center";
//        theme.Table = "min-w-full";
//        theme.TableHeader = "bg-gray-50";
//        theme.TableHeaderCell = "px-3 py-3.5 text-left text-sm font-semibold text-gray-900";
//        theme.TableBody = "divide-y divide-gray-200 bg-white";
//        theme.TableEvenRow = "";
//        theme.TableOddRow = "";
//        theme.TableCell = "whitespace-nowrap px-3 py-4 text-sm text-gray-500";
//        theme.TableFooter = "p-3";
//        theme.TableSpacing = "bg-gray-50 overflow-x-auto";

//        theme.DialogWindow = "relative transform overflow-hidden rounded-lg bg-white text-left shadow-xl transition-all sm:my-8 sm:w-full sm:max-w-lg";
//        theme.DialogWindowInner = "";
//        theme.DialogOverlay = "fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity";
//        theme.DialogHeader = "px-4 bg-white pt-5 pb-4";
//        theme.DialogContent = "px-4";
//        theme.DialogFooter = "bg-gray-200 py-3 gap-2 sm:flex sm:flex-row-reverse sm:px-6";

//        theme.Label = "block text-sm font-medium text-gray-700";
//        theme.TextBox = "block w-full rounded-md px-3 py-2 border border-gray-300 shadow-sm focus:border-brand-primary-500 focus:ring-brand-primary-500 sm:text-sm";
//        theme.Button = "inline-flex items-center rounded-md border border-transparent bg-brand-primary-500 px-3 py-2 text-sm font-medium leading-4 text-white shadow-sm hover:bg-brand-primary-600 focus:outline-none focus:ring-2 focus:ring-brand-primary-500 focus:ring-offset-2";
//        theme.SelectInput = "mt-1 block w-full rounded-md border border-gray-300 py-2 pl-3 pr-10 text-base focus:border-brand-primary-500 focus:outline-none focus:ring-brand-primary-500 sm:text-sm";

//        theme.Panel = "mt-3 mb-3 rounded-lg bg-white px-4 py-5 shadow sm:p-6";
//    }
//);

var app = builder.Build();
    
await app.RunAsync();
