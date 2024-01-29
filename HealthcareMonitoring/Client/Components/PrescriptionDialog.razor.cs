using BootstrapBlazor.Components;
using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace HealthcareMonitoring.Client.Components;

public partial class PrescriptionDialog
{
    [Inject]
    [NotNull]
    private IHttpClientFactory? HttpClientFactory { get; set; }

    [Inject]
    [NotNull]
    private ToastService? ToastService { get; set; }

    private Prescription? _prescription;

    [Parameter]
    [NotNull]
    public Patient? Value { get; set; }

    [CascadingParameter]
    [NotNull]
    private Func<Task>? OnCloseAsync { get; set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        //从数据库中读取 Doctor Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
        if (Value.PrescriptionId.HasValue)
        {
            _prescription = await client.GetFromJsonAsync<Prescription>($"api/Prescriptions/{Value.PrescriptionId}");
        }
        else
        {
            _prescription = new HealthcareMonitoring.Shared.Domain.Prescription
            {
                MedicineName = " ",
                MedicineDescription = " ",
                MedicineUsage = " ",
                MedicinePrescriptionDoctor = " ",
                MedicineQuantity = 0
            };
            var result = await client.PostAsJsonAsync("api/Prescriptions", _prescription);
            if (result.IsSuccessStatusCode)
            {
                var p = await result.Content.ReadFromJsonAsync<Prescription>();
                if (p != null)
                {
                    Value.PrescriptionId = p.Id;
                    _prescription.Id = p.Id;
                    await client.PutAsJsonAsync($"api/Patients/{Value.Id}", Value);
                }
            }
        }
    }

    private async Task OnSubmit(EditContext context)
    {
        if (_prescription != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            var response = await client.PutAsJsonAsync($"api/Prescriptions/{_prescription.Id}", _prescription);
            if (response.IsSuccessStatusCode)
            {
                await OnCloseAsync();
                await ToastService.Success("Save Prescription", "Save prescription successful");
            }
        }
    }
}
