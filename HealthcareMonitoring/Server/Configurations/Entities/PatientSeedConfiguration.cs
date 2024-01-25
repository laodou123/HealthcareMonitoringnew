using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using HealthcareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class PatientSeedConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
            new Patient
            {
                Id = 1,
                Name = "Jia Wei",
                LastName = "Tan",
                NRIC = "S1234567G",
                Gender ="Male",
                DOB = System.DateTime.Now,
                PhoneNumber = "12345678",
                Address = "singapore",
                AllergyDes ="seafood",
                Prescription = null,
                Age = null,
                PrescriptionId = null,
            }
        );
        }
    }
}
