using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Provides an inline alert component
/// </summary>
public partial class Alert : TazorBaseComponent
{
    private string _cssClass = "";

    /// <summary>
    /// Initializes the component
    /// </summary>
    private string GetCssClass()
    {
        if (Type == AlertType.Custom)
        {
            return Class ?? "";
        }
        else
        {
            return $"alert-{Type.ToString().ToLower()}";
        }
    }

    /// <summary>
    /// Gets or Sets the title of the alert
    /// </summary>
    [Parameter]
    public string? Title { get; set; } = null;

    /// <summary>
    /// Gets or Sets the icon rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Icon { get; set; } = null;

    /// <summary>
    /// Gets or Sets the content rendering
    /// </summary>
    [Parameter]
    public RenderFragment? Content { get; set; } = null;

    /// <summary>
    /// Gets or Sets the link content
    /// </summary>
    [Parameter]
    public RenderFragment? LinkContent { get; set; } = null;

    /// <summary>
    /// Gets or Sets the alert type
    /// </summary>
    [Parameter]
    public AlertType Type { get; set; } = AlertType.Info;

    /// <summary>
    /// Gets or Sets custom CSS class data
    /// </summary>
    [Parameter]
    public string? Class { get; set; }
}
