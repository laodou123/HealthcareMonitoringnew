namespace HealthcareMonitoring.Shared.Domain;

public class Patient
{
    public string? Name { get; set; }

    public string? Report { get; set; }

    public Prescription? Prescription { get; set; }
}
