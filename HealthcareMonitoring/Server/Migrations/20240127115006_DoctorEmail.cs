using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class DoctorEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd5a48d5-730e-4041-908e-5b501ebbb024", "AQAAAAIAAYagAAAAEJzL+q7qJmh+k3L4mG8y5jLZGeR2QNbAzESKKmyUMnUoGqGrIv9be/r/odJtIlLeww==", "00cf42af-9f67-480d-9482-aa05d66f6a52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd9857c6-5db8-43c1-8ec4-9ccb2cd9f482", "AQAAAAIAAYagAAAAEHlPmRH1PSjOlmP4Mc6y0dp5POtnqe6eUkh1zl5TfK1sk2MaFjwDtySFRcj5xQU2zQ==", "373bfe77-ab0f-409e-9665-4f621755d1c8" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DoctorAvailavleTime", "Email" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 50, 6, 572, DateTimeKind.Local).AddTicks(5602), null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 27, 19, 50, 6, 572, DateTimeKind.Local).AddTicks(6686));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60c061c2-6285-4a17-80c9-411899e2fb51", "AQAAAAIAAYagAAAAEEBDvUCwDVcWJb1Zk+jx1trdl11rbS2dHKR2oigUaw0TVBGTPdtjJqb+fux/aiiwMQ==", "c0ba7356-c529-4f0e-aa03-8cd36594f1f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ca2a2d9-56bc-495b-aa40-cd993281c136", "AQAAAAIAAYagAAAAELErjH8J7qHj2OD7uIPp/JK3Tt3JNcx2WtvGDUPEGB3cNbgVuD/73Q9h1/NNEeZmag==", "a282b7d5-3fc3-4a57-b5e6-fe6991c53080" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 27, 18, 36, 5, 604, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 27, 18, 36, 5, 604, DateTimeKind.Local).AddTicks(9741));
        }
    }
}
