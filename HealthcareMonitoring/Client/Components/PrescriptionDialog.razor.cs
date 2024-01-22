using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Components;

public partial class PrescriptionDialog
{
    [Parameter]
    [NotNull]
    [EditorRequired]
    public Prescription? Value { get; set; }

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Func<Prescription, Task>? OnValueChanged { get; set; }

    private Task OnSubmit(EditContext context)
    {
        return OnValueChanged(Value);
    }
}
