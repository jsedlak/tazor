using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

/// <summary>
/// Renders a group of components that can be expanded or collapsed
/// </summary>
public partial class Accordion : TazorBaseComponent
{
    /// <summary>
    /// Selects one of the accordion folds
    /// </summary>
    /// <param name="fold"></param>
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
    
    /// <summary>
    /// Gets or Sets all child components
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or Sets whether to allow multiple folds to open at once
    /// </summary>
    [Parameter]
    public bool MultiOpen { get; set; } = false;

    /// <summary>
    /// Gets or Sets the currently selected fold (in singular open)
    /// </summary>
    [Parameter]
    public AccordionFold? SelectedFold { get; set; } = null;

    /// <summary>
    /// Gets or Sets the callback for handling when the fold selection has changed (in singular open)
    /// </summary>
    [Parameter]
    public EventCallback<AccordionFold> SelectedFoldChanged { get; set; }
}
