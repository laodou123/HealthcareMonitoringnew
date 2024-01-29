using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class _20240129 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54908386-1829-4b22-a791-0622948f635e", "AQAAAAIAAYagAAAAEJdTZBZma4dq2M0nBvC8lp06jbgpKdsf7vCCjTDhfZTatVt5kQ6PKeAZD3HCj/pBcA==", "0896a81c-7623-477a-ab62-50d5b33ba9c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8e0636-ca8a-4115-b6c6-0f5b84c529db", "AQAAAAIAAYagAAAAELkzwY6+s58HuCA+5OUNaJ1peda0IqsYytNRNs8hr6vcESrjOwEU0xidJpU+4KF6xQ==", "45a39068-c30a-40ee-bd98-b3584ffe9bd8" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 50, 12, 325, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 50, 12, 325, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 50, 12, 325, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 50, 12, 325, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 29, 10, 50, 12, 325, DateTimeKind.Local).AddTicks(4820));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
