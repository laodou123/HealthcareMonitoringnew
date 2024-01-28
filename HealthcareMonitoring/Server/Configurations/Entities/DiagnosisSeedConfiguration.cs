using HealthcareMonitoring.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class DiagnosisSeedConfiguration : IEntityTypeConfiguration<Diagnosis>
    {
        public void Configure(EntityTypeBuilder<Diagnosis> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasKey(e => e.Id);
            builder.HasData(
            new Diagnosis
            {
                Id = 1,
                DiagnosisDate = new System.DateTime(2021, 3, 1),
                DiagnosisTime = new System.DateTime(2021, 3, 1),
                DiagnosisText = "Test",

            }
            );
        }
    }
}