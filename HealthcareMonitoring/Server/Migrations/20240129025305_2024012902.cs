using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class _2024012902 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions");

            migrationBuilder.RenameTable(
                name: "prescriptions",
                newName: "Prescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4abd35-7a64-4228-a56a-d636942639ac", "AQAAAAIAAYagAAAAEKuW4IW6bxfLnPK3Qnwl3pOqltSRZWB01MSFmQw8zJS3t380B9rWWe/cwz66qwl71Q==", "b9d9c9d8-b54f-4f9a-a5d1-0a461dd3b361" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a05597c-806d-4271-9462-ddbc240b84a3", "AQAAAAIAAYagAAAAEBRN8ypo4caJ//n4pKRB3JSJqdl4ZoRbVd9s4Jfh15py0dickmpQtWe2lNze5rExlQ==", "85cf0fb3-2691-4b88-bbc2-7a392a367888" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 53, 5, 52, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 53, 5, 52, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 53, 5, 52, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 10, 53, 5, 52, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 29, 10, 53, 5, 52, DateTimeKind.Local).AddTicks(9336));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription");

            migrationBuilder.RenameTable(
                name: "Prescription",
                newName: "prescriptions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prescriptions",
                table: "prescriptions",
                column: "Id");

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
    }
}
