using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Doctor : BaseDomainModel
    {
        public string? UserId { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string? DoctorName {  get; set; }

        [Display(Name = "PhoneNumber")]
        [Required]
        public int? DoctorPhoneNumber {  get; set; }
        [Display(Name = "Location")]
        [Required]
        public string? DoctorLocation {  get; set; }

        [Display(Name = "Specialization")]
        [Required]
        public string? DoctorSpecialization {  get; set; }
        [Display(Name = "AvailavleTime")]
        [Required]
        public DateTime? DoctorAvailavleTime {  get; set; }
        [Display(Name = "Experience")]
        [Required]
        public int? DoctorExperience {  get; set; }
        [Display(Name = "Nationality")]
        [Required]
        public string? DoctorNationality {  get; set; }

        [Display(Name = "Introduction")]
        [Required]
        public string? DoctorIntroduction { get; set; }
    }
}
