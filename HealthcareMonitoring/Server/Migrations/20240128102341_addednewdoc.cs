using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthcareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class addednewdoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1237fc0e-f546-4942-914b-e068b40e9e5b", "AQAAAAIAAYagAAAAEL4Q/6BeU9WbjcGJEzGTSoxePT03azFdF4zY7HfttgCCtg9ImiJCpk+dWmLU9P/c0Q==", "277add60-dc45-40ab-bd6a-3c5712fcfc75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cb23e0a-d05b-47a2-8ac2-f62dd232638a", "AQAAAAIAAYagAAAAEO4rlkUqhJn6Wj8JuDA5+gQLyejBNqnGO6wYsJnuQFBBngkrnwfm+96rjeioZWtzow==", "4d6e7ad9-0a0a-4eee-8a58-e3fe0cc5d2c3" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DoctorAvailavleTime", "DoctorSpecialization" },
                values: new object[] { new DateTime(2024, 1, 28, 18, 23, 41, 600, DateTimeKind.Local).AddTicks(5996), "Cardiologist" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateDeleted", "DateUpdated", "DeletedBy", "DoctorAvailavleTime", "DoctorExperience", "DoctorIntroduction", "DoctorLocation", "DoctorName", "DoctorNationality", "DoctorPhoneNumber", "DoctorSpecialization", "Email", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 3, null, null, null, null, null, new DateTime(2024, 1, 28, 18, 23, 41, 600, DateTimeKind.Local).AddTicks(6012), 5, "张三", "黑龙江", "王六", "中国", 87688321, "Orthopedist", "doc@doc.com", null, null },
                    { 4, null, null, null, null, null, new DateTime(2024, 1, 28, 18, 23, 41, 600, DateTimeKind.Local).AddTicks(6014), 10, "张三", "温州", "胡涵博", "中国", 12376543, "General", "doc@doc.com", null, null },
                    { 5, null, null, null, null, null, new DateTime(2024, 1, 28, 18, 23, 41, 600, DateTimeKind.Local).AddTicks(6010), 4, "张三", "上海", "李四", "中国", 87654321, "Pulmonologist", "doc@doc.com", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 28, 18, 23, 41, 600, DateTimeKind.Local).AddTicks(6872));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea4d7c0-3fb0-4921-aca0-769173e0e959", "AQAAAAIAAYagAAAAEDLViBxKCh3MVcUoA59V1mXxhGjpLSFExuOoPUoLyE+5AhMWKtPzcNoTMNNBYEMOUw==", "2adb38dd-2b72-4b67-aecd-f54faedd1036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693e710c-008f-435b-a997-77f10812374d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99052403-1ceb-4efb-b137-3eda4884b260", "AQAAAAIAAYagAAAAEGb6fhhfFVlOXE3SEvTt1Mv2UzTVLy4ggwVXMH3oS2m+nEZr8MHU6gvVnT0abU71mg==", "4375bcd7-95ee-4f86-aaf6-69a63581c449" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DoctorAvailavleTime", "DoctorSpecialization" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 17, 27, 107, DateTimeKind.Local).AddTicks(1049), "心脏病" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2024, 1, 28, 16, 17, 27, 107, DateTimeKind.Local).AddTicks(2092));
        }
    }
}
