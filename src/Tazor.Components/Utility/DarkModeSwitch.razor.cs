using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Utility;

/// <summary>
/// Provides the ability to switch between dark/light theming modes
/// </summary>
public partial class DarkModeSwitch : TazorBaseComponent
{
    /// <summary>
    /// Handles initialization from the javascript layer
    /// </summary>
    /// <param name="firstRender"></param>
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
            Console.WriteLine("Could not load theme mode information.");
        }

        await base.OnAfterRenderAsync(firstRender);
    }

    /// <summary>
    /// Handles when the dark/light mode changes
    /// </summary>
    /// <param name="newValue"></param>
    public async void OnHandleChange(bool newValue)
    {
        IsDarkModeEnabled = newValue;

        await IsDarkModeEnabledChanged.InvokeAsync(newValue);

        await JsRuntime.InvokeVoidAsync("setDarkMode", IsDarkModeEnabled);
        StateHasChanged();
    }

    /// <summary>
    /// Gets or Sets the mode
    /// </summary>
    [Parameter]
    public bool IsDarkModeEnabled { get; set; } = true;

    /// <summary>
    /// Gets or Sets the callback for when the mode changes
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsDarkModeEnabledChanged { get; set; }

    /// <summary>
    /// Gets or Sets the javascript runtime service
    /// </summary>
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = null!;
}
