using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;

namespace HealthcareMonitoring.Client.Components;

public partial class ReportDialog
{
    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }
    [Inject]
    [NotNull]
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    private const string Url = "api/Report";
    private HealthcareMonitoring.Shared.Domain.MedicalReport? _report;
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Func<string, Task>? OnValueChanged { get; set; }
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
