using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Tazor.Components;
using Tazor.Samples.Client;
using Tazor.Components.Theming;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTazor();
builder.Services.AddTazorTheme(
    primaryColor: "blue",
    configureTheme: (theme) => {
        theme["IntroParagraph"] = "leading-loose text-lg";
    }
);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
