using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
	public class Patient : BaseDomainModel
	{
		public Boolean Allergies { get; set; }

		public string? AllergiesDescription { get; set; }



	}
}
