using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public class TreeItem : ITreeItem
{
    public string Title { get; set; } = null!;

    public IEnumerable<ITreeItem> Children { get; set; } = Enumerable.Empty<ITreeItem>();

    public MarkupString Icon { get; set; }

    public bool IsExpanded { get; set; }
}
