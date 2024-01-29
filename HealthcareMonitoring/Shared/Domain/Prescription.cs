using System.ComponentModel.DataAnnotations;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        [Display(Name = "Name")]
        [Required]
        public string? MedicineName { get; set; }

        [Display(Name = "Quantity")]
        [Required]
        public int? MedicineQuantity { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string? MedicineDescription { get; set; }

        [Display(Name = "Usage")]
        [Required]
        public string? MedicineUsage { get; set; }

        [Display(Name = "Doctor")]
        [Required]
        public string? MedicinePrescriptionDoctor { get; set; }
    }
}
