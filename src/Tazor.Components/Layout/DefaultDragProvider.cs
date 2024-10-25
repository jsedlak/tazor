using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tazor.Components.Layout;

public sealed class DefaultDragProvider : IDragProvider
{
    private object? _draggedObject;
    private IDragTarget? _dragTarget;
    private IDragSource? _dragSource;

    public event PropertyChangedEventHandler? PropertyChanged;

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