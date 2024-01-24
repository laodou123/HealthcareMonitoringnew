using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthcareMonitoring.Shared.Domain;

namespace HealthcareMonitoring.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Doctor> Doctors { get; }
        IGenericRepository<Diagnosis> Diagnoses { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
    }
}