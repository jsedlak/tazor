using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

/// <summary>
/// Renders a textbox that can handle numbers
/// </summary>
public partial class IntegerBox : TazorBaseComponent
{
    private async Task OnChanged(ChangeEventArgs args)
    {
        var val = 0;
        if (args.Value != null)
        {
            if (!int.TryParse(args.Value.ToString(), out val))
            {
                val = 0;
            }
        }

        await ValueChanged.InvokeAsync(val);
    }

    /// <summary>
    /// Gets or Sets the valud
    /// </summary>
    [Parameter]
    public int Value { get; set; }

    /// <summary>
    /// Gets or Sets the callback for handling when the value has changed
    /// </summary>
    [Parameter]
    public EventCallback<int> ValueChanged { get; set; }
}
