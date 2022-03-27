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
}
