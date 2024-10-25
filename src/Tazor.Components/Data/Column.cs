using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace Tazor.Components.Data
{
    public class Column<TItem>
    {
        public Column()
        {
        }

        public Column(string title, Expression<Func<TItem, object>> field)
        {
            Title = title;
            Field = field;
        }

        public string Title { get; set; } = null!;

        public Expression<Func<TItem, object>> Field { get; set; } = null!;

        public Type? Component { get; set; }

        public Func<TItem, MarkupString>? Markup { get; set; }

        public bool IsVisible { get; set; } = true;

        public bool IsRemovable { get; set; } = true;

        public Func<IEnumerable<TItem>, string>? Summary { get; set; }

        public SortDirection Sort { get; set; } = SortDirection.None;

        public string? Format { get; set; }

        public object? Tag { get; set; }

        //public virtual RenderFragment? Renderer { get; set; }
    }
}
