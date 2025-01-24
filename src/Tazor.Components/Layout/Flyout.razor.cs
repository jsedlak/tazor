using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides a large scale page level flyout panel
/// </summary>
public partial class Flyout : DialogBase
{
    public Flyout(IJSRuntime jsRuntime)
        : base(jsRuntime)
    {

    }

    private string GetWindowClass()
    {
        var windowClass = Theme.Flyout.Window + $" {GetPlacementClass()}";

        windowClass += Placement switch
        {
            PanelPlacement.Left or PanelPlacement.Right => $" {Theme.Flyout.WindowVertical}",
            PanelPlacement.Top or PanelPlacement.Bottom => $" {Theme.Flyout.WindowHorizontal}",
            _ => $" {Theme.Flyout.WindowVertical}"
        };

        return windowClass;
    }

    private string GetWindowInnerClass()
    {
        var windowInnerClass = Theme.Flyout.WindowInner;

        windowInnerClass += Placement switch
        {
            PanelPlacement.Left or PanelPlacement.Right => $" {Theme.Flyout.WindowVertical}",
            PanelPlacement.Top or PanelPlacement.Bottom => $" {Theme.Flyout.WindowHorizontal}",
            _ => $" {Theme.Flyout.WindowVertical}"
        };

        return windowInnerClass;
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
