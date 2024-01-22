using HealthcareMonitoring.Shared.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Shared;

/// <summary>
/// Main Layout
/// </summary>
public partial class MainLayout
{
    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    [Inject]
    [NotNull]
    private IAppContext? AppContext { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();

        if (state.User.Identity != null && state.User.Identity.IsAuthenticated)
        {
            AppContext.UserName = state.User.Identity.Name;
            AppContext.IsDoctor = true;
        }
    }
}
