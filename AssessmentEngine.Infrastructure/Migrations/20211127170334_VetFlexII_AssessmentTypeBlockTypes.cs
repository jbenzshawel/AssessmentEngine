using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class VetFlexII_AssessmentTypeBlockTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AssessmentTypeBlockTypes",
                columns: new[] { "AssessmentTypeId", "BlockTypeId", "SortOrder" },
                values: new object[,]
                {
                    { 3, 1, 1 },
                    { 3, 2, 2 },
                    { 3, 3, 3 },
                    { 3, 4, 4 },
                    { 3, 5, 5 },
                    { 3, 6, 6 },
                    { 3, 7, 7 },
                    { 3, 8, 8 },
                    { 3, 9, 9 },
                    { 3, 10, 10 },
                    { 3, 11, 11 },
                    { 3, 12, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AssessmentTypeBlockTypes",
                keyColumns: new[] { "AssessmentTypeId", "BlockTypeId" },
                keyValues: new object[] { 3, 12 });
        }
    }
}
