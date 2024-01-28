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
            _report = await client.GetFromJsonAsync<MedicalReport>($"api/MedicalReports/{Value.ReportId}");
        }
        else
        {
            _report = new HealthcareMonitoring.Shared.Domain.MedicalReport();
            var result = await client.PostAsJsonAsync("api/MedicalReports", _report);

            await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
        }
        /*if (Value.ReportId.HasValue)
        {
            
        }
        else
        {
            _report = new HealthcareMonitoring.Shared.Domain.MedicalReport();
            var result = await client.PostAsJsonAsync("api/MedicalReports", _report);

            Value.ReportId = 1;
            await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
        }*/
        StateHasChanged();
    }

    private async Task OnSubmit(EditContext context)
    {
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        
        var response = await client.PostAsJsonAsync<MedicalReport>("api/MedicalReports", _report); 

        if (response.IsSuccessStatusCode)
        {
            var num = await response.Content.ReadFromJsonAsync<MedicalReport>();

            Value.ReportId = num.Id;
            await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
        }


    }
}
