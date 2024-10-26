using System.Text.Json;

namespace Tazor.Components.Layout;

public class DialogContext<TModel>
    where TModel : class, new()
{
    private readonly Action _stateChanged;
    
    public DialogContext(Action stateChanged)
    {
        _stateChanged = stateChanged;
    }
    
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

    public Task Cancel()
    {
        IsVisible = false;
        
        _stateChanged();
        
        return Task.CompletedTask;
    }

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
    
    public TModel TentativeModel { get; set; } = new();

    public IEnumerable<string> Messages { get; set; } = [];

    public bool IsVisible { get; set; } = false;

    public bool IsWaiting { get; set; } = false;
}