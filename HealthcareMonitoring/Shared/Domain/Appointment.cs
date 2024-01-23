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

        public string Type { get; set; }

    }
}