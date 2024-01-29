using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Components;

public partial class PrescriptionDialog
{
    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    private HealthcareMonitoring.Shared.Domain.Prescription? _prescription;

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Patient? Value { get; set; }

    [CascadingParameter]
    [NotNull]
    private Func<Task>? OnCloseAsync { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //从数据库中读取 Doctor Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        if (Value.ReportId.HasValue)
        {
            _prescription = await client.GetFromJsonAsync<Prescription>($"api/Prescriptions/{Value.ReportId}");
        }
        else
        {
            _prescription = new HealthcareMonitoring.Shared.Domain.Prescription
            {
            };
            var result = await client.PostAsJsonAsync("api/MedicalReports", _prescription);
            if (result.IsSuccessStatusCode)
            {
                var report = await result.Content.ReadFromJsonAsync<Prescription>();
                if (report != null)
                {
                    Value.ReportId = report.Id;
                    await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
                }
            }
        }
    }

    private async Task OnSubmit(EditContext context)
    {
        if (_prescription != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var reportResponse = await client.PostAsJsonAsync("api/Prescriptions", _prescription);
            if (reportResponse.IsSuccessStatusCode)
            {
                var report = await reportResponse.Content.ReadFromJsonAsync<Prescription>();
                if (report != null)
                {
                    Value.ReportId = report.Id;
                    await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
                    await OnCloseAsync();
                }
            }
        }
    }
}
