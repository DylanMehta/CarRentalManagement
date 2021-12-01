using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "2b993e2f-9339-476a-83c3-0f5d069ad256", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2c23cd1c-c702-415d-89ac-8be1d513ac47", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5c29f60b-8ca5-4492-a13b-99bf5f5bdbd3", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEFCkJA3zGZt5KOi1XcnlLpXpzP+G6gUr3hXJyGn1b98Ms4y7ExCuGQBDYA8idAgytA==", null, false, "42ef1974-80df-4681-ba44-071f30a2d3b0", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 1, 17, 58, 17, 620, DateTimeKind.Local).AddTicks(8958), new DateTime(2021, 12, 1, 17, 58, 17, 622, DateTimeKind.Local).AddTicks(609), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 1, 17, 58, 17, 622, DateTimeKind.Local).AddTicks(1955), new DateTime(2021, 12, 1, 17, 58, 17, 622, DateTimeKind.Local).AddTicks(1963), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 1, 17, 58, 17, 623, DateTimeKind.Local).AddTicks(7643), new DateTime(2021, 12, 1, 17, 58, 17, 623, DateTimeKind.Local).AddTicks(7655), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 1, 17, 58, 17, 623, DateTimeKind.Local).AddTicks(7660), new DateTime(2021, 12, 1, 17, 58, 17, 623, DateTimeKind.Local).AddTicks(7661), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2599), new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2609), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2614), new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2616), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2618), new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2619), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2621), new DateTime(2021, 12, 1, 17, 58, 17, 624, DateTimeKind.Local).AddTicks(2623), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
