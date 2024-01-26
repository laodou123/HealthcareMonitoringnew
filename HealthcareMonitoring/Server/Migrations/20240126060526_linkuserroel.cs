using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class linkuserroel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Doctors",
                newName: "userId");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d674af-7638-4c5c-a334-8bd3cfeb4937", "AQAAAAIAAYagAAAAEPi8ib/Z0tEDsqEK1XmCXCerYeEdFqvk+zeL3nxtFsUqDMQ/sv6g3Pl4g1X9LTwCPw==", "f1538568-7ef6-43f9-9fa0-673d6b854baa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14551428-bf1b-47be-959b-1577c952e36a", "AQAAAAIAAYagAAAAEOV8LWykMUrT/KtfKDo9RB0vUUd67q/y/fZ1SUNSepPnpVPJhI0WJJVpRyHATnQ6BA==", "c9ae1dce-7d13-48b9-bb3c-3b7816bf27a0" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DoctorAvailavleTime", "UserId" },
                values: new object[] { new DateTime(2024, 1, 26, 14, 5, 26, 92, DateTimeKind.Local).AddTicks(4221), null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "userId" },
                values: new object[] { new DateTime(2024, 1, 26, 14, 5, 26, 92, DateTimeKind.Local).AddTicks(5130), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Doctors",
                newName: "UserId");

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
    }
}
