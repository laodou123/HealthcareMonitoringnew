using Duende.IdentityServer.EntityFramework.Options;
using HealthcareMonitoring.Server.Configurations.Entities;
using HealthcareMonitoring.Server.Models;
using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HealthcareMonitoring.Server.Data
{
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new DoctorSeedConfiguration());
            builder.ApplyConfiguration(new MedRDailySeedConfiguration());
            builder.ApplyConfiguration(new PrescriptionSeedConfiguration());
            builder.ApplyConfiguration(new MedicalReportSeedConfiguration());
            builder.ApplyConfiguration(new DiagnosisSeedConfiguration());
            builder.ApplyConfiguration(new PatientSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());


        }
    }

}
