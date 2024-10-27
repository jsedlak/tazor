using System.Text.Json;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides a method for interacting with a dialog through a common pattern
/// </summary>
/// <typeparam name="TModel"></typeparam>
public class DialogContext<TModel>
    where TModel : class, new()
{
    private readonly Action _stateChanged;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="stateChanged"></param>
    public DialogContext(Action stateChanged)
    {
        _stateChanged = stateChanged;
    }
    
    /// <summary>
    /// Opens the dialog, providing an optional model for editing
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public Task Open(TModel? model = null)
    {
        IsVisible = true;

        if (model is not null)
        {
            TentativeModel = JsonSerializer.Deserialize<TModel>(
                JsonSerializer.Serialize(model)
            ) ?? new();
        }

        _stateChanged();
        
        return Task.CompletedTask;
    }

    /// <summary>
    /// Cancels the dialog
    /// </summary>
    /// <returns></returns>
    public Task Cancel()
    {
        IsVisible = false;
        
        _stateChanged();
        
        return Task.CompletedTask;
    }

    /// <summary>
    /// Confirms any changes made in the dialog
    /// </summary>
    /// <param name="handler"></param>
    public async Task Confirm(Func<TModel?, Task<(bool, IEnumerable<string>)>> handler)
    {
        IsWaiting = true;
        _stateChanged();
        
        Messages = [];
        
        var result = await handler(TentativeModel);

        if (!result.Item1)
        {
            Messages = result.Item2;
        }
        else
        {
            IsVisible = false;
        }

        IsWaiting = false;
        _stateChanged();
    }
    
    /// <summary>
    /// Gets or Sets the model being edited within the dialog
    /// </summary>
    public TModel TentativeModel { get; set; } = new();

    /// <summary>
    /// Gets or Sets any error messages to display as part of confirmation process
    /// </summary>
    public IEnumerable<string> Messages { get; set; } = [];

    /// <summary>
    /// Gets or Sets whether the dialog is visible
    /// </summary>
    public bool IsVisible { get; set; } = false;

    /// <summary>
    /// Gets or Sets whether the dialog confirmation is processing
    /// </summary>
    public bool IsWaiting { get; set; } = false;
}