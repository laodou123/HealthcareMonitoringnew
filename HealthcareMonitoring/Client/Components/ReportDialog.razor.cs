using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Components;

public partial class ReportDialog
{
    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    private HealthcareMonitoring.Shared.Domain.MedicalReport? _report;

    [Parameter]
    [NotNull]
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
            _report = await client.GetFromJsonAsync<MedicalReport>($"api/MedicalReports/{Value.ReportId}");
        }
        else
        {
            _report = new HealthcareMonitoring.Shared.Domain.MedicalReport
            {
                MedicalType = " ",
                P_wave = " ",
                rhythm = " ",
                T_Wave = " "
            };
            var result = await client.PostAsJsonAsync("api/MedicalReports", _report);
            if (result.IsSuccessStatusCode)
            {
                var report = await result.Content.ReadFromJsonAsync<MedicalReport>();
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
        if (_report != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var reportResponse = await client.PostAsJsonAsync("api/MedicalReports", _report);
            if (reportResponse.IsSuccessStatusCode)
            {
                var report = await reportResponse.Content.ReadFromJsonAsync<MedicalReport>();
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
