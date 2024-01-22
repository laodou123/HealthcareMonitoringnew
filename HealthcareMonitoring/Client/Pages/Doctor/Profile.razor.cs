using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Profile
{
    private string? _profileString;

    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();

        // TODO: 应该从数据库中获取医生的 Profile 信息赋值给变量即可
        _profileString = "<h1>我是医生</h1>";
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var iden = state.User.Identity;
        var docter = state.User.IsInRole("Doctor");
    }

    private Task OnSaveProfileAsync(string profileString)
    {
        // TODO: 保存到数据库中
        return Task.CompletedTask;
    }
}