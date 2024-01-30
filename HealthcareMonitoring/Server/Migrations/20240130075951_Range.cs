using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class Range : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DoctorAvailavleTime",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b70b1c98-0025-49e9-b459-2c7831469537", "AQAAAAIAAYagAAAAEOkb0OXWBXu2ocVQA1CjYqFRqDKXZlBy7RZeYjgaoGb12ZF7pn+QO0F7YckOoseJUQ==", "3e40256c-3b38-489d-a4c5-c1c99b60f153" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed5362ce-baec-4d18-a707-16edd92e5d04", "AQAAAAIAAYagAAAAEDDL42nFBS2rrVTiZqUPKM9dH7oshhDMKGsj2vz5G0q9apMkr666oO6KNPQ3be49PQ==", "7db04a56-878b-44c8-b9f6-163d722ae9fb" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: "2024-01-29|2024-01-30");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: "2024-01-29|2024-01-30");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: "2024-01-29|2024-01-30");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: "2024-01-29|2024-01-30");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 30, 15, 59, 51, 28, DateTimeKind.Local).AddTicks(6834));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DoctorAvailavleTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d5ed614-a98b-46ea-af45-91906cbc84a1", "AQAAAAIAAYagAAAAEJ29WJDjtDp+ZAsM4mxmZEdxdjttMLiyDedvY0YCyKfsUtBR13dPnh54jcMPk0ZEeg==", "864acb5b-2e60-4204-84b2-8f5de68177a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "387eef40-b000-42a8-9180-0dadbbeb58a1", "AQAAAAIAAYagAAAAEPAFvaYsps6qC6fN+sgwjtA2Jo4lGiZ8aoVlfiNjpKrjYq5cLMlVBKsBET4e5H0OPw==", "0263e752-180b-4ff2-bcdd-ec8238fb174e" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 13, 20, 15, 21, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 13, 20, 15, 21, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 13, 20, 15, 21, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 29, 13, 20, 15, 21, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 29, 13, 20, 15, 21, DateTimeKind.Local).AddTicks(9658));
        }
    }
}
