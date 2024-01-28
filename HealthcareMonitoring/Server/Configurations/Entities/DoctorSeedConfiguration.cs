﻿using HealthcareMonitoring.Shared.Domain;
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
                DoctorSpecialization = "Cardiologist",
                DoctorAvailavleTime = System.DateTime.Now,
                DoctorExperience = 5,
                DoctorNationality = "中国",
                DoctorIntroduction = "张三",

            },
            new Doctor
            {
                Id = 5,
                Email = "doc@doc.com",
                DoctorName = "李四",
                DoctorLocation = "上海",
                DoctorPhoneNumber = 87654321,
                DoctorSpecialization = "Pulmonologist",
                DoctorAvailavleTime = System.DateTime.Now,
                DoctorExperience = 4,
                DoctorNationality = "中国",
                DoctorIntroduction = "张三",

            },
            new Doctor
            {
                Id = 3,
                Email = "doc@doc.com",
                DoctorName = "王六",
                DoctorLocation = "黑龙江",
                DoctorPhoneNumber = 87688321,
                DoctorSpecialization = "Orthopedist",
                DoctorAvailavleTime = System.DateTime.Now,
                DoctorExperience = 5,
                DoctorNationality = "中国",
                DoctorIntroduction = "张三",

            },
            new Doctor
            {
                Id = 4,
                Email = "doc@doc.com",
                DoctorName = "胡涵博",
                DoctorLocation = "温州",
                DoctorPhoneNumber = 12376543,
                DoctorSpecialization = "General",
                DoctorAvailavleTime = System.DateTime.Now,
                DoctorExperience = 10,
                DoctorNationality = "中国",
                DoctorIntroduction = "张三",

            }
        );
        }
    }
}
