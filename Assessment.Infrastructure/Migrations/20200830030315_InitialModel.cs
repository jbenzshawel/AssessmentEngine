using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assessment.Infrastructure.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentTypes",
                columns: table => new
                {
                    AssessmentTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssessmentTypeUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTypes", x => x.AssessmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    AssessmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssessmentUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    AssessmentTypeId = table.Column<int>(nullable: false),
                    AssessmentUserUID = table.Column<Guid>(nullable: false),
                    StartedDate = table.Column<DateTime>(nullable: false),
                    CompletedDate = table.Column<DateTime>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "FK_Assessments_AssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AssessmentTypes",
                        principalColumn: "AssessmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d587953-2fb4-4198-9a5d-e64095439783", "d90a057f-c0a6-4e91-a339-5e24dc6f80f3", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8105d5f-3a2e-428b-8c57-36398b196379", "1775a847-259c-4f15-9824-4f7bff4e1f8b", "Participant", "PARTICIPANT" });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 8, 29, 22, 3, 14, 931, DateTimeKind.Local).AddTicks(7350), "DualNBack", new Guid("4d173181-8396-43a9-a325-3a754f33bc22"), new DateTime(2020, 8, 29, 22, 3, 14, 952, DateTimeKind.Local).AddTicks(880), null });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 8, 29, 22, 3, 14, 952, DateTimeKind.Local).AddTicks(1840), "EFT", new Guid("b7d30790-0a1b-4583-a08f-948c7f3d5325"), new DateTime(2020, 8, 29, 22, 3, 14, 952, DateTimeKind.Local).AddTicks(1860), null });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessmentTypeId",
                table: "Assessments",
                column: "AssessmentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d587953-2fb4-4198-9a5d-e64095439783");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8105d5f-3a2e-428b-8c57-36398b196379");
        }
    }
}
