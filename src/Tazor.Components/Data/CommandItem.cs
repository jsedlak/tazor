using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public class CommandItem
{
    public string Title { get; set; } = null!;

    public string Key { get; set; } = null!;

    public MarkupString Icon { get; set; }
}
