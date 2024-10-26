namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for data components
/// </summary>
public class DataTheme
{
    /// <summary>
    /// Gets or Sets theming for the tree view component
    /// </summary>
    public TreeViewTheme TreeView { get; set; } = new();

    /// <summary>
    /// Gets or Sets theming for the list view component
    /// </summary>
    public ListViewTheme ListView { get; set; } = new();

    /// <summary>
    /// Gets or Sets the data grid theme
    /// </summary>
    public TemplatedGridTheme DataGrid { get; set; } = new();
}
