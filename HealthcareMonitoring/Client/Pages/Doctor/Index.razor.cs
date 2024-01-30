using BootstrapBlazor.Components;
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

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

    private const string Url = "api/Doctors";

    private DoctorSpecialization _specialization = DoctorSpecialization.General;

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
            _doctor = doctors.FirstOrDefault(i => i.Email == userName);
        }

        _doctor ??= new() { Email = userName, DoctorSpecialization = DoctorSpecialization.General.ToString() };
        if (Enum.TryParse<DoctorSpecialization>(_doctor.DoctorSpecialization, out var s))
        {
            _specialization = s;
        }
        await client.PostAsJsonAsync(Url, _doctor);
    }

    private async Task OnSubmit(EditContext context)
    {
        // 写回数据库
        if (_doctor != null)
        {
            _doctor.DoctorSpecialization = _specialization.ToString();
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var response = await client.PutAsJsonAsync($"{Url}/{_doctor.Id}", _doctor);
            if (response.IsSuccessStatusCode)
            {
                await ToastService.Success("Save Profile", "Save doctor profile successful");
            }
        }
    }
}