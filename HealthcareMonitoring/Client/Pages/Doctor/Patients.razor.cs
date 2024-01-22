using BootstrapBlazor.Components;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Patients
{
    private readonly List<int> PageItemsSource = new() { 20, 40, 80 };

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
        await Task.Delay(0);
    }

    private async Task OnClickPrescriptionButton(HealthcareMonitoring.Shared.Domain.Patient item)
    {
        await Task.Delay(0);
    }
}