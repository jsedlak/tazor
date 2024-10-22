﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Tazor.Components.Forms;

[CascadingTypeParameter(nameof(TItem))]
public partial class ComboBox<TItem> : TazorBaseComponent
{
    private IEnumerable<TItem> _items = Enumerable.Empty<TItem>();

    private bool _isDropdownVisible = false;
    private bool _isEditorVisible = true;
    private ElementReference? _textboxReference;

    private int? _currentIndex = null;

    private async Task OnInputChanged(ChangeEventArgs args)
    {
        SearchText = args.Value?.ToString() ?? "";
        await SearchTextChanged.InvokeAsync(SearchText);

        if (OnSearch != null)
        {
            _items = await OnSearch(SearchText);
            _currentIndex = _items.Any() ? 0 : null;
        }

        if (_items.Any())
        {
            _isDropdownVisible = true;
        }
        else
        {
            _isDropdownVisible = false;
        }

        StateHasChanged();
    }

    private async Task OnCheckChange(TItem item)
    {
        if (SelectedItems.Contains(item))
        {
            SelectedItems = SelectedItems.Except([item]);
        }
        else
        {
            SelectedItems = [.. SelectedItems, item];
        }

        await SelectedItemsChanged.InvokeAsync(SelectedItems);

        StateHasChanged();
    }

    private async Task OnKeyDown(KeyboardEventArgs args)
    {
        if (args.Key == KeyCodes.Escape)
        {
            _currentIndex = null;
            _isDropdownVisible = false;
        }
        else if (args.Key == KeyCodes.ArrowDown && _items.Any())
        {
            _currentIndex = _currentIndex.GetValueOrDefault(-1) + 1;
            if (_currentIndex > _items.Count() - 1)
            {
                _currentIndex = 0;
            }
        }
        else if (args.Key == KeyCodes.ArrowUp && _items.Any())
        {
            _currentIndex = _currentIndex.GetValueOrDefault(0) - 1;
            if (_currentIndex < 0)
            {
                _currentIndex = _items.Count() - 1;
            }
        }
        else if (args.Key == KeyCodes.Enter && _currentIndex != null)
        {
            var item = _items.ElementAt(_currentIndex.Value);

            if (item != null)
            {
                await OnCheckChange(item);
            }
        }

        //StateHasChanged();
    }

    private void HandleClickedOutside()
    {
        Console.WriteLine("HandleClickedOutside");
        _isEditorVisible = !SelectedItems.Any();
        _isDropdownVisible = false;
        StateHasChanged();
    }

    private async Task HandleDropDownClicked()
    {
        Console.WriteLine("DropDownButton->Click");

        if (OnSearch != null)
        {
            _items = await OnSearch(SearchText);
            _currentIndex = _items.Any() ? 0 : null;
        }

        _isDropdownVisible = !_isDropdownVisible && _items.Any();
        StateHasChanged();
    }

    [Parameter]
    public bool MultiSelect { get; set; } = false;

    [Parameter]
    public RenderFragment<TItem>? ResultTemplate { get; set; }

    [Parameter]
    public RenderFragment<TItem>? ViewTemplate { get; set; }

    [Parameter]
    public string SearchText { get; set; } = string.Empty;

    [Parameter]
    public EventCallback<string> SearchTextChanged { get; set; }

    [Parameter]
    public Func<string, Task<IEnumerable<TItem>>>? OnSearch { get; set; }

    [Parameter]
    public IEnumerable<TItem> SelectedItems { get; set; } = Enumerable.Empty<TItem>();

    [Parameter]
    public EventCallback<IEnumerable<TItem>> SelectedItemsChanged { get; set; }
}