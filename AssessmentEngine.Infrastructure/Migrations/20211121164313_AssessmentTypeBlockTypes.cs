using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AssessmentTypeBlockTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentTypeBlockTypes",
                columns: table => new
                {
                    AssessmentTypeId = table.Column<int>(type: "integer", nullable: false),
                    BlockTypeId = table.Column<int>(type: "integer", nullable: false),
                    SortOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTypeBlockTypes", x => new { x.AssessmentTypeId, x.BlockTypeId });
                    table.ForeignKey(
                        name: "FK_AssessmentTypeBlockTypes_AssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AssessmentTypes",
                        principalColumn: "AssessmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentTypeBlockTypes_BlockTypes_BlockTypeId",
                        column: x => x.BlockTypeId,
                        principalTable: "BlockTypes",
                        principalColumn: "BlockTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "0c04b308-160b-4bfa-8ac7-431ff3ec1675");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "8fd51b8e-fdf3-4250-8bfb-59f42aefd6b8");

            migrationBuilder.InsertData(
                table: "AssessmentTypeBlockTypes",
                columns: new[] { "AssessmentTypeId", "BlockTypeId", "SortOrder" },
                values: new object[,]
                {
                    { 4, 11, 6 },
                    { 4, 9, 5 },
                    { 4, 7, 4 },
                    { 4, 5, 3 },
                    { 4, 3, 2 },
                    { 4, 1, 1 },
                    { 2, 12, 12 },
                    { 2, 11, 11 },
                    { 2, 10, 10 },
                    { 2, 8, 8 },
                    { 2, 7, 7 },
                    { 2, 6, 6 },
                    { 2, 5, 5 },
                    { 2, 4, 4 },
                    { 2, 3, 3 },
                    { 2, 2, 2 },
                    { 2, 9, 9 },
                    { 2, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentTypeBlockTypes_BlockTypeId",
                table: "AssessmentTypeBlockTypes",
                column: "BlockTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentTypeBlockTypes");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "199547d9-3ae6-4fea-b40b-3c7644a8c4ac");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "5e65c82d-e288-4b19-9e18-c59b65230c19");
        }
    }
}
