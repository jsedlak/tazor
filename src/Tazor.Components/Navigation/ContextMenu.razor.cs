using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

public partial class ContextMenu : TazorBaseComponent
{
    private async Task OnClickedOutside()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(IsVisible);
        StateHasChanged();
    }

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    [Parameter]
    public int Left { get; set; }

    [Parameter]
    public int Top { get; set; }

    
}
