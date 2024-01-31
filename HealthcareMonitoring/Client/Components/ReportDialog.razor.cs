using BootstrapBlazor.Components;
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

    private MedicalReport? _report;

    [Parameter]
    [NotNull]
    public Patient? Value { get; set; }

    [CascadingParameter]
    [NotNull]
    private Func<Task>? OnCloseAsync { get; set; }

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

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
                    _report.Id = report.Id;
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
            var response = await client.PutAsJsonAsync($"api/MedicalReports/{_report.Id}", _report);
            if (response.IsSuccessStatusCode)
            {
                await OnCloseAsync();
                await ToastService.Success("Save Report", "Save medical report Successful!");
            }
        }
    }

    private bool _diagnosis;
    private string? _diagnosisResult;

    private async Task OnClickDiagnosis()
    {
        if (_report != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var content = $"""
                heartRate = {_report.heartRate} rhythm = Normal P_wave = Normal PR_Interval = 42.56 QRS_Complex = 73.89 QT_Interval = 64.25 ST_Interval = 38.12 T_Wave = Normal hb = 11.85 hct = 37.24 rbc = 4.68 wbc = 12.59 plt = 234.56 lumarSpine = 6.32 totalHip = 45.78 tscoreL = 3.14 tscoreH = 4.29 fvc = 3.78 fev1 = 4.03 fev1_fvc_ratio = 0.85 pef = 8.91 tv = 0.54 MedicalType = Type A Based on this medical report, give me the possible of illiness may arise from the data above This is just an example of medical report give me the respond
                """;
            var response = await client.PostAsJsonAsync("api/OpenAI", content);
            _diagnosisResult = await response.Content.ReadAsStringAsync();
            _diagnosis = true;
        }
    }
}
