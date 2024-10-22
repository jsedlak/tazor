namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the entire application
/// </summary>
public interface ITheme
{
    /// <summary>
    /// Gets or Sets the name of the theme
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or Sets the css files to be included as part of the theme
    /// </summary>
    IEnumerable<string> CssFiles { get; set; }

    /// <summary>
    /// Gets or Sets the app component theme
    /// </summary>
    AppTheme App { get; set; }

    /// <summary>
    /// Gets or Sets the data components theming section
    /// </summary>
    DataTheme Data { get; set; }

    /// <summary>
    /// Gets or Sets the table theme
    /// </summary>
    DataGridTheme DataGrid { get; set; }

    /// <summary>
    /// Gets or Sets whether or not the theme should be the default
    /// </summary>
    bool IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets the form theme
    /// </summary>
    FormsTheme Forms { get; set; }

    /// <summary>
    /// Gets or Sets the dialog theme
    /// </summary>
    DialogTheme Dialog { get; set; }

    /// <summary>
    /// Gets or Sets the content theme
    /// </summary>
    ContentTheme Content { get; set; }

    /// <summary>
    /// Gets or Sets the pager theme
    /// </summary>
    PagerTheme Pager { get; set; }

    /// <summary>
    /// Gets or Sets the tabnav theme
    /// </summary>
    TabNavTheme TabNav { get; set; }

    /// <summary>
    /// Gets or Sets the flyout theme
    /// </summary>
    FlyoutTheme Flyout { get; set; }

    /// <summary>
    /// Gets or Sets the switch theme
    /// </summary>
    SwitchTheme Switch { get; set; }

    /// <summary>
    /// Gets or Sets the button theme
    /// </summary>
    ButtonTheme Button { get; set; } 

    /// <summary>
    /// Gets or Sets the utility theme
    /// </summary>
    UtilityTheme Utility { get; set; }

    /// <summary>
    /// Gets or Sets the navigation theme
    /// </summary>
    NavigationTheme Navigation { get; set; }

    /// <summary>
    /// Gets or Sets the layout theme
    /// </summary>
    LayoutTheme Layout { get; set; }
}
