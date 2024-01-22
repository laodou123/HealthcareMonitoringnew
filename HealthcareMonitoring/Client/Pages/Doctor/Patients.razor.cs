using BootstrapBlazor.Components;
using HealthcareMonitoring.Client.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Patients
{
    private readonly List<int> PageItemsSource = new() { 20, 40, 80 };

    [Inject]
    [NotNull]
    private DialogService? DialogService { get; set; }

    private Task<QueryData<HealthcareMonitoring.Shared.Domain.Patient>> OnQueryAsync(QueryPageOptions options)
    {
        var items = new List<HealthcareMonitoring.Shared.Domain.Patient>
        {
            new()
            {
                Name = "张三",
                Prescription = new()
                {
                    MedicineName = "Test"
                }
            }
        };

        return Task.FromResult(new QueryData<HealthcareMonitoring.Shared.Domain.Patient>()
        {
            Items = items,
            TotalCount = 1,
            IsSorted = true,
            IsFiltered = true,
            IsSearch = true
        });
    }

    private async Task OnClickReportButton(HealthcareMonitoring.Shared.Domain.Patient item)
    {
        await DialogService.ShowSaveDialog<ReportDialog>("Medical Report", () =>
        {
            return Task.FromResult(true);
        }, dict =>
        {
            dict.Add("Value", item.Report);
            dict.Add("OnValueChanged", new Func<string, Task>(v =>
            {
                item.Report = v;
                return Task.CompletedTask;
            }));
        });
    }

    private async Task OnClickPrescriptionButton(HealthcareMonitoring.Shared.Domain.Prescription item)
    {
        await DialogService.ShowSaveDialog<PrescriptionDialog>("Prescription Dialog", () =>
        {
            return Task.FromResult(true);
        }, dict =>
        {
            dict.Add("Value", item);
            dict.Add("OnValueChanged", new Func<HealthcareMonitoring.Shared.Domain.Prescription, Task>(v =>
            {
                item = v;
                return Task.CompletedTask;
            }));
        });
    }
}