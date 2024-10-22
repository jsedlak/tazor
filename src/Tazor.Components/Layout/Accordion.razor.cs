using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

public partial class Accordion : TazorBaseComponent
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public bool MultiOpen { get; set; } = false;

    [Parameter]
    public AccordionFold? SelectedFold { get; set; } = null;

    [Parameter]
    public EventCallback<AccordionFold> SelectedFoldChanged { get; set; }

    public async Task SelectFold(AccordionFold? fold)
    {
        if (fold is not null && SelectedFold == fold)
        {
            if (SelectedFold.IsUnfolded)
            {
                await SelectedFold.FoldAsync();
            }
            else
            {
                await SelectedFold.UnfoldAsync();
            }
        }
        else
        {
            // if the current fold is not null, fold it
            if (SelectedFold != null)
            {
                await SelectedFold.FoldAsync();
            }

            // if the new fold is not null, unfold it
            if (fold != null)
            {
                await fold.UnfoldAsync();
            }
        }

        // set the fold
        SelectedFold = fold;
        await SelectedFoldChanged.InvokeAsync(SelectedFold);
    }
}
