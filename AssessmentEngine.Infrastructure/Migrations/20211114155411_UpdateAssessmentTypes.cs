using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateAssessmentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1);


            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                column: "SortOrder",
                value: 1);

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "Name", "SortOrder", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, null, "VetFlexII", 2, null },
                    { 4, null, "VetFlexIII", 3, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                column: "SortOrder",
                value: 2);

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "Name", "SortOrder", "UpdatedBy" },
                values: new object[] { 1, null, "DualNBack", 1, null });
        }
    }
}
