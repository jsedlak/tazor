using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Popover : TazorBaseComponent
{
    private async void OnHandleClickedOutside()
    {
        IsOpen = false;
        await IsOpenChanged.InvokeAsync(IsOpen);
    }

    protected override void OnInitialized()
    {
        if (PopoverContainer != null)
        {
            Console.WriteLine("Popover Status Changed");
            PopoverContainer.PopoverStatusChanged += async (sender, shouldOpen) =>
            {
                IsOpen = shouldOpen;
                await IsOpenChanged.InvokeAsync(IsOpen);
            };
        }
    }

    [CascadingParameter(Name = "PopoverContainer")]
    public PopoverContainer? PopoverContainer { get; set; }

    [Parameter]
    public bool IsOpen { get; set; } = true;

    [Parameter]
    public EventCallback<bool> IsOpenChanged { get; set; }

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
