using Duende.IdentityServer.EntityFramework.Options;
using HealthcareMonitoring.Server.Models;
using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using HealthcareMonitoring.Shared.Domain;

namespace HealthcareMonitoring.Server.Data
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Diagnosis> Diagnoses { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalReport> MedicalReports { get; set; }
        public DbSet<MedRDaily> medRDailies { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> prescriptions { get; set; }

    }
}