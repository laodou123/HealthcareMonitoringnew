using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class Prescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_MedicalReports_MedicalReportId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalReportId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "prescriptions");

            migrationBuilder.RenameColumn(
                name: "MedicalReportId",
                table: "Patients",
                newName: "PrescriptionId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fe8fcd-1f06-482d-b3a2-8ef2977a751b", "AQAAAAIAAYagAAAAEP0AAOlwmrVBX6dG8HE0Tn51elY43L47tfv1g5Vz25ppbAfjStAg879clY1dUz+Eyg==", "d2202024-a366-4198-b141-2908ebab8bff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07715c01-2765-401f-bbe6-b32a1886ce72", "AQAAAAIAAYagAAAAEPt1KoFjZ7QhCAvjXtyekzFjAwSDmcr5uNOUmp/HqcjNdtKNi4hkpG5Ub6cCmTNNiw==", "9a97b83b-389c-48c6-bac4-2210895462ae" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 7, 30, 583, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 7, 30, 583, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 7, 30, 583, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 7, 30, 583, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 29, 10, 7, 30, 583, DateTimeKind.Local).AddTicks(7546));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrescriptionId",
                table: "Patients",
                newName: "MedicalReportId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "prescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1340b56a-7331-4749-8229-430f9cee892c", "AQAAAAIAAYagAAAAEBghZrSwdqRLUa9duv0dAxieY3oXQbijEJdU6ftLovX+NusR+X6M0p6B5iolklHawA==", "9cb21b78-b295-4e43-b502-4cd78195c708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f66e41e5-1293-428c-b7d0-d0a6af14bd55", "AQAAAAIAAYagAAAAECBl91NqzELt7uNGc585WGGq5pACZQ+y1I8GRy5wQfPMnrXsthyXG2wZxUVEitThYw==", "4b9e3d53-e0f8-48e5-9db7-41d841bce856" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 22, 31, 11, 626, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 22, 31, 11, 626, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 22, 31, 11, 626, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 28, 22, 31, 11, 626, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 28, 22, 31, 11, 627, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: null);

            migrationBuilder.UpdateData(
                table: "prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalReportId",
                table: "Patients",
                column: "MedicalReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_MedicalReports_MedicalReportId",
                table: "Patients",
                column: "MedicalReportId",
                principalTable: "MedicalReports",
                principalColumn: "Id");
        }
    }
}
