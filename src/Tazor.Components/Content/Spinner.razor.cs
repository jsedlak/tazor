using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

public partial class Spinner : TazorBaseComponent
{
    [Parameter]
    public string? Text { get; set; } = null;

    [Parameter]
    public MarkupString? Icon { get; set; } = null;
}
