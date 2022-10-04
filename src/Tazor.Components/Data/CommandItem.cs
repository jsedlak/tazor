using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public class CommandItem
{
    public string Title { get; set; } = null!;

    public string Key { get; set; } = null!;

    public RenderFragment? Icon { get; set; }

    public string Color { get; set; }
}
