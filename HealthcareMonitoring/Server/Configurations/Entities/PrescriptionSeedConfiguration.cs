using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HealthcareMonitoring.Shared.Domain;
using System.Composition;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class PrescriptionSeedConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasKey(e => e.Id);
            builder.HasData(
                new Prescription
                {
                    Id=1,
                    MedicineName="Test",
                    MedicineQuantity=1,
                    MedicineDescription="Test",
                    MedicineUsage="Test",
                    MedicinePrescriptionDoctor="Test",
                    PatId=1,
                },
                new Prescription
                {

                    Id = 2,
                    MedicineName="Test2",
                    MedicineQuantity=2,
                    MedicineDescription="Test2",
                    MedicineUsage="Tes2t",
                    MedicinePrescriptionDoctor="Test2",
                    PatId =1,
                },
                new Prescription
                {

                    Id = 3,
                    MedicineName = "Test2",
                    MedicineQuantity = 2,
                    MedicineDescription = "Test2",
                    MedicineUsage = "Tes2t",
                    MedicinePrescriptionDoctor = "Test2",
                    PatId = 3,
                },
                new Prescription
                {

                    Id = 4,
                    MedicineName = "Test3",
                    MedicineQuantity = 2,
                    MedicineDescription = "Test3",
                    MedicineUsage = "Test3",
                    MedicinePrescriptionDoctor = "Test3",
                    PatId = 1,
                }, new Prescription
                {

                    Id = 5,
                    MedicineName = "Test2",
                    MedicineQuantity = 2,
                    MedicineDescription = "Test2",
                    MedicineUsage = "Tes2t",
                    MedicinePrescriptionDoctor = "Test2",
                    PatId = 2,
                }
            );
        }
    }
}