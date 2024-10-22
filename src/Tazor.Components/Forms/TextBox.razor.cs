using Microsoft.AspNetCore.Components;
using System.Globalization;
using System.Reflection;

namespace Tazor.Components.Forms;

[CascadingTypeParameter(nameof(TModel))]
public partial class TextBox<TModel> : TazorBaseComponent
{
    private async Task OnChanged(ChangeEventArgs args)
    {
        if (args == null || args.Value == null)
        {
            await ValueChanged.InvokeAsync(default(TModel));
            return;
        }

        var newValue = default(TModel?);

        // is there a direct compare
        if (args?.Value is TModel model)
        {
            newValue = model;
            await ValueChanged.InvokeAsync(newValue);
            return;
        }

        // let's try to parse
        var parseMethod = typeof(TModel).GetMethods().FirstOrDefault(m => m.Name.Equals("Parse", StringComparison.OrdinalIgnoreCase));
        if (parseMethod != null)
        {
            try
            {
                var output = (TModel)parseMethod.Invoke(null, BindingFlags.Static, null, [args.Value.ToString()], CultureInfo.InvariantCulture);
                await ValueChanged.InvokeAsync(output);

            }
            catch (Exception parseException)
            {
                Console.WriteLine($"Could not parse the value: {parseException.Message}");
            }
        }
    }

    [Parameter]
    public TModel? Value { get; set; }

    [Parameter]
    public EventCallback<TModel> ValueChanged { get; set; }

    [Parameter]
    public string Type { get; set; } = "text";
}
