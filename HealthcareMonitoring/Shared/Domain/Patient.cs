using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Shared.Domain;

public class Patient
{
    public string? Name { get; set; }

    public string? Report { get; set; }

    [NotNull]
    public Prescription? Prescription { get; set; }
}
