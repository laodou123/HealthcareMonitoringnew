using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Doctor : BaseDomainModel
    {
        public string? DoctorName {  get; set; }
        public int? DoctorPhoneNumber {  get; set; }

        public string? DoctorSpecialization {  get; set; }

        public DateTime? DoctorAvailavleTime {  get; set; }

        public int? DoctorExperience {  get; set; }

        public string? DoctorNationality {  get; set; }
    }
}
