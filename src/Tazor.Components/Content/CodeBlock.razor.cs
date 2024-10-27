using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Content;

/// <summary>
/// Provides a syntax highlighted code experience
/// </summary>
public partial class CodeBlock : TazorBaseComponent
{
    private readonly Guid _elementReference = Guid.NewGuid();

    private string GetLanguage()
    {
        return Language != null ? "language-" + Language : "language-markdown";
    }

    private async Task OnCopyToClipboard()
    {
        await JsRuntime.InvokeVoidAsync("copyToClipboard", Code);
    }

    /// <inheritdoc />
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("highlight", _elementReference.ToString());

        await base.OnAfterRenderAsync(firstRender);
    }

    /// <summary>
    /// Gets or Sets the code to display
    /// </summary>
    [Parameter]
    public string Code { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the language being displayed
    /// </summary>
    [Parameter]
    public string? Language { get; set; }

    /// <summary>
    /// Gets or Sets the title or filename
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or Sets the Javascript Runtime service
    /// </summary>
    [Inject]
    protected IJSRuntime JsRuntime { get; set; } = null!;
}
