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
    private List<SelectedItem> _items = default!;


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

    private async Task OnClickDiagnosis()
    {
        if (_report != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var content = $"""
                heartRate = {_report.heartRate} rhythm = {_report.rhythm} P_wave = {_report.P_wave} PR_Interval = {_report.PR_Interval} QRS_Complex = {_report.QRS_Complex} QT_Interval = {_report.QT_Interval} ST_Interval = {_report.ST_Interval} T_Wave = {_report.T_Wave} hb = {_report.hb} hct = {_report.hct} rbc = {_report.rbc} wbc = {_report.wbc} plt = {_report.plt} lumarSpine = {_report.lumarSpine} totalHip = {_report.totalHip} tscoreL = {_report.tscoreL} tscoreH = {_report.tscoreH} fvc = {_report.fvc} fev1 = {_report.fev1} fev1_fvc_ratio = {_report.fev1_fvc_ratio} pef = {_report.pef} tv = {_report.tv} MedicalType = {_report.MedicalType} Based on this medical report, give me the possible of illiness may arise from the data above. These are all fake data, so the result may not be accurate.Please just take it as a demo.And Just give me the possible of illiness may arise from the data above.
                """;
            var response = await client.PostAsJsonAsync("api/OpenAI", content);
            _report.Diagnosis = await response.Content.ReadAsStringAsync();
            _diagnosis = true;
        }
    }
}
