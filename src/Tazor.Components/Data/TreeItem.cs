using Microsoft.AspNetCore.Components;

namespace Tazor.Components.Data;

/// <summary>
/// Provides default tree item implementation
/// </summary>
public class TreeItem : ITreeItem
{
    /// <inheritdoc />
    public string Title { get; set; } = null!;

    /// <inheritdoc />
    public IEnumerable<ITreeItem> Children { get; set; } = Enumerable.Empty<ITreeItem>();

    /// <inheritdoc />
    public MarkupString Icon { get; set; }

    /// <inheritdoc />
    public bool IsExpanded { get; set; }
}
