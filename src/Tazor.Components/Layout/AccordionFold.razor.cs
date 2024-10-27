using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Layout;

/// <summary>
/// Renders a single fold as part of an accordion or alone
/// </summary>
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

    /// <summary>
    /// Unfolds this fold
    /// </summary>
    public async Task UnfoldAsync()
    {
        IsUnfolded = true;
        await IsUnfoldedChanged.InvokeAsync(IsUnfolded);

        StateHasChanged();
    }

    /// <summary>
    /// Collapses this fold
    /// </summary>
    public async Task FoldAsync()
    {
        IsUnfolded = false;
        await IsUnfoldedChanged.InvokeAsync(IsUnfolded);

        StateHasChanged();
    }

    /// <summary>
    /// Gets or Sets the header rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Header { get; set; }

    /// <summary>
    /// Gets or Sets the content rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Content { get; set; }

    /// <summary>
    /// Gets or Sets the icon rendering
    /// </summary>
    [Parameter]
    public RenderFragment? IconTemplate { get; set; }

    /// <summary>
    /// Gets or Sets the unfolded icon rendering
    /// </summary>
    [Parameter]
    public RenderFragment? UnfoldedIconTemplate { get; set; }

    /// <summary>
    /// Gets or Sets where the icon should be placed
    /// </summary>
    [Parameter]
    public IconPlacement IconPlacement { get; set; } = IconPlacement.Start;

    /// <summary>
    /// Gets or Sets whether the fold is expanded or collapsed
    /// </summary>
    [Parameter]
    public bool IsUnfolded { get; set; } = false;

    /// <summary>
    /// Gets or Sets the callback for handling when the status changes
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsUnfoldedChanged { get; set; }

    /// <summary>
    /// A cascaded parameter of the parent accordion
    /// </summary>
    [CascadingParameter(Name = "Accordion")]
    public Accordion? Accordion { get; set; }
}
