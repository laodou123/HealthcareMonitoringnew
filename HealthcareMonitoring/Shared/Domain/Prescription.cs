﻿using System.ComponentModel.DataAnnotations;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        public int? PatientId { get; set; }
        [Display(Name = "Name")]
        public string? MedicineName { get; set; }

        [Display(Name = "Quantity")]
        public int? MedicineQuantity { get; set; }

        [Display(Name = "Description")]
        public string? MedicineDescription { get; set; }

        [Display(Name = "Usage")]
        public string? MedicineUsage { get; set; }

        [Display(Name = "Doctor")]
        public string? MedicinePrescriptionDoctor { get; set; }
    }
}
