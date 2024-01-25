using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class userrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "157c6643-6beb-4cb7-acf0-d9e0b0089213", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEF50YlN0zPo/PcYCHSTOOOCG0JuRio6OLf2Gpqn3F189Xmvr/5USxVlN2L/0sutAXA==", null, false, "d0312901-2129-40f1-838b-206ec7c81b7c", false, "admin@localhost.com" },
                    { "693e710c-008f-435b-a997-77f10812374d", 0, "d6bee0fb-2f62-4ce1-80c4-1db63ae3c1c5", "13858860788a@gmail.com", false, "Hu", "Yi", false, null, "13858860788A@GMAIL.COM", "13858860788A@GMAIL.COM", "AQAAAAIAAYagAAAAEHlqy+9ull4NKTtnukQCeDMOs3VKbf0vWgVyMEnSbHnXzwpzm+LUgyeAhs76UCapXw==", null, false, "e14c9b5b-caf2-40b6-a589-ea533a92093a", false, "13858860788a@gmail.com" }
                });

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
                columns: new[] { "DOB", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 58, 52, 374, DateTimeKind.Local).AddTicks(4160), "12345678" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "693e710c-008f-435b-a997-77f10812374d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "693e710c-008f-435b-a997-77f10812374d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DoctorAvailavleTime",
                value: new DateTime(2024, 1, 25, 20, 46, 31, 102, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 46, 31, 102, DateTimeKind.Local).AddTicks(7238), 12345678 });
        }
    }
}
