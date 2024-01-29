using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class _2024012901 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "984551a3-8446-4733-b10b-618459ef1926", "AQAAAAIAAYagAAAAEIJs5y/npC3Wh/VYL+l5IeYlgx9PVqgDpDkBBmH38lxN0QjwuSgNn1kak7/XnIJkPQ==", "218a4a9b-a5d6-4e05-86ca-94e24fa60726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "768e0ee0-f14c-42a4-9675-3e3c5d54e4cc", "AQAAAAIAAYagAAAAEFjqHzRIVBRrDWZTcUd2fgyxV5ZKfnWKEyFJRQB366wvk/fa/6l4NUcK697EQI91SA==", "171fa61d-a6c3-49ce-bc27-8173fb9dd0dd" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 51, 15, 998, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 51, 15, 998, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 51, 15, 998, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 51, 15, 998, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 29, 10, 51, 15, 998, DateTimeKind.Local).AddTicks(4816));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
