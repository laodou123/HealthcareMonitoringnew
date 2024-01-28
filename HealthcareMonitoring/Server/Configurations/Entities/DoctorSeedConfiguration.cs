using HealthcareMonitoring.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthcareMonitoring.Server.Configurations.Entities
{
    public class DoctorSeedConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
            new Doctor
            {
                Id = 1,
                Email = "13858860788aaa@gmail.com",
                DoctorName = "张三",
                DoctorLocation = "北京",
                DoctorPhoneNumber = 123456789,
                DoctorSpecialization = "心脏病",
                DoctorAvailavleTime = System.DateTime.Now,
                DoctorExperience = 5,
                DoctorNationality = "中国",
                DoctorIntroduction = "张三",

            }
        );
        }
    }
}
