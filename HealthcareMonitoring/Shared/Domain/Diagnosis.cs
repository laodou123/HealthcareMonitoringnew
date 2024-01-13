using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Diagnosis : BaseDomainModel
    {
        public DateTime? DiagnosisDate {  get; set; }

        public DateTime? DiagnosisTime {  get; set; }
        public string DiagnosisText {  get; set; }
    }
}
