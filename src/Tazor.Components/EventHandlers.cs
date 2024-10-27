using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Tazor.Components;

/// <summary>
/// Registers the onmouseleave/onmouseenter event handlers
/// </summary>
[EventHandler("onmouseleave", typeof(MouseEventArgs), true, true)]
[EventHandler("onmouseenter", typeof(MouseEventArgs), true, true)]
public static class EventHandlers
{
}

