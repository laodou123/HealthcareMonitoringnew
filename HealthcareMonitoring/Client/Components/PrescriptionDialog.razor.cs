using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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
    private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

    private const string Url = "api/Prescriptions";
    private HealthcareMonitoring.Shared.Domain.Prescription? _prescription;
    [Parameter]
    [NotNull]
    [EditorRequired]
    public Prescription? Value { get; set; }
    public Func<string, Task>? OnValueChanged { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userName = state.User?.Identity?.Name;


        //从数据库中读取 Doctor Profile
        var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");

        var prescriptions = await client.GetFromJsonAsync<List<HealthcareMonitoring.Shared.Domain.Prescription>?>(Url);


        if (prescriptions != null)
        {
            _prescription = prescriptions.FirstOrDefault(i => i.Email == userName);
        }

        _prescription ??= new() { Email = userName };
        await client.PostAsJsonAsync(Url, _prescription);
    }
    private async Task OnSubmit(EditContext context)
    {
        // 写回数据库
        if (_prescription != null)
        {
            var client = HttpClientFactory.CreateClient("HealthcareMonitoring.ServerAPI");
            await client.PutAsJsonAsync($"{Url}/{_prescription.Id}", _prescription);
        }
    }





}
