using BootstrapBlazor.Components;
using HealthcareMonitoring.Client.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Patients
{
    private HealthcareMonitoring.Shared.Domain.Patient? _patient;

    private readonly List<int> PageItemsSource = new() { 20, 40, 80 };

    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    [Inject]
    [NotNull]
    private DialogService? DialogService { get; set; }

    private const string Url = "api/Patients";

    private async Task<QueryData<HealthcareMonitoring.Shared.Domain.Patient>> OnQueryAsync(QueryPageOptions options)
    {
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        var patients = await client.GetFromJsonAsync<List<HealthcareMonitoring.Shared.Domain.Patient>?>(Url);


        return new QueryData<HealthcareMonitoring.Shared.Domain.Patient>()
        {
            Items = patients,
            TotalCount = patients.Count,
            IsSorted = true,
            IsFiltered = true,
            IsSearch = true
        };
    }

    private async Task OnClickReportButton(HealthcareMonitoring.Shared.Domain.Patient item)
    {
        await DialogService.ShowSaveDialog<ReportDialog>("Medical Report", parametersFactory: dict =>
        {
            dict.Add("Value", item);
        }, configureOption: options =>
        {
            options.ShowFooter = false;
        });
    }

    private async Task OnClickPrescriptionButton(HealthcareMonitoring.Shared.Domain.Patient item)
    {
        await DialogService.ShowSaveDialog<PrescriptionDialog>("Prescription Dialog", parametersFactory: dict =>
        {
            dict.Add("Value", item);
        }, configureOption: options =>
        {
            options.ShowFooter = false;
        });
    }
}