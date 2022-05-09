using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;

namespace Tazor.Components.Data
{
    public class Column<TItem>
    {
        public string Title { get; set; } = null!;

        public Expression<Func<TItem, object>> Field { get; set; } = null!;

        public Func<TItem, RenderFragment>? Renderer { get; set; }

        public bool IsVisible { get; set; } = true;

        public bool IsRemovable { get; set; } = true;

        public Func<IEnumerable<TItem>, string>? Summary { get; set; }

        public SortDirection Sort { get; set; } = SortDirection.None;

        public string? Format { get; set; }
    }
}
