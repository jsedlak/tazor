using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Content;

/// <summary>
/// Renders a Button component
/// </summary>
public partial class Button : TazorBaseComponent
{
    private async Task HandleClick()
    {
        if (Disabled)
        {
            return;
        }

        if (!string.IsNullOrWhiteSpace(Href))
        {
            Navigation.NavigateTo(Href);
        }
        else
        {
            await Clicked.InvokeAsync();
        }
    }

    private string GetWidthClass()
    {
        return Block ? "button-block" : "";
    }

    private string GetColorClass()
    {
        var classNames = new List<string>();

        if (Disabled)
        {
            classNames.Add("button-disabled");
        }

        var type = Type.ToString().ToLower().Replace("outline", "-outline");
        classNames.Add($"button-{type}");

        return string.Join(" ", classNames);
    }

    /// <summary>
    /// Gets or Sets the type of button to display
    /// </summary>
    [Parameter]
    public ButtonType Type { get; set; } = ButtonType.Default;

    /// <summary>
    /// Gets or Sets the title of the button, setting the title attribute
    /// </summary>
    [Parameter]
    public string? Title { get; set; } = null;

    /// <summary>
    /// Gets or Sets the href if the button should link to a page
    /// </summary>
    [Parameter]
    public string? Href { get; set; } = null;

    /// <summary>
    /// Gets or Sets the handler for when the button is clicked
    /// </summary>
    [Parameter]
    public EventCallback Clicked { get; set; }

    /// <summary>
    /// Gets or Sets the icon rendering to display in the button 
    /// </summary>
    [Parameter]
    public RenderFragment? Icon { get; set; } = null;

    /// <summary>
    /// Gets or Sets the child content to render
    /// </summary>
    [Parameter]
    public RenderFragment ChildContent { get; set; } = null!;

    /// <summary>
    /// Gets or Sets whether the button should fill available space
    /// </summary>
    [Parameter]
    public bool Block { get; set; } = false;

    /// <summary>
    /// Gets or Sets whether the button may be interacted with
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Gets or Sets the navigation manager service
    /// </summary>
    [Inject]
    protected NavigationManager Navigation { get; set; }
}
