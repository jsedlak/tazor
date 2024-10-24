﻿using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public partial class TreeView : TazorBaseComponent
{
    public void Select(params ITreeItem[] items)
    {
        SelectedItems = items;
        SelectedItemsChanged.InvokeAsync(SelectedItems);
        StateHasChanged();
    }

    [Parameter]
    public IEnumerable<ITreeItem> Items { get; set; } = Enumerable.Empty<ITreeItem>();

    [Parameter]
    public Func<ITreeItem, Task<IEnumerable<ITreeItem>>>? RequestTree { get; set; }

    [Parameter]
    public IEnumerable<ITreeItem> SelectedItems { get; set; } = Enumerable.Empty<ITreeItem>();

    [Parameter]
    public EventCallback<IEnumerable<ITreeItem>> SelectedItemsChanged { get; set; }
}
