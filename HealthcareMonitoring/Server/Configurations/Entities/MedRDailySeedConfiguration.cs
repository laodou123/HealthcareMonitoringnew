using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HealthcareMonitoring.Shared.Domain;
using System.Composition;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class MedRDailySeedConfiguration : IEntityTypeConfiguration<MedRDaily>
    {
        public void Configure(EntityTypeBuilder<MedRDaily> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasKey(e => e.Id);
            builder.HasData(
                new MedRDaily
                {
                    Id = 1,
                    bpm = 1,
                    systolicPressure = 1,
                    diastolicPressure = 1,
                    bloodSugarLevel=1,
                    PatientId=1,

                },
                 new MedRDaily
                 {

                     Id = 2,
                     bpm = 5,
                     systolicPressure = 10,
                     diastolicPressure = 12,
                     bloodSugarLevel = 15,
                     PatientId = 1,


                 }
            );
        }
    }
}