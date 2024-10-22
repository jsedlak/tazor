using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Flyout : TazorBaseComponent
{
    private async Task OnCloseRequested()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(false);
    }

    private string GetWindowClass()
    {
        var windowClass = Theme.Flyout.Window;

        switch (Placement)
        {
            case PanelPlacement.Left:
            case PanelPlacement.Right:
                windowClass += $" {Theme.Flyout.WindowVertical}";
                break;
            case PanelPlacement.Top:
            case PanelPlacement.Bottom:
                windowClass += $" {Theme.Flyout.WindowHorizontal}";
                break;
        }

        return windowClass;
    }

    private string GetPlacementClass()
    {
        switch (Placement)
        {
            case PanelPlacement.Left:
                return Theme.Flyout.PlacementLeft;
            case PanelPlacement.Right:
                return Theme.Flyout.PlacementRight;
            case PanelPlacement.Top:
                return Theme.Flyout.PlacementTop;
            case PanelPlacement.Bottom:
                return Theme.Flyout.PlacementBottom;
        }

        return Theme.Flyout.PlacementLeft;
    }

    [Parameter]
    public bool IsVisible { get; set; } = false;

    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public RenderFragment? Header { get; set; }

    [Parameter]
    public RenderFragment Content { get; set; } = null!;

    [Parameter]
    public RenderFragment Footer { get; set; } = null!;

    [Parameter]
    public PanelPlacement Placement { get; set; }

    [Parameter]
    public bool HideCloseButton { get; set; } = false;
}
