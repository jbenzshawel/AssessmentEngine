using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AddSortOrderToTaskVersionGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "TaskVersionGroupBlocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TaskVersionGroupBlocks_TaskVersionGroupId",
                table: "TaskVersionGroupBlocks",
                column: "TaskVersionGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskVersionGroupBlocks_TaskVersionGroups_TaskVersionGroupId",
                table: "TaskVersionGroupBlocks",
                column: "TaskVersionGroupId",
                principalTable: "TaskVersionGroups",
                principalColumn: "TaskVersionGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskVersionGroupBlocks_TaskVersionGroups_TaskVersionGroupId",
                table: "TaskVersionGroupBlocks");

            migrationBuilder.DropIndex(
                name: "IX_TaskVersionGroupBlocks_TaskVersionGroupId",
                table: "TaskVersionGroupBlocks");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "TaskVersionGroupBlocks");
        }
    }
}
