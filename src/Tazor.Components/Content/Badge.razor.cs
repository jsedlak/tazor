using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Renders a small piece of content as a badge
/// </summary>
public partial class Badge : TazorBaseComponent
{
    private string GetCssClass()
    {
        return Type switch
        {
            BadgeType.Success => Theme.Content.BadgeSuccess,
            BadgeType.Info => Theme.Content.BadgeInfo,
            BadgeType.Warning => Theme.Content.BadgeWarning,
            BadgeType.Error => Theme.Content.BadgeError,
            BadgeType.Custom => CustomClass,
            _ => Theme.Content.BadgeGlobal
        };
    }

    /// <summary>
    /// Gets or Sets the child content to render within the badge
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or Sets the badge type, affecting theming
    /// </summary>
    [Parameter]
    public BadgeType Type { get; set; }

    /// <summary>
    /// Gets or Sets the custom CSS class should BadgeType.Custom be selected
    /// </summary>
    [Parameter]
    public string CustomClass { get; set; } = "";
}
