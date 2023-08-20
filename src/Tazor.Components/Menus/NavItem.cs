using Microsoft.AspNetCore.Components;
using Tazor.Extensions;

namespace Tazor.Components.Menus;

public class NavItem
{
    public NavItem()
    {

    }

    public NavItem(string text)
    {
        Text = text;
        Key = text.ToSlug();
    }

    public NavItem(string key, string text)
    {
        Key = key;
        Text = text;
    }

    public string? Key { get; set; }

    public string? Href { get; set; }

    public string? Target { get; set; }

    public MarkupString? LeftIcon { get; set; }

    public MarkupString? RightIcon { get; set; }

    public string Text { get; set; } = null!;
}