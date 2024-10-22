using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

public partial class TabNav : TazorBaseComponent
{
    private async Task HandleTabClicked(NavItem item)
    {
        if (SelectedItem == item)
        {
            return;
        }

        SelectedItem = item;
        await SelectedItemChanged.InvokeAsync(item);
    }

    protected override async Task OnInitializedAsync()
    {
        if (Items.Any())
        {
            await HandleTabClicked(Items.First());
        }
    }

    [Parameter]
    public IEnumerable<NavItem> Items { get; set; } = Enumerable.Empty<NavItem>();

    [Parameter]
    public NavItem? SelectedItem { get; set; }

    [Parameter]
    public EventCallback<NavItem> SelectedItemChanged { get; set; }
}
