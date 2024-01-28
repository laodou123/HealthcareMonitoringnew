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

    private const string Url = "api/MedicalReports";

    private HealthcareMonitoring.Shared.Domain.MedicalReport? _report;

    [Parameter]
    [NotNull]
    public Patient? Value { get; set; }

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Func<string, Task>? OnValueChanged { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //从数据库中读取 Doctor Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");

        if (Value.ReportId.HasValue)
        {
            _report = await client.GetFromJsonAsync<HealthcareMonitoring.Shared.Domain.MedicalReport>($"{Url}/{Value}");
        }
        else
        {
            _report = new HealthcareMonitoring.Shared.Domain.MedicalReport();
            var result = await client.PostAsJsonAsync(Url, _report);
            var t = await result.Content.ReadFromJsonAsync<MedicalReport>();

        }
    }

    private async Task OnSubmit(EditContext context)
    {
        // 写回数据库
        if (_report != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            await client.PutAsJsonAsync($"{Url}/{_report.Id}", _report);
        }
    }
}
