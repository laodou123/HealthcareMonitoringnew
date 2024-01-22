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
        [Display(Name = "Name")]
        [Required]
        public string? DoctorName {  get; set; }

        [Display(Name = "PhoneNumber")]
        public int? DoctorPhoneNumber {  get; set; }

        [Display(Name = "Specialization")]
        public string? DoctorSpecialization {  get; set; }

        public DateTime? DoctorAvailavleTime {  get; set; }

        public int? DoctorExperience {  get; set; }

        public string? DoctorNationality {  get; set; }
    }
}
