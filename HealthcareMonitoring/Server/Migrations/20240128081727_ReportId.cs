using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReportId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Report",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "MedicalReports");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea4d7c0-3fb0-4921-aca0-769173e0e959", "AQAAAAIAAYagAAAAEDLViBxKCh3MVcUoA59V1mXxhGjpLSFExuOoPUoLyE+5AhMWKtPzcNoTMNNBYEMOUw==", "2adb38dd-2b72-4b67-aecd-f54faedd1036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99052403-1ceb-4efb-b137-3eda4884b260", "AQAAAAIAAYagAAAAEGb6fhhfFVlOXE3SEvTt1Mv2UzTVLy4ggwVXMH3oS2m+nEZr8MHU6gvVnT0abU71mg==", "4375bcd7-95ee-4f86-aaf6-69a63581c449" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 16, 17, 27, 107, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "ReportId" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 17, 27, 107, DateTimeKind.Local).AddTicks(2092), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Report",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MedicalReports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51832572-dd6e-4f49-80e8-c1b031c1d838", "AQAAAAIAAYagAAAAEF6F9iIMF6XsIg0Oa94RMXjAadyc0rVl9wo/OWsQPsah4V3LDscDFR9AhVvD9zDKBw==", "7bfa3e9f-a8e1-444d-9a32-763f61a09ade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8016c95d-1cc3-46e2-a804-709f5898a294", "AQAAAAIAAYagAAAAEBhxhB3ihibZ/wD6U5NnFargYCODRSZd3nSBhVaJc2ex6dsS0ZR3W9veXeBvMpuBTQ==", "dc6874de-b0e8-4351-afbf-f3455cb36dae" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 15, 57, 12, 149, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "MedicalReports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "MedicalReports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "Report" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 57, 12, 149, DateTimeKind.Local).AddTicks(7157), null });
        }
    }
}
