using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Renders a panel that pops over content
/// </summary>
public partial class Popover : TazorBaseComponent
{
    private async void OnHandleClickedOutside()
    {
        IsOpen = false;
        await IsOpenChanged.InvokeAsync(IsOpen);
    }

    /// <summary>
    /// Initializes the popover component
    /// </summary>
    protected override void OnInitialized()
    {
        if (PopoverContainer != null)
        {
            PopoverContainer.PopoverStatusChanged += async (sender, shouldOpen) =>
            {
                IsOpen = shouldOpen;
                await IsOpenChanged.InvokeAsync(IsOpen);
            };
        }
    }

    /// <summary>
    /// Gets or Sets the parent popover container
    /// </summary>
    [CascadingParameter(Name = "PopoverContainer")]
    public PopoverContainer? PopoverContainer { get; set; }

    /// <summary>
    /// Gets or Sets whether the popover is open
    /// </summary>
    [Parameter]
    public bool IsOpen { get; set; } = true;

    /// <summary>
    /// Gets or Sets the callback for when IsOpen has changed
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsOpenChanged { get; set; }

    /// <summary>
    /// Gets or Sets the title of the popover to display
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets 
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
