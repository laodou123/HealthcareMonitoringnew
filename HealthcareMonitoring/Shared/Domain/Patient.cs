﻿using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Shared.Domain;

public class Patient
{
    public string? Name { get; set; }

    public string? Report { get; set; }

    [NotNull]
    public Prescription? Prescription { get; set; }

    public string? NRIC { get; set; }

    public string? Gender { get; set; }
    public DateTime? DOB { get; set; }

    public int? Age { get; set; }
    public int PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? AllergyDes { get; set; }

}
