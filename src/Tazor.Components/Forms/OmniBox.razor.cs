using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Tazor.Components.Forms;

/// <summary>
/// Renders a catch-all dropdown component
/// </summary>
/// <typeparam name="TItem"></typeparam>
[CascadingTypeParameter(nameof(TItem))]
public partial class OmniBox<TItem> : TazorBaseComponent, IDisposable
    where TItem : class
{
    // store the search results
    private TItem[] _searchResults = [];

    // store the currently highlighted result
    private int? _currentResultIndex = null;

    // whether or not we trap the key down (up & down arrow)
    private bool _shouldPreventOnKeyDown;

    // display flags
    private bool _shouldShowTextBox = false;
    private bool _shouldShowResults = false;

    // for focusing
    private ElementReference? _textboxReference;

    // stupid timer for focusing
    private Timer? _timer;

    private async Task SelectItemAsync(TItem item)
    {
        SelectedItem = item;

        _shouldShowResults = false;
        _shouldShowTextBox = false;

        await SelectedItemChanged.InvokeAsync(SelectedItem);

        StateHasChanged();
    }

    private async Task OnInputChanged(ChangeEventArgs args)
    {
        // set the input
        Input = args.Value?.ToString() ?? "";
        await InputChanged.InvokeAsync(Input);

        // search
        _searchResults = (await OnSearch(Input)).ToArray();
        _currentResultIndex = null;

        // show the search results
        _shouldShowResults = true;

        StateHasChanged();
    }

    private async Task OnKeyDown(KeyboardEventArgs args)
    {
        _shouldPreventOnKeyDown = false;
        if (args.Key == KeyCodes.Escape)
        {
            // reset search index
            _currentResultIndex = null;

            // hide the boxes
            _shouldShowTextBox = false;
            _shouldShowResults = false;
        }
        else if (args.Key == KeyCodes.ArrowDown && _searchResults.Any())
        {
            _shouldPreventOnKeyDown = true;

            _currentResultIndex = _currentResultIndex.GetValueOrDefault(-1) + 1;

            if (_currentResultIndex > _searchResults.Length - 1)
            {
                _currentResultIndex = 0;
            }
        }
        else if (args.Key == KeyCodes.ArrowUp && _searchResults.Any())
        {
            _shouldPreventOnKeyDown = true;

            _currentResultIndex = _currentResultIndex.GetValueOrDefault(0) - 1;

            if (_currentResultIndex < 0)
            {
                _currentResultIndex = _searchResults.Length - 1;
            }
        }
        else if (args.Key == KeyCodes.Enter && _currentResultIndex != null)
        {
            _shouldPreventOnKeyDown = true;

            await SelectItemAsync(_searchResults[_currentResultIndex.Value]);
        }

        //StateHasChanged();
    }

    private void OnClickedOutside()
    {
        _currentResultIndex = null;
        _shouldShowResults = false;
        _shouldShowTextBox = false;
        StateHasChanged();
    }

    private async Task OnHandleClickViewer()
    {
        _shouldShowTextBox = true;

        if (_searchResults.Any())
        {
            _shouldShowResults = true;
        }

        StateHasChanged();

        if (_timer != null)
        {
            _timer.Dispose();
            _timer = null;
        }

        _timer = new System.Threading.Timer(async _ =>  // async void
        {
            await InvokeAsync(FocusTextBox);

            _timer.Dispose();
            _timer = null;
        }, null, 0, 16);
    }

    private async Task FocusTextBox()
    {
        await _textboxReference.Value.FocusAsync();
        StateHasChanged();
    }

    /// <summary>
    /// Disposes of the component
    /// </summary>
    public void Dispose()
    {
        Console.WriteLine("Disposing OmniBox");
        if (_timer != null)
        {
            _timer.Dispose();
            _timer = null;
        }
    }

    /// <summary>
    /// Gets or Sets the callback for retrieving items when the search has been engaged
    /// </summary>
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> OnSearch { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the current text input
    /// </summary>
    [Parameter] public string Input { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the callback that handles when the input has changed
    /// </summary>
    [Parameter] public EventCallback<string> InputChanged { get; set; }

    /// <summary>
    /// Gets or Sets the selected item
    /// </summary>
    [Parameter] public TItem? SelectedItem { get; set; }

    /// <summary>
    /// Gets or Sets the callback that handles when the selected item has changed
    /// </summary>
    [Parameter] public EventCallback<TItem?> SelectedItemChanged { get; set; }

    /// <summary>
    /// Gets or Sets the template for rendering items
    /// </summary>
    [Parameter] public RenderFragment<TItem> ItemTemplate { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the template for rendering an unselected value
    /// </summary>
    [Parameter] public RenderFragment? PlaceholderTemplate { get; set; }

    /// <summary>
    /// Gets or Sets the template for rendering a selected item
    /// </summary>
    [Parameter] public RenderFragment<TItem> SelectedItemTemplate { get; set; }
}
