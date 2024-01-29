using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HealthcareMonitoring.Shared.Domain
{
    [Table("Prescription")]
    public class Prescription : BaseDomainModel
    {
        [Display(Name = "Name")]
        [NotNull]
        public string? MedicineName { get; set; }

        [Display(Name = "Quantity")]
        public int MedicineQuantity { get; set; }

        [Display(Name = "Description")]
        [NotNull]
        public string? MedicineDescription { get; set; }

        [Display(Name = "Usage")]
        [NotNull]
        public string? MedicineUsage { get; set; }

        [Display(Name = "Doctor")]
        [NotNull]
        public string? MedicinePrescriptionDoctor { get; set; }
    }
}
