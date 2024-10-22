using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

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

    [Parameter]
    public bool IsChecked { get; set; }

    [Parameter]
    public EventCallback<bool> IsCheckedChanged { get; set; }
}
