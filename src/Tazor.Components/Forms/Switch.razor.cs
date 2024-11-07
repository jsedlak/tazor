using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

/// <summary>
/// Renders a toggle switch component
/// </summary>
public partial class Switch : TazorBaseComponent
{
    private async Task OnSwitchClicked()
    {
        IsChecked = !IsChecked;
        await IsCheckedChanged.InvokeAsync(IsChecked);
        StateHasChanged();
    }

    private string GetTrackClass()
    {
        
        return IsChecked ? Theme.Switch.TrackSelected : Theme.Switch.Track;
    }

    private string GetKnobClass()
    {
        return IsChecked ? Theme.Switch.KnobSelected : Theme.Switch.Knob;
    }

    /// <summary>
    /// Gets or Sets whether the switch is checked
    /// </summary>
    [Parameter]
    public bool IsChecked { get; set; }

    /// <summary>
    /// Gets or Sets the callback for handling when the switch has changed check status
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsCheckedChanged { get; set; }
}
