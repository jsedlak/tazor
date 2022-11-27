namespace Tazor.Components.Theming;

public interface ITazorTheme : ITheme {
    IBaseTheme Base { get; set; }

    string ComponentHeader { get; set; }

    string Table { get; set; }

    string TableSpacing { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the header of the table or grid
    string TableHeader { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the footer of a table or grid
    /// </summary>
    string TableFooter { get; set; }

    /// <summary>
    /// Gets or Sets the style for the summary row of the table
    string TableSummary { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the header cell for each column
    /// </summary>
    string TableHeaderCell { get; set; }

    string TableEvenRow { get; set; }

    string TableOddRow { get; set; }

    string TableToolbar { get; set; }

    string TableCell { get; set; }

    /// <summary>
    /// Gets or Sets the class for a panel / section of content
    /// </summary>
    string Panel { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the dialog window
    /// </summary>
    string DialogWindow { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the button
    /// </summary>
    string Button { get; set; }

    /// <summary>
    /// Gets or Sets the class for the inside content of a button
    /// </summary>
    string ButtonInner { get; set; }

    #region Menu
    string Menu { get; set; }

    string HorizontalMenu { get; set; }

    string VerticalMenu { get; set; }

    string MenuHeadingItem { get; set; }

    string MenuHeadingAnchor { get; set; }

    string MenuDropdownWrapper { get; set; }

    string MenuItem { get; set; }

    string MenuAnchor { get; set; }
    #endregion

    string TextBox { get; set; }

    string SelectInput { get; set; }

    string SubLabel { get; set; }
}
