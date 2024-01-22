using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Client.Components;

public partial class ReportDialog
{
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    [NotNull]
    [EditorRequired]
    public Func<string, Task>? OnValueChanged { get; set; }
}