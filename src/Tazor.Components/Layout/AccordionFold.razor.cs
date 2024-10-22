using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

public partial class AccordionFold : TazorBaseComponent
{
    private async Task ToggleFold()
    {
        // if there is no parent, we need to self control
        if (Accordion == null || Accordion.MultiOpen)
        {
            IsUnfolded = !IsUnfolded;
            await IsUnfoldedChanged.InvokeAsync(IsUnfolded);
        }
        // otherwise we'll let the parent figure it out
        else
        {
            await Accordion.SelectFold(this);
        }
    }

    private string GetContentClass()
    {
        return IsUnfolded ? Theme.Layout.Accordion.FoldContentUnfolded : Theme.Layout.Accordion.FoldContent;
    }

    public async Task UnfoldAsync()
    {
        IsUnfolded = true;
        await IsUnfoldedChanged.InvokeAsync(IsUnfolded);

        StateHasChanged();
    }

    public async Task FoldAsync()
    {
        IsUnfolded = false;
        await IsUnfoldedChanged.InvokeAsync(IsUnfolded);

        StateHasChanged();
    }

    [Parameter]
    public RenderFragment? Header { get; set; }

    [Parameter]
    public RenderFragment? Content { get; set; }

    [Parameter]
    public RenderFragment? IconTemplate { get; set; }

    [Parameter]
    public RenderFragment? UnfoldedIconTemplate { get; set; }

    [Parameter]
    public IconPlacement IconPlacement { get; set; } = IconPlacement.Start;

    [Parameter]
    public bool IsUnfolded { get; set; } = false;

    [Parameter]
    public EventCallback<bool> IsUnfoldedChanged { get; set; }

    [CascadingParameter(Name = "Accordion")]
    public Accordion? Accordion { get; set; }
}
