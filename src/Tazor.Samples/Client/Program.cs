using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tazor.Components;
using Tazor.Samples.Client;
using Tazor.Components.Theming;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseTheme = new BaseTheme{
    PrimaryColor = "blue",
    SecondaryColor = "blue",
    SuccessColor = "green",
    WarningColor = "orange",
    ErrorColor = "red",
    InfoColor = "blue",
    ComponentPadding = "p-3",
    ComponentSpacing = "mb-5 mt-5"
};
 // builder.Configuration.GetSection("tazor.theme.base").Get<BaseTheme>();
builder.Services.AddSingleton<ITazorTheme>(sp => {
    var theme = new TazorTheme(baseTheme) {
        ComponentHeader = "bg-{PrimaryColor}-500"
    };
    return theme;
});

builder.Services.AddTazor();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
