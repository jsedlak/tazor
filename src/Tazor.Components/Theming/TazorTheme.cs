namespace Tazor.Components.Theming;

/// <summary>
/// Provides the basic theme for the application
/// </summary>
public class TazorTheme : ITheme
{
    /// <summary>
    /// Gets or Sets the name of the theme
    /// </summary>
    public string Name { get; set; } = "Unset Theme Name";

    /// <inheritdoc />
    public IEnumerable<string> CssFiles { get; set; } = [];

    /// <summary>
    /// Gets or Sets the app components theme
    /// </summary>
    public AppTheme App { get; set; } = new();

    /// <summary>
    /// Gets or Sets the data theme
    /// </summary>
    public DataTheme Data { get; set; } = new();

    /// <summary>
    /// Gets or Sets the table theme
    /// </summary>
    public DataGridTheme DataGrid { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for forms
    /// </summary>
    public FormsTheme Forms { get; set; } = new();

    /// <summary>
    /// Gets or Sets the dialog theme
    /// </summary>
    public DialogTheme Dialog { get; set; } = new();

    /// <summary>
    /// Gets or Sets the content theme
    /// </summary>
    public ContentTheme Content { get; set; } = new();

    /// <summary>
    /// Gets or Sets the pager theme
    /// </summary>
    public PagerTheme Pager { get; set; } = new();

    /// <summary>
    /// Gets or Sets the tab nav theme
    /// </summary>
    public TabNavTheme TabNav { get; set; } = new();

    /// <summary>
    /// Gets or Sets the flyout theme
    /// </summary>
    public FlyoutTheme Flyout { get; set; } = new();

    /// <summary>
    /// Gets or Sets the switch theme
    /// </summary>
    public SwitchTheme Switch { get; set; } = new();

    /// <summary>
    /// Gets or Sets the button theme
    /// </summary>
    public ButtonTheme Button { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for the utility components
    /// </summary>
    public UtilityTheme Utility { get; set; } = new();

    /// <summary>
    /// Gets or Sets the navigation theme
    /// </summary>
    public NavigationTheme Navigation { get; set; } = new();

    /// <summary>
    /// Gets or Sets the layout theme
    /// </summary>
    public LayoutTheme Layout { get; set; } = new();

    /// <summary>
    /// Gets or Sets whether the theme is the default theme
    /// </summary>
    public bool IsDefault { get; set; }
}
