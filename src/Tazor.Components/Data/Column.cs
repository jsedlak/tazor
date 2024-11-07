using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace Tazor.Components.Data;

/// <summary>
/// Describes a column for the <see cref="DataGrid{TItem}"/> component
/// </summary>
/// <typeparam name="TItem"></typeparam>
public class Column<TItem>
{
    /// <summary>
    /// Default Constructor
    /// </summary>
    public Column()
    {
    }

    /// <summary>
    /// Parameterized Constructor
    /// </summary>
    /// <param name="title"></param>
    /// <param name="field"></param>
    public Column(string title, Expression<Func<TItem, object>> field)
    {
        Title = title;
        Field = field;
    }

    /// <summary>
    /// Gets or Sets the title of the column
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the expression to retrieve the cell value
    /// </summary>
    public Expression<Func<TItem, object>> Field { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the custom component to use to render the data
    /// </summary>
    public Type? Component { get; set; }

    /// <summary>
    /// Gets or Sets the markup string callback to override default rendering
    /// </summary>
    public Func<TItem, MarkupString>? Markup { get; set; }

    /// <summary>
    /// Gets or Sets whether the column is visible
    /// </summary>
    public bool IsVisible { get; set; } = true;

    /// <summary>
    /// Gets or Sets whether the column may be removed
    /// </summary>
    public bool IsRemovable { get; set; } = true;

    /// <summary>
    /// Gets or Sets the summary cell callback
    /// </summary>
    public Func<IEnumerable<TItem>, string>? Summary { get; set; }

    /// <summary>
    /// Gets or Sets the sort direction
    /// </summary>
    public SortDirection Sort { get; set; } = SortDirection.None;

    /// <summary>
    /// Gets or Sets the format string for default rendering
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// Gets or Sets optional data
    /// </summary>
    public object? Tag { get; set; }
}
