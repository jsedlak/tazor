using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

/// <summary>
/// Renders a menu, positioned where the mouse is at activation
/// </summary>
public partial class ContextMenu : TazorBaseComponent
{
    private async Task OnClickedOutside()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(IsVisible);
        StateHasChanged();
    }

    /// <summary>
    /// Gets or Sets whether the menu is visible
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; }

    /// <summary>
    /// Gets or Sets the callback 
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }

    /// <summary>
    /// Gets or Sets the left positioning
    /// </summary>
    [Parameter]
    public int Left { get; set; }

    /// <summary>
    /// Gets or Sets the top positioning
    /// </summary>
    [Parameter]
    public int Top { get; set; }

    
}
