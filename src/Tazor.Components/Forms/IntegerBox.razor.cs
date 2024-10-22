using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Forms;

public partial class IntegerBox : TazorBaseComponent
{
    private async Task OnChanged(ChangeEventArgs args)
    {
        var val = 0;
        if (args != null && args.Value != null)
        {
            if (!int.TryParse(args.Value.ToString(), out val))
            {
                val = 0;
            }
        }

        await ValueChanged.InvokeAsync(val);
    }

    [Parameter]
    public int Value { get; set; }

    [Parameter]
    public EventCallback<int> ValueChanged { get; set; }
}
