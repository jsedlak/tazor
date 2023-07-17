using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Menus;

public class NavItem
{
    public string? Key { get; set; }

    public string? Href { get; set; }

    public string? Target { get; set; }

    public MarkupString? LeftIcon { get; set; }

    public MarkupString? RightIcon { get; set; }

    public string Text { get; set; } = null!;
}