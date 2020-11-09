using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "4667977b-6282-4c0c-a428-f9fbc0ac0ae4");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "c32513a1-7535-40c7-b215-20379fb3ecc8");

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParticipantId", "ParticipantTypeId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"), 0, "dbd73ece-9ffc-4d48-b214-5d151d7a4dfa", "vetflex@tc.columbia.edu", false, false, null, "VETFLEX@TC.COLUMBIA.EDU", "VETFLEX@TC.COLUMBIA.EDU", null, null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "3GZIA7EYTIPDD6PE2LUY4XNAMVQ3D3BG", false, "vetflex@tc.columbia.edu" });

            migrationBuilder.InsertData(
                table: "ApplicationUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"), new Guid("5d587953-2fb4-4198-9a5d-e64095439783") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"), new Guid("5d587953-2fb4-4198-9a5d-e64095439783") });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4c0ddd2-86e7-4193-9da2-9950abdb909c"));

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "5f3efa52-f164-4b3f-84d5-5852655af22e");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "e1926634-c164-4d70-b739-3a4b49ea2dcc");
        }
    }
}
