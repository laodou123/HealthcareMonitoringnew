using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Appointment : BaseDomainModel
    {
        public string Location { get; set; }
        public DateTime? Date { get; set; }

        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }

        public string Type { get; set; }

        public virtual Doctor? Doctor { get; set; }
        public int? DoctorId { get; set; }
        public virtual Patient? Patient { get; set; }
        public int? PatientId { get; set; }
        public string? Reason { get; set; }

    }
}