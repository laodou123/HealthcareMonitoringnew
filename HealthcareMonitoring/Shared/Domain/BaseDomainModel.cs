﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Shared.Domain
{
    internal abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated {  get; set; }
        public DateTime? DateDeleted {  get; set; } 
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy {  get; set; }
    }
}
