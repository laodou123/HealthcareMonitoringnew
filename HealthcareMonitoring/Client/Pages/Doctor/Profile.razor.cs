using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Pages.Doctor;

public partial class Profile
{
    private HealthcareMonitoring.Shared.Domain.Doctor _doctor = new();

    private Task OnSaveProfileAsync(string profileString)
    {
        // TODO: 保存到数据库中
        return Task.CompletedTask;
    }

    private Task OnSubmit(EditContext context)
    {
        return Task.CompletedTask;
    }
}