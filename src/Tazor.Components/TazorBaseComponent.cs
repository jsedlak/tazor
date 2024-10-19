using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tazor.Components.Theming;

namespace Tazor.Components;

/// <summary>
/// Provides the base class for all Tazor components
/// </summary>
public abstract class TazorBaseComponent : ComponentBase
{
    /// <summary>
    /// Gets or Sets the theme that has been cascaded to this component
    /// </summary>
    [CascadingParameter(Name = "Theme")]
    public ITheme Theme { get; set; } = null!;
}
