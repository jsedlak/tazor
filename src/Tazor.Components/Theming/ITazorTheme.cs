namespace Tazor.Components.Theming;

public interface ITazorTheme : ITheme {
    IBaseTheme Base { get; set; }

    string ComponentHeader { get; set; }

    string Table { get; set; }

    string TableSpacing { get; set; }

    /// <summary>
    /// Gets or Sets the classes that style the header of the table or grid
    string TableHeader { get; set; }

    string TableBody { get; set; }

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
    /// Gets or Sets the classes that style the overlay behind the dialog window
    /// </summary>
    string DialogOverlay { get; set; }

    /// <summary>
    /// Gets or Sets the classes for the inside div of the dialog
    /// </summary>
    string DialogWindowInner { get; set; }

    string DialogHeader { get; set; }

    string DialogContent { get; set; }

    string DialogFooter { get; set; }

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

    string Label { get; set; }

    string SubLabel { get; set; }

    string AlertGlobal { get; set; }

    string AlertInfo { get; set; }

    string AlertWarning { get; set; }

    string AlertError { get; set; }

    string AlertSuccess { get; set; }

    string PagerWrapper { get; set; }

    // relative z-0 inline-flex rounded-md shadow-sm -space-x-px
    string Pager { get; set; }

    // cursor-pointer relative inline-flex items-center px-2 py-2 rounded-l-md border text-sm font-medium 
    // border-blue-800 bg-white dark:bg-blue-700 text-gray-500 dark:text-white
    string PagerPreviousButton { get; set; }

    // cursor-pointer z-10 relative inline-flex items-center px-4 py-2 text-sm font-medium 
    string PagerButton { get; set; }

    // dark:bg-gray-200 text-blue-500 dark:bg-blue-500 dark:text-white
    string PagerButtonActive { get; set; }

    // cursor-pointer relative inline-flex items-center px-2 py-2 rounded-r-md border text-sm font-medium
    // border-blue-800 bg-white dark:bg-blue-700 text-gray-500 dark:text-white
    string PagerNextButton { get; set; }

    string TabNavWrapper { get; set; }

    string TabNavSelectedItem { get; set; }

    string TabNavItem { get; set; }

    string TabNavSelectedLink { get; set; }

    string TabNavLink { get; set; }
}
