using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a large scale page level flyout panel
/// </summary>
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

        windowClass += Placement switch
        {
            PanelPlacement.Left or PanelPlacement.Right => $" {Theme.Flyout.WindowVertical}",
            PanelPlacement.Top or PanelPlacement.Bottom => $" {Theme.Flyout.WindowHorizontal}",
            _ => $" {Theme.Flyout.WindowVertical}"
        };

        return windowClass;
    }

    private string GetPlacementClass()
    {
        return Placement switch
        {
            PanelPlacement.Left => Theme.Flyout.PlacementLeft,
            PanelPlacement.Right => Theme.Flyout.PlacementRight,
            PanelPlacement.Top => Theme.Flyout.PlacementTop,
            PanelPlacement.Bottom => Theme.Flyout.PlacementBottom,
            _ => Theme.Flyout.PlacementLeft
        };
    }

    /// <summary>
    /// Gets or Sets whether the flyout is visible
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; } = false;

    /// <summary>
    /// Gets or Sets the handler for when the visibility changes
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    /// <summary>
    /// Gets or Sets the title of the flyout
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets the header rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Header { get; set; }

    /// <summary>
    /// Gets or Sets the content rendering
    /// </summary>
    [Parameter]
    public RenderFragment Content { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the footer rendering
    /// </summary>
    [Parameter]
    public RenderFragment Footer { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the panel placement
    /// </summary>
    [Parameter]
    public PanelPlacement Placement { get; set; }

    /// <summary>
    /// Gets or Sets whether the close button should be displayed or hidden
    /// </summary>
    [Parameter]
    public bool HideCloseButton { get; set; } = false;
}
