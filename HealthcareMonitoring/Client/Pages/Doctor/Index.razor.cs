using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Index
{
    private HealthcareMonitoring.Shared.Domain.Doctor? _doctor;

    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    private const string Url = "api/Doctors";

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userName = state.User?.Identity?.Name;

        // 从数据库中读取 Doctor Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        var doctors = await client.GetFromJsonAsync<List<HealthcareMonitoring.Shared.Domain.Doctor>?>(Url);
        if (doctors != null)
        {
            _doctor = doctors.FirstOrDefault(i => i.UserId == userName);
        }

        _doctor ??= new() { UserId = userName };
        await client.PostAsJsonAsync(Url, _doctor);
    }

    private async Task OnSubmit(EditContext context)
    {
        // 写回数据库
        if (_doctor != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            await client.PutAsJsonAsync($"{Url}/{_doctor.Id}", _doctor);
        }
    }
}