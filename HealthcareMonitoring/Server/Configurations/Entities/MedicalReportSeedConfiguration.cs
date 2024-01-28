using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HealthcareMonitoring.Shared.Domain;
using System.Composition;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class MedicalReportSeedConfiguration : IEntityTypeConfiguration<MedicalReport>
    {
        public void Configure(EntityTypeBuilder<MedicalReport> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasKey(e => e.Id);

            builder.HasData(
                new MedicalReport
                {
                    Id = 1,
                    heartRate = 1,
                    rhythm = "Test",
                    P_wave = "1",
                    PR_Interval = 1,
                    QRS_Complex = 1,
                    QT_Interval = 1,
                    ST_Interval = 1,
                    T_Wave = "1",
                    hb = 1,
                    hct = 1,
                    rbc = 1,
                    wbc = 1,
                    plt = 1,
                    lumarSpine = 1,
                    totalHip = 1,
                    tscoreL = 1,
                    tscoreH = 1,
                    fvc = 1,
                    fev1 = 1,
                    fev1_fvc_ratio = 1,
                    pef = 1,
                    tv = 1,
                    MedicalType = "1",
                },
                new MedicalReport
                {
                    Id = 2,
                    heartRate = 10,
                    rhythm = "Test",
                    P_wave = "Test",
                    PR_Interval = 10,
                    QRS_Complex = 10,
                    QT_Interval = 10,
                    ST_Interval = 10,
                    T_Wave = "Test",
                    hb = 10,
                    hct = 10,
                    rbc = 10,
                    wbc = 10,
                    plt = 10,
                    lumarSpine = 10,
                    totalHip = 10,
                    tscoreL = 10,
                    tscoreH = 10,
                    fvc = 10,
                    fev1 = 10,
                    fev1_fvc_ratio = 10,
                    pef = 10,
                    tv = 10,
                    MedicalType = "Test",
                }
            );
        }
    }
}