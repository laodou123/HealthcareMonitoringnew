using Microsoft.AspNetCore.Components.Forms;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Index
{
    private HealthcareMonitoring.Shared.Domain.Doctor _doctor = new();

    private async Task OnSaveProfileAsync(string profileString)
    {

        await DoctorService.UpdateAsync(_doctor);
        // TODO: 保存到数据库中
    }

    private Task OnSubmit(EditContext context)
    {
        return Task.CompletedTask;
    }
}