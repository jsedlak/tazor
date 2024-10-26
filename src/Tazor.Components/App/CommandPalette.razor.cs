using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Tazor.Components.Layout;

namespace Tazor.Components.App;

/// <summary>
/// Represents an mechanism for interacting with a pre-determined list of commands from the UI
/// </summary>
public partial class CommandPalette : TazorBaseComponent
{
    private int? _currentCommandIndex = null;
    private CommandDescription[] _visibleCommands = new CommandDescription[] { };

    private ElementReference? _textboxReference;

    private async Task OnInputChanged(ChangeEventArgs args)
    {
        Input = args.Value?.ToString() ?? "";
        await InputChanged.InvokeAsync(Input);

        _visibleCommands = Commands.Where(m => m.CanExecute(Input)).ToArray();
        _currentCommandIndex = null;

        StateHasChanged();
    }

    private async Task OnKeyDown(KeyboardEventArgs args)
    {
        if (args.Key == KeyCodes.Escape)
        {
            _visibleCommands = new CommandDescription[] { };
            _currentCommandIndex = null;
            IsVisible = false;
            await IsVisibleChanged.InvokeAsync(false);
        }
        else if (args.Key == KeyCodes.ArrowDown && _visibleCommands.Any())
        {
            _currentCommandIndex = _currentCommandIndex.GetValueOrDefault(-1) + 1;
            if (_currentCommandIndex > _visibleCommands.Length - 1)
            {
                _currentCommandIndex = 0;
            }
        }
        else if (args.Key == KeyCodes.ArrowUp && _visibleCommands.Any())
        {
            _currentCommandIndex = _currentCommandIndex.GetValueOrDefault(0) - 1;
            if (_currentCommandIndex < 0)
            {
                _currentCommandIndex = _visibleCommands.Length - 1;
            }
        }
        else if (args.Key == KeyCodes.Enter && _currentCommandIndex != null)
        {
            await ExecuteAsync(_visibleCommands[_currentCommandIndex.Value]);
        }

        //StateHasChanged();
    }

    private async Task ExecuteAsync(CommandDescription command)
    {
        await command.ExecuteAsync(Input);

        _visibleCommands = new CommandDescription[] { };
        _currentCommandIndex = null;
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(false);

        Input = string.Empty;

        StateHasChanged();
    }

    private async Task HandleClickOutside()
    {
        IsVisible = false;
        await IsVisibleChanged.InvokeAsync(false);

        StateHasChanged();
    }

    /// <inheritdoc />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (_textboxReference != null && IsVisible)
        {
            await _textboxReference.Value.FocusAsync();
        }
    }

    /// <summary>
    /// Gets or Sets the list of commands
    /// </summary>
    [Parameter]
    public IEnumerable<CommandDescription> Commands { get; set; } = Enumerable.Empty<CommandDescription>();

    /// <summary>
    /// Gets or Sets the current input data
    /// </summary>
    [Parameter]
    public string Input { get; set; } = "";

    /// <summary>
    /// Gets or Sets the callback for handling changes to input data
    /// </summary>
    [Parameter]
    public EventCallback<string> InputChanged { get; set; }

    /// <summary>
    /// Gets or Sets whether the command palette is visible
    /// </summary>
    [Parameter]
    public bool IsVisible { get; set; }

    /// <summary>
    /// Gets or Sets the callback for handling changes to visibility
    /// </summary>
    [Parameter]
    public EventCallback<bool> IsVisibleChanged { get; set; }
}
