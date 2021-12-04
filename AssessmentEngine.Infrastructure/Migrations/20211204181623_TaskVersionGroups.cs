using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class TaskVersionGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskVersionGroupBlocks",
                columns: table => new
                {
                    TaskVersionGroupBlockId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskVersionGroupId = table.Column<int>(type: "integer", nullable: false),
                    BlockTypeId = table.Column<int>(type: "integer", nullable: false),
                    TaskVersionGroupBlockUid = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskVersionGroupBlocks", x => x.TaskVersionGroupBlockId);
                    table.ForeignKey(
                        name: "FK_TaskVersionGroupBlocks_BlockTypes_BlockTypeId",
                        column: x => x.BlockTypeId,
                        principalTable: "BlockTypes",
                        principalColumn: "BlockTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskVersionGroups",
                columns: table => new
                {
                    TaskVersionGroupId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentTypeId = table.Column<int>(type: "integer", nullable: false),
                    TaskVersionName = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    TaskVersionGroupUid = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "text", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskVersionGroups", x => x.TaskVersionGroupId);
                    table.ForeignKey(
                        name: "FK_TaskVersionGroups_AssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AssessmentTypes",
                        principalColumn: "AssessmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskVersionGroupBlocks_BlockTypeId",
                table: "TaskVersionGroupBlocks",
                column: "BlockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskVersionGroups_AssessmentTypeId",
                table: "TaskVersionGroups",
                column: "AssessmentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskVersionGroupBlocks");

            migrationBuilder.DropTable(
                name: "TaskVersionGroups");
        }
    }
}
