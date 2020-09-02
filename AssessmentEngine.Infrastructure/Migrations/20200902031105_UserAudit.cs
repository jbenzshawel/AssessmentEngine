using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UserAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ApplicationUserAudits");
            
            migrationBuilder.CreateTable(
                name: "ApplicationUserAudits",
                columns: table => new
                {
                    ApplicationUserAuditId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApplicationUserAuditUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserAuditTypeId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<Guid>(nullable: false, defaultValue:  new Guid("00000000-0000-0000-0000-000000000000"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserAudits", x => x.ApplicationUserAuditId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserAudits_ApplicationUserAuditTypes_ApplicationUserAuditTypeId",
                        column: x => x.ApplicationUserAuditTypeId,
                        principalTable: "ApplicationUserAuditTypes",
                        principalColumn: "ApplicationUserAuditTypeId",
                        onDelete: ReferentialAction.Cascade);
                    
                    table.ForeignKey(
                        name: "FK_ApplicationUserAudits_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAudits_ApplicationUserId",
                table: "ApplicationUserAudits",
                column: "ApplicationUserId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("ApplicationUserAudits");
            
            migrationBuilder.CreateTable(
                name: "ApplicationUserAudits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserAuditTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserAudits_ApplicationUserAuditTypes_ApplicationUserAuditTypeId",
                        column: x => x.ApplicationUserAuditTypeId,
                        principalTable: "ApplicationUserAuditTypes",
                        principalColumn: "ApplicationUserAuditTypeId",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
