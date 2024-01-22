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
        var items = new List<HealthcareMonitoring.Shared.Domain.Patient>();
        items.Add(new HealthcareMonitoring.Shared.Domain.Patient()
        {
            Name = "张三"
        });

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

    private async Task OnClickPrescriptionButton(HealthcareMonitoring.Shared.Domain.Patient item)
    {
        await Task.Delay(0);
    }
}