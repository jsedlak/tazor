using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

public interface ITreeItem
{
    string Title { get; set; }

    MarkupString Icon { get; set; }

    IEnumerable<ITreeItem> Children { get; set; }

    bool IsExpanded { get; set; }
}
