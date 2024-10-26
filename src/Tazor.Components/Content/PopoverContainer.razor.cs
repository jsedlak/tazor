using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a mouse boundary for a popover, as well as relative positioning
/// </summary>
public partial class PopoverContainer : TazorBaseComponent
{
    /// <summary>
    /// Notifies of status changes for any popover components
    /// </summary>
    public EventHandler<bool>? PopoverStatusChanged;
    
    /// <summary>
    /// Closes the popover when the user has clicked outside the container
    /// </summary>
    private void OnHandleClickedOutside()
    {
        PopoverStatusChanged?.Invoke(this, false);
    }

    /// <summary>
    /// Handles when the mouse has moved over the container
    /// </summary>
    private void OnMouseOver()
    {
        if (AllowHover)
        {
            PopoverStatusChanged?.Invoke(this, true);
        }
    }

    /// <summary>
    /// Handles when the mouse has moved out of the container
    /// </summary>
    private void OnMouseOut()
    {
        if (AllowHover)
        {
            PopoverStatusChanged?.Invoke(this, false);
        }
    }

    /// <summary>
    /// Child components to be rendered, including the popover itself
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or Sets whether the popover should activate on hover
    /// </summary>
    [Parameter]
    public bool AllowHover { get; set; }
}
