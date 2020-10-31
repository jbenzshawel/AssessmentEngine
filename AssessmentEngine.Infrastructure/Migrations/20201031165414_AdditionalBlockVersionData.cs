using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AdditionalBlockVersionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BlockEndDateTime",
                table: "BlockVersions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BlockStartDateTime",
                table: "BlockVersions",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockEndDateTime",
                table: "BlockVersions");

            migrationBuilder.DropColumn(
                name: "BlockStartDateTime",
                table: "BlockVersions");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "b055604f-fa42-4b3a-9aca-e4d6ba38ecac");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "2df44374-4b2a-45fa-9277-5773bf7a78a4");
        }
    }
}
