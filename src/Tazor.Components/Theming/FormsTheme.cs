namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for forms components
/// </summary>
public class FormsTheme
{
    /// <summary>
    /// Gets or Sets CSS classes for the labels
    /// </summary>
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the sublabels
    /// </summary>
    public string SubLabel { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the textboxes
    /// </summary>
    public string TextBox { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets CSS classes for the selects
    /// </summary>
    public string SelectInput { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the theming for the ComboBox component
    /// </summary>
    public ComboBoxTheme ComboBox { get; set; } = new();
}

/// <summary>
/// Provides theming for the ComboBox component
/// </summary>
public class ComboBoxTheme
{
    /// <summary>
    /// Gets or Sets the wrapper CSS classes
    /// </summary>
    public string Wrapper { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the container holding selected items
    /// </summary>
    public string ViewContainer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the list of search results
    /// </summary>
    public string ViewList { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the list item
    /// </summary>
    public string ViewListItem { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the container around the input
    /// </summary>
    public string InputContainer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the input itself
    /// </summary>
    public string Input { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the dropdown button
    /// </summary>
    public string DropdownButton { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS class for the icon inside the button
    /// </summary>
    public string DropdownButtonIcon { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the dropdown container
    /// </summary>
    public string DropdownContainer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the dropdown list
    /// </summary>
    public string DropdownList { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the dropdown item
    /// </summary>
    public string DropdownItem { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the checkbox for selecting items
    /// </summary>
    public string DropdownCheckbox { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the content of the dropdown item
    /// </summary>
    public string DropdownItemContent { get; set; } = string.Empty;
}
