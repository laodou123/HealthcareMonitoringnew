using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class newnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Doctor", "DOCTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68f4dd27-bc79-4b55-8e5f-044b544a7350", "AQAAAAIAAYagAAAAED6HeLnKsuVBVrntcIH7n0J6RR6zE6Akly0efQKbAI+/igcBL1OYHKHurQOH9MMJzQ==", "9254ee94-7e09-4018-adbd-842f34d2c0fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d32b32-35dd-4a51-aba2-638c76779df5", "AQAAAAIAAYagAAAAEM8otXjPRDsGc8WE4ZLjJyUq/2KDHMqMAhKZ1pEa2JB+9XVwK6lQrQCvAzx6VhgSnw==", "526ea277-f960-47a4-93c8-d2f8275a7314" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 26, 1, 17, 5, 312, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 26, 1, 17, 5, 312, DateTimeKind.Local).AddTicks(3654));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "157c6643-6beb-4cb7-acf0-d9e0b0089213", "AQAAAAIAAYagAAAAEF50YlN0zPo/PcYCHSTOOOCG0JuRio6OLf2Gpqn3F189Xmvr/5USxVlN2L/0sutAXA==", "d0312901-2129-40f1-838b-206ec7c81b7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6bee0fb-2f62-4ce1-80c4-1db63ae3c1c5", "AQAAAAIAAYagAAAAEHlqy+9ull4NKTtnukQCeDMOs3VKbf0vWgVyMEnSbHnXzwpzm+LUgyeAhs76UCapXw==", "e14c9b5b-caf2-40b6-a589-ea533a92093a" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 26, 0, 58, 52, 374, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 26, 0, 58, 52, 374, DateTimeKind.Local).AddTicks(4160));
        }
    }
}
