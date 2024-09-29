using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using Tazor.ServiceModel;

namespace Tazor.Components.App;

/// <summary>
/// Displays a user avatar image, either from a URL or generated from the user's name
/// </summary>
public partial class Avatar : TazorBaseComponent
{
    private IAvatarProvider? AvatarProvider { get; set; }

    /// <inheritdoc/>
    protected override async Task OnInitializedAsync()
    {
        AvatarProvider = ServiceProvider.GetService<IAvatarProvider>();

        if (!string.IsNullOrWhiteSpace(Identifier) && AvatarProvider != null)
        {
            Url = await AvatarProvider.GetAvatarImageUrl(Identifier);
        }

        await base.OnInitializedAsync();
    }

    private string GetSizingClass()
    {
        switch (Size)
        {
            case Sizing.ExtraSmall:
                return Theme.App.Avatar.ExtraSmall;
            case Sizing.Small:
                return Theme.App.Avatar.Small;
            case Sizing.Medium:
                return Theme.App.Avatar.Medium;
            case Sizing.Large:
                return Theme.App.Avatar.Large;
            case Sizing.ExtraLarge:
                return Theme.App.Avatar.ExtraLarge;
        }

        return CustomSizeClass ?? string.Empty;
    }

    /// <summary>
    /// Gets or Sets the optional name to display in the avatar if no URL can be found
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or Sets the user identifier to use to get the avatar image URL
    /// </summary>
    [Parameter]
    public string? Identifier { get; set; }

    /// <summary>
    /// Gets or Sets the url of the avatar URL to display
    /// </summary>
    [Parameter]
    public string? Url { get; set; }

    [Parameter]
    public Sizing Size { get; set; } = Sizing.Medium;

    [Parameter]
    public string? CustomSizeClass { get; set; }

    [Inject]
    private IServiceProvider ServiceProvider { get; set; }
}
