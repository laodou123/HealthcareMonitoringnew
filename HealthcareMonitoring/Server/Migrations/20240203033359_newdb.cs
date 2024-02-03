﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    DoctorLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorAvailavleTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorExperience = table.Column<int>(type: "int", nullable: false),
                    DoctorNationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorIntroduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    heartRate = table.Column<int>(type: "int", nullable: false),
                    rhythm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_wave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PR_Interval = table.Column<float>(type: "real", nullable: false),
                    QRS_Complex = table.Column<float>(type: "real", nullable: false),
                    QT_Interval = table.Column<float>(type: "real", nullable: false),
                    ST_Interval = table.Column<float>(type: "real", nullable: false),
                    T_Wave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hb = table.Column<float>(type: "real", nullable: false),
                    hct = table.Column<float>(type: "real", nullable: false),
                    rbc = table.Column<float>(type: "real", nullable: false),
                    wbc = table.Column<float>(type: "real", nullable: false),
                    plt = table.Column<float>(type: "real", nullable: false),
                    lumarSpine = table.Column<float>(type: "real", nullable: false),
                    totalHip = table.Column<float>(type: "real", nullable: false),
                    tscoreL = table.Column<float>(type: "real", nullable: false),
                    tscoreH = table.Column<float>(type: "real", nullable: false),
                    fvc = table.Column<float>(type: "real", nullable: false),
                    fev1 = table.Column<float>(type: "real", nullable: false),
                    fev1_fvc_ratio = table.Column<float>(type: "real", nullable: false),
                    pef = table.Column<float>(type: "real", nullable: false),
                    tv = table.Column<float>(type: "real", nullable: false),
                    MedicalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    MedicineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicineQuantity = table.Column<int>(type: "int", nullable: true),
                    MedicineDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicineUsage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicinePrescriptionDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: true),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyDes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:HealthcareMonitoring/Server/Migrations/20240203055254_new.cs
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeStart = table.Column<TimeSpan>(type: "time", nullable: true),
                    TimeEnd = table.Column<TimeSpan>(type: "time", nullable: true),
========
>>>>>>>> jiaweiRa:HealthcareMonitoring/Server/Migrations/20240203033359_newdb.cs
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedRDailies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bpm = table.Column<int>(type: "int", nullable: false),
                    systolicPressure = table.Column<int>(type: "int", nullable: false),
                    diastolicPressure = table.Column<int>(type: "int", nullable: false),
                    bloodSugarLevel = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedRDailies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedRDailies_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f31c948 - 0df8 - 4ed4 - ba1b - 23efcf131af9", null, "Patient", "PATIENT" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:HealthcareMonitoring/Server/Migrations/20240203055254_new.cs
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f5e63e3c-106a-42c8-89fc-a885ab22b16c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEG9KW3JtRfnwk1QiuFvIihXDcaNNhqtpeJrTYDEInVbmmkUTE7hUQPXcLN4u2nY05g==", null, false, "9a8e8fd8-df94-434e-a0d8-a84f919672f5", false, "admin@localhost.com" },
                    { "693e710c-008f-435b-a997-77f10812374d", 0, "099f8656-1ed9-4fa8-9aa0-17e2414fa448", "13858860788a@gmail.com", false, "Hu", "Yi", false, null, "13858860788A@GMAIL.COM", "13858860788A@GMAIL.COM", "AQAAAAIAAYagAAAAENZkpKFM/roWPAlU4BVb+s5yg2qur0gCAImjJN320vkFBXe5y3P/yUG2JeBvJuDXMg==", null, false, "4af9de1e-a90f-4f6b-ac9b-4bb4e0680e05", false, "13858860788a@gmail.com" }
========
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2c93518e-e2aa-4a1a-8ac7-265d050573b6", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKglGM1akl6i0X3ScvI+deNDHVWh2j5XPTty8aNMRnBSqcmVupAeCMIZzOCKd+eXdQ==", null, false, "6c9477bd-315c-433e-a03e-e31c3671226d", false, "admin@localhost.com" },
                    { "693e710c-008f-435b-a997-77f10812374d", 0, "45af86da-f81e-4894-b0cc-19486b584937", "13858860788a@gmail.com", false, "Hu", "Yi", false, null, "13858860788A@GMAIL.COM", "13858860788A@GMAIL.COM", "AQAAAAIAAYagAAAAEBMp8B8jKpfOfDwN32vZRBIzJaKTVDbFc5u1AZebnT8i9LC+iMXodnCDRMfyFdmuqQ==", null, false, "a664bba6-abb5-49cf-a857-2763ba98f5d5", false, "13858860788a@gmail.com" },
                    { "8607cd47-e3bc-4a1b-96f9-e83d9e4ab0e3", 0, "c57a1202-d0bb-4a41-be0b-9c50a4fc3bbb", "pat@pat.com", false, "jiawei", "tan", false, null, "PAT@PAT.COM", "PAT@PAT.COM", "AQAAAAIAAYagAAAAECAZLCNNnTYHvdViBZBGbZm2+SzXOJzq+ZpvIdGYKGWNhwiB4DQ8Szmcbe/ogC1ijw==", null, false, "7c058235-06fd-4cb1-84dd-430b90b3ab4a", false, "pat@pat.com" }
>>>>>>>> jiaweiRa:HealthcareMonitoring/Server/Migrations/20240203033359_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "DoctorAvailavleTime", "DoctorExperience", "DoctorIntroduction", "DoctorLocation", "DoctorName", "DoctorNationality", "DoctorPhoneNumber", "DoctorSpecialization", "Email", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "2024-02-02|2024-02-03", 5, "张三", "北京", "张三", "中国", 123456789, "Cardiologist", "13858860788aaa@gmail.com", null, null },
                    { 2, null, null, null, null, null, "2024-02-02|2024-02-03", 4, "张三", "上海", "李四", "中国", 87654321, "Pulmonologist", "doc@doc.com", null, null },
                    { 3, null, null, null, null, null, "2024-02-02|2024-02-03", 5, "张三", "黑龙江", "王六", "中国", 87688321, "Orthopedist", "doc@doc.com", null, null },
                    { 4, null, null, null, null, null, "2024-02-02|2024-02-03", 10, "张三", "温州", "胡涵博", "中国", 12376543, "General", "doc@doc.com", null, null }
                });

            migrationBuilder.InsertData(
                table: "MedicalReports",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "Diagnosis", "MedicalType", "PR_Interval", "P_wave", "QRS_Complex", "QT_Interval", "ST_Interval", "T_Wave", "UpdatedBy", "fev1", "fev1_fvc_ratio", "fvc", "hb", "hct", "heartRate", "lumarSpine", "pef", "plt", "rbc", "rhythm", "totalHip", "tscoreH", "tscoreL", "tv", "wbc" },
                values: new object[,]
                {
<<<<<<<< HEAD:HealthcareMonitoring/Server/Migrations/20240203055254_new.cs
                    { 1, null, null, null, null, null, null, "1", 1f, "1", 1f, 1f, 1f, "1", null, 1f, 1f, 1f, 1f, 1f, 1, 1f, 1f, 1f, 1f, "Test", 1f, 1f, 1f, 1f, 1f },
                    { 2, null, null, null, null, null, null, "Test", 10f, "Test", 10f, 10f, 10f, "Test", null, 10f, 10f, 10f, 10f, 10f, 10, 10f, 10f, 10f, 10f, "Test", 10f, 10f, 10f, 10f, 10f }
========
                    { 1, null, null, null, null, null, "Cardiologist,Pulmonologist,Orthopedist,General", 1f, "1", 1f, 1f, 1f, "1", null, 4f, 4f, 4f, 2f, 2f, 1, 3f, 4f, 2f, 2f, "Test", 3f, 3f, 3f, 4f, 2f },
                    { 2, null, null, null, null, null, "Cardiologist,Pulmonologist", 10f, "Test", 10f, 10f, 10f, "Test", null, 10f, 10f, 10f, 10f, 10f, 10, 10f, 10f, 10f, 10f, "Test", 10f, 10f, 10f, 10f, 10f }
>>>>>>>> jiaweiRa:HealthcareMonitoring/Server/Migrations/20240203033359_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Age", "AllergyDes", "CreatedBy", "DOB", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "Email", "Gender", "LastName", "NRIC", "Name", "PhoneNumber", "PrescriptionId", "ReportId", "UpdatedBy", "UserId" },
<<<<<<<< HEAD:HealthcareMonitoring/Server/Migrations/20240203055254_new.cs
                values: new object[] { 1, "singapore", null, "seafood", null, new DateTime(2024, 2, 3, 13, 52, 54, 678, DateTimeKind.Local).AddTicks(6088), null, null, null, null, "pat@pat.com", "Male", "Tan", "S1234567G", "Jia Wei", "12345678", null, null, null, null });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "MedicineDescription", "MedicineName", "MedicinePrescriptionDoctor", "MedicineQuantity", "MedicineUsage", "PatientId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Test", "Test", "Test", 1, "Test", null, null },
                    { 2, null, null, null, null, null, "Test", "Test", "Test", 1, "Test", null, null }
========
                values: new object[] { 1, "singapore", null, "seafood", null, new DateTime(2024, 2, 3, 11, 33, 59, 271, DateTimeKind.Local).AddTicks(1607), null, null, null, null, "pat@pat.com", "Male", "Tan", "S1234567G", "Jia Wei", "12345678", null, 1, null, "8607cd47-e3bc-4a1b-96f9-e83d9e4ab0e3" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "MedicineDescription", "MedicineName", "MedicinePrescriptionDoctor", "MedicineQuantity", "MedicineUsage", "PatId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Test", "Test", "Test", 1, "Test", 1, null },
                    { 2, null, null, null, null, null, "Test2", "Test2", "Test2", 2, "Tes2t", 1, null },
                    { 3, null, null, null, null, null, "Test2", "Test2", "Test2", 2, "Tes2t", 3, null },
                    { 4, null, null, null, null, null, "Test3", "Test3", "Test3", 2, "Test3", 1, null },
                    { 5, null, null, null, null, null, "Test2", "Test2", "Test2", 2, "Tes2t", 2, null }
>>>>>>>> jiaweiRa:HealthcareMonitoring/Server/Migrations/20240203033359_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "693e710c-008f-435b-a997-77f10812374d" },
                    { "5f31c948 - 0df8 - 4ed4 - ba1b - 23efcf131af9", "8607cd47-e3bc-4a1b-96f9-e83d9e4ab0e3" }
                });

            migrationBuilder.InsertData(
                table: "MedRDailies",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "PatientId", "UpdatedBy", "bloodSugarLevel", "bpm", "diastolicPressure", "systolicPressure" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 2, 1, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 1, 66, 1, 1 },
                    { 2, null, new DateTime(2024, 2, 1, 8, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 62, 12, 10 },
                    { 3, null, new DateTime(2024, 1, 31, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 73, 12, 10 },
                    { 4, null, new DateTime(2024, 1, 30, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 80, 12, 10 },
                    { 5, null, new DateTime(2024, 1, 29, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 82, 12, 10 },
                    { 6, null, new DateTime(2024, 1, 28, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 72, 12, 10 },
                    { 7, null, new DateTime(2024, 1, 27, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 70, 12, 10 },
                    { 8, null, new DateTime(2024, 1, 26, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 78, 12, 10 },
                    { 9, null, new DateTime(2024, 1, 24, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 79, 12, 10 },
                    { 10, null, new DateTime(2024, 1, 23, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 74, 12, 10 },
                    { 11, null, new DateTime(2024, 1, 22, 12, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 71, 12, 10 },
                    { 12, null, new DateTime(2024, 1, 22, 11, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 60, 12, 10 },
                    { 13, null, new DateTime(2024, 1, 21, 16, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 69, 12, 10 },
                    { 14, null, new DateTime(2024, 1, 20, 16, 0, 34, 0, DateTimeKind.Unspecified), null, null, null, 1, null, 15, 70, 12, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_MedRDailies_PatientId",
                table: "MedRDailies",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PrescriptionId",
                table: "Patients",
                column: "PrescriptionId",
                unique: true,
                filter: "[PrescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "MedicalReports");

            migrationBuilder.DropTable(
                name: "MedRDailies");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Prescriptions");
        }
    }
}
