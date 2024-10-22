using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Tazor.Components.Content;

public partial class CodeBlock : TazorBaseComponent
{
    private Guid _elementReference = Guid.NewGuid();

    private string GetLanguage()
    {
        return Language != null ? "language-" + Language : "language-markdown";
    }

    private async Task OnCopyToClipboard()
    {
        await JsRuntime.InvokeVoidAsync("copyToClipboard", Code);
    }

    protected override async Task OnInitializedAsync()
    {


        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("highlight", _elementReference.ToString());

        await base.OnAfterRenderAsync(firstRender);
    }

    [Parameter]
    public string Code { get; set; } = null!;

    [Parameter]
    public string? Language { get; set; }

    [Parameter]
    public string? Title { get; set; }

    [Inject]
    protected IJSRuntime JsRuntime { get; set; } = null!;
}
