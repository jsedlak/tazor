using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class PopoverContainer : TazorBaseComponent
{
    private void OnHandleClickedOutside()
    {
        // IsOpen = false;
        // await IsOpenChanged.InvokeAsync(IsOpen);
        PopoverStatusChanged?.Invoke(this, false);
    }

    private void OnMouseOver()
    {
        if (AllowHover)
        {
            PopoverStatusChanged?.Invoke(this, true);
        }
    }

    private void OnMouseOut()
    {
        if (AllowHover)
        {
            PopoverStatusChanged?.Invoke(this, false);
        }
    }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool AllowHover { get; set; }

    [Parameter]
    public EventHandler<bool>? PopoverStatusChanged { get; set; }
}
