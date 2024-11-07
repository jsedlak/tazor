using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tazor.Components.Layout;

/// <summary>
/// Provides the basic built-in implementation for dragging and dropping elements
/// </summary>
public sealed class DefaultDragProvider : IDragProvider
{
    private object? _draggedObject;
    private IDragTarget? _dragTarget;
    private IDragSource? _dragSource;

    public event PropertyChangedEventHandler? PropertyChanged;

    /// <inheritdoc />
    public object? DraggedObject
    {
        get => _draggedObject;
        set
        {
            if (Equals(value, _draggedObject))
            {
                return;
            }
            
            _draggedObject = value;
            OnPropertyChanged();
        }
    }

    /// <inheritdoc />
    public IDragTarget? DragTarget
    {
        get => _dragTarget;
        set
        {
            if (Equals(value, _dragTarget))
            {
                return;
            }
            
            _dragTarget = value;
            OnPropertyChanged();
        }
    }

    /// <inheritdoc />
    public IDragSource? DragSource
    {
        get => _dragSource;
        set
        {
            if (Equals(value, _dragSource))
            {
                return;
            }
            
            _dragSource = value;
            OnPropertyChanged();
        }
    }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}