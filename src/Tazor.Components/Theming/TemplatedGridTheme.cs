﻿namespace Tazor.Components.Theming;

/// <summary>
/// Provides theming for the <see cref="Tazor.Components.DataTemplatedGrid{TItem}"/>
/// </summary>
public class TemplatedGridTheme
{
    /// <summary>
    /// Gets or Sets the container CSS classes
    /// </summary>
    public string Container { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the container CSS classes when the grid is collapsed
    /// </summary>
    public string ContainerCollapsed { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the container CSS classes when the gird is expanded
    /// </summary>
    public string ContainerExpanded { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table element
    /// </summary>
    public string TableElement { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's toolbar
    /// </summary>
    public string Toolbar { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's header
    /// </summary>
    public string Header { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the header row
    /// </summary>
    public string HeaderRow { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's header cell
    /// </summary>
    public string HeaderCell { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's body
    /// </summary>
    public string Body { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's even row
    /// </summary>
    public string EvenRow { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's odd row
    /// </summary>
    public string OddRow { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's cell
    /// </summary>
    public string Cell { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's summary row
    /// </summary>
    public string SummaryRow { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's summary cell
    /// </summary>
    public string SummaryCell { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's footer
    /// </summary>
    public string Footer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the CSS classes for the table's sorting icon
    /// </summary>
    public string SortingIcon { get; set; } = string.Empty;
}
