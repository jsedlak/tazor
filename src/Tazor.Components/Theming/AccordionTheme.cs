namespace Tazor.Components.Theming;

/// <summary>
/// Provides a theme for the Accordion component.
/// </summary>
public class AccordionTheme
{
    /// <summary>
    /// Gets or Sets the CSS Class for the container of the Accordion.
    /// </summary>
    public string Container { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's container
    /// </summary>
    public string FoldContainer { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's container when it is selected
    /// </summary>
    public string FoldContainerSelected { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's header
    /// </summary>
    public string FoldHeader { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's header when it is selected
    /// </summary>
    public string FoldHeaderSelected { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's content
    /// </summary>
    public string FoldContent { get; set; } = "";

    /// <summary>
    /// Gets or Sets the CSS Class for the fold's content
    /// </summary>
    public string FoldContentUnfolded { get; set; } = "";
}