using Microsoft.AspNetCore.Components;
using Tazor.Extensions;

namespace Tazor.Components.Navigation;

/// <summary>
/// Describes an item that can be rendered as a navigational item
/// </summary>
public class NavItem
{
    /// <summary>
    /// Default Constructor
    /// </summary>
    public NavItem()
    {

    }

    /// <summary>
    /// Text Constructor
    /// </summary>
    /// <param name="text"></param>
    public NavItem(string text)
    {
        Text = text;
        Key = text.ToSlug();
    }

    /// <summary>
    /// Full Constructor
    /// </summary>
    /// <param name="key"></param>
    /// <param name="text"></param>
    public NavItem(string key, string text)
    {
        Key = key;
        Text = text;
    }

    /// <summary>
    /// Gets or Sets the key to identify the item
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// Gets or Sets the href for the item if it should act as a link
    /// </summary>
    public string? Href { get; set; }

    /// <summary>
    /// Gets or Sets the browser target
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// Gets or Sets the left icon
    /// </summary>
    public MarkupString? LeftIcon { get; set; }

    /// <summary>
    /// Gets or Sets the right icon
    /// </summary>
    public MarkupString? RightIcon { get; set; }

    /// <summary>
    /// Gets or Sets the text to display
    /// </summary>
    public string Text { get; set; } = null!;
}