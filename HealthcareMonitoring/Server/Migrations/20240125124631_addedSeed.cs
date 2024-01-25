using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_prescriptions_PrescriptionId",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Diagnosis",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "DiagnosisDate", "DiagnosisText", "DiagnosisTime", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, null, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "DoctorAvailavleTime", "DoctorExperience", "DoctorIntroduction", "DoctorName", "DoctorNationality", "DoctorPhoneNumber", "DoctorSpecialization", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, null, new DateTime(2024, 1, 25, 20, 46, 31, 102, DateTimeKind.Local).AddTicks(6486), 5, "张三", "张三", "中国", 123456789, "心脏病", null });

            migrationBuilder.InsertData(
                table: "MedicalReports",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "MedicalType", "PR_Interval", "P_wave", "QRS_Complex", "QT_Interval", "ST_Interval", "T_Wave", "UpdatedBy", "fev1", "fev1_fvc_ratio", "fvc", "hb", "hct", "heartRate", "lumarSpine", "pef", "plt", "rbc", "rhythm", "totalHip", "tscoreH", "tscoreL", "tv", "wbc" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "1", 1f, "1", 1f, 1f, 1f, "1", null, 1f, 1f, 1f, 1f, 1f, 1, 1f, 1f, 1f, 1f, "Test", 1f, 1f, 1f, 1f, 1f },
                    { 2, null, null, null, null, null, "Test", 10f, "Test", 10f, 10f, 10f, "Test", null, 10f, 10f, 10f, 10f, 10f, 10, 10f, 10f, 10f, 10f, "Test", 10f, 10f, 10f, 10f, 10f }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Age", "AllergyDes", "CreatedBy", "DOB", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "Gender", "LastName", "NRIC", "Name", "PhoneNumber", "PrescriptionId", "Report", "UpdatedBy" },
                values: new object[] { 1, "singapore", null, "seafood", null, new DateTime(2024, 1, 25, 20, 46, 31, 102, DateTimeKind.Local).AddTicks(7238), null, null, null, null, "Male", "Tan", "S1234567G", "Jia Wei", 12345678, null, null, null });

            migrationBuilder.InsertData(
                table: "prescriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "MedicineDescription", "MedicineName", "MedicinePrescriptionDoctor", "MedicineQuantity", "MedicineUsage", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Test", "Test", "Test", 1, "Test", null },
                    { 2, null, null, null, null, null, "Test", "Test", "Test", 1, "Test", null }
                });

            migrationBuilder.InsertData(
                table: "medRDailies",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "PatientId", "UpdatedBy", "bloodSugarLevel", "bpm", "diastolicPressure", "systolicPressure" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, 1, null, 1, 1, 1, 1 },
                    { 2, null, null, null, null, null, 1, null, 15, 5, 12, 10 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_prescriptions_PrescriptionId",
                table: "Patients",
                column: "PrescriptionId",
                principalTable: "prescriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_prescriptions_PrescriptionId",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "Diagnosis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalReports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicalReports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "medRDailies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medRDailies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "prescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "prescriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_prescriptions_PrescriptionId",
                table: "Patients",
                column: "PrescriptionId",
                principalTable: "prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
