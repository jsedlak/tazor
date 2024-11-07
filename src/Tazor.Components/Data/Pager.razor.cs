using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides a paging component 
/// </summary>
public partial class Pager : TazorBaseComponent
{
    private string GetPageClass(int pageIndex)
    {
        return pageIndex == CurrentPage ? Theme.Pager.ButtonActive : Theme.Pager.Button;
    }

    private async void ChangePage(int pageIndex)
    {
        CurrentPage = Math.Clamp(pageIndex, 1, Pages);

        await CurrentPageChanged.InvokeAsync(CurrentPage);
    }

    /// <summary>
    /// Gets or Sets the total number of pages
    /// </summary>
    [Parameter]
    public int Pages { get; set; }

    /// <summary>
    /// Gets or Sets the current page
    /// </summary>
    [Parameter]
    public int CurrentPage { get; set; }

    /// <summary>
    /// Gets or Sets the callback handler for when the page has changed
    /// </summary>
    [Parameter]
    public EventCallback<int> CurrentPageChanged { get; set; }

    /// <summary>
    /// Gets or Sets the maximum number of pages to display
    /// </summary>
    [Parameter]
    public int NumberOfVisiblePages { get; set; } = 5;
}
