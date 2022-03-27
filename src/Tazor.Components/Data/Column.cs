using System.Linq.Expressions;

namespace Tazor.Components.Data
{
    public class Column<TItem>
    {
        public string Title { get; set; } = null!;

        public Expression<Func<TItem, object>> Field { get; set; } = null!;

        public Func<object, string>? FieldRenderer { get; set; }

        public bool IsVisible { get; set; } = true;

        public bool IsRemovable { get; set; } = true;

        public Func<IEnumerable<TItem>, string>? Summary { get; set; }
    }
}
