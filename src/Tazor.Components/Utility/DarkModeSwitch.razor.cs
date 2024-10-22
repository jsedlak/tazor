using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Utility;

public partial class DarkModeSwitch : TazorBaseComponent
{
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        try
        {
            if (firstRender)
            {
                IsDarkModeEnabled = await JsRuntime.InvokeAsync<bool>("getDarkMode");
            }
        }
        catch
        {
            Console.WriteLine("Uh oh.");
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    public async void OnHandleChange(bool newValue)
    {
        IsDarkModeEnabled = newValue;

        await IsDarkModeEnabledChanged.InvokeAsync(newValue);

        await JsRuntime.InvokeVoidAsync("setDarkMode", IsDarkModeEnabled);
        StateHasChanged();
    }

    [Parameter]
    public bool IsDarkModeEnabled { get; set; } = true;

    [Parameter]
    public EventCallback<bool> IsDarkModeEnabledChanged { get; set; }

    [Inject]
    private IJSRuntime JsRuntime { get; set; }
}
