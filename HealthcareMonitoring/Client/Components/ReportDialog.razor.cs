using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;
using HealthcareMonitoring.Shared.Domain;
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

    private const string Url = "api/MedicalReports";
    private HealthcareMonitoring.Shared.Domain.MedicalReport? _report;
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Func<string, Task>? OnValueChanged { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userName = state.User?.Identity?.Name;


        //从数据库中读取 Doctor Profile
       var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");

        var reports = await client.GetFromJsonAsync<List<HealthcareMonitoring.Shared.Domain.MedicalReport>?>(Url);


        if (reports != null)
        {
            _report = reports.FirstOrDefault(i => i.Email == userName);
        }

        _report ??= new() { Email = userName };
        await client.PostAsJsonAsync(Url, _report);
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
