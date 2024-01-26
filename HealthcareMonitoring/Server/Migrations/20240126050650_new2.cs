using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9710e240-91f2-4b2d-96c8-630d684b7d96", "AQAAAAIAAYagAAAAEM9m0j62T5sCiM/aQ6gBBl9bBypy6SSA39sZujpgMqoA//Skjmx5X+9UXiwNG3liZg==", "19d26c6d-f243-4d53-854a-8afb768035d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3c23928-908e-45ea-931f-5a11a15fa2cd", "AQAAAAIAAYagAAAAEDHj9TmjNJA7NLVCIM1oQ/XS16EyE17I3BmBuTOup9lnZNx//U/eausMHlnkijfRAw==", "40cd4ef8-2549-4c3b-b83b-e009e7fa1754" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 26, 13, 6, 49, 902, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 26, 13, 6, 49, 902, DateTimeKind.Local).AddTicks(2147));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cbf2c17-5248-4632-b703-4bea16d9a0c6", "AQAAAAIAAYagAAAAEJtd0QkFkLq/3moRuPh7fCzqnKn+uqnlm+ijgc9CXdlFQWXBjCaO12y/U/rxD3ce5A==", "e01c7047-69af-41ab-8680-c5d35edb9803" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33b397a-29a0-46db-b197-3b01e00928fe", "AQAAAAIAAYagAAAAECDY+DoELRhSeo0Pt2ZqrXzfv7uIjNDAAhLHaFaNAZdxxF4vOKuy20+xDPGjoVwqzw==", "c16f33eb-0802-4b67-b183-759c033e57b9" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 26, 13, 5, 49, 381, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 26, 13, 5, 49, 381, DateTimeKind.Local).AddTicks(3479));
        }
    }
}
