using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Navigation;

/// <summary>
/// Provides a tabbed navigation experience
/// </summary>
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

    /// <summary>
    /// Initializes the component
    /// </summary>
    protected override async Task OnInitializedAsync()
    {
        if (Items.Any())
        {
            await HandleTabClicked(Items.First());
        }
    }

    /// <summary>
    /// Gets or Sets the navigational items representing the tabs
    /// </summary>
    [Parameter]
    public IEnumerable<NavItem> Items { get; set; } = Enumerable.Empty<NavItem>();

    /// <summary>
    /// Gets or Sets the selected nav item
    /// </summary>
    [Parameter]
    public NavItem? SelectedItem { get; set; }

    /// <summary>
    /// Gets or Sets the callback for handling when the selected nav item changes
    /// </summary>
    [Parameter]
    public EventCallback<NavItem> SelectedItemChanged { get; set; }
}
