using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

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

    [Parameter]
    public int Pages { get; set; }

    [Parameter]
    public int CurrentPage { get; set; }

    [Parameter]
    public EventCallback<int> CurrentPageChanged { get; set; }

    [Parameter]
    public int NumberOfVisiblePages { get; set; } = 5;
}
