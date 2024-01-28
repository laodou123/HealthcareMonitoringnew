using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Pages.Patient;

public partial class UpdateProfile
{
    private HealthcareMonitoring.Shared.Domain.Patient? _patient;

    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    private const string Url = "api/patients";

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userName = state.User?.Identity?.Name;

        // 从数据库中读取 patient Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        var patients = await client.GetFromJsonAsync<List<HealthcareMonitoring.Shared.Domain.Patient>?>(Url);
        if (patients != null)
        {
            _patient = patients.FirstOrDefault(i => i.Email == userName);
        }

        _patient ??= new() { UserId = userName };
        await client.PostAsJsonAsync(Url, _patient);
    }

    private async Task OnSubmit(EditContext context)
    {
        // 写回数据库
        if (_patient != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            await client.PutAsJsonAsync($"{Url}/{_patient.Id}", _patient);
        }
    }
}