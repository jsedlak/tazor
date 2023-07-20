using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tazor.Components.Menus;

public class ToolbarItem
{
    public string CssClass { get; set; } = string.Empty;

    public MarkupString Icon { get; set; }

    public string Text { get; set; } = string.Empty;

    public Func<ToolbarItem, Task>? OnClick { get; set; }
}
