using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        public string? MedicineName {  get; set; }
        public int? MedicineQuantity {  get; set; }
        public string? MedicineDescription {  get; set; }
        public string? MedicineUsage {  get; set; }
        public string? MedicinePrescriptionDoctor {  get; set; }
    }
}
