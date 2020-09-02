using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class EFTModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParticipantId",
                table: "ApplicationUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationUserAuditTypes",
                columns: table => new
                {
                    ApplicationUserAuditTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApplicationUserAuditTypeUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserAuditTypes", x => x.ApplicationUserAuditTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentParticipants",
                columns: table => new
                {
                    AssessmentParticipantId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssessmentParticipantUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    AssessmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentParticipants", x => x.AssessmentParticipantId);
                    table.ForeignKey(
                        name: "FK_AssessmentParticipants_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentParticipants_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlockTypes",
                columns: table => new
                {
                    BlockTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlockTypeUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockTypes", x => x.BlockTypeId);
                });

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

            migrationBuilder.CreateTable(
                name: "AssessmentBlocks",
                columns: table => new
                {
                    AssessmentBlockId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssessmentBlockUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    AssessmentId = table.Column<int>(nullable: false),
                    BlockTypeId = table.Column<int>(nullable: false),
                    SeriesRecall = table.Column<string>(nullable: true),
                    CompletedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentBlocks", x => x.AssessmentBlockId);
                    table.ForeignKey(
                        name: "FK_AssessmentBlocks_Assessments_BlockTypeId",
                        column: x => x.BlockTypeId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentBlocks_BlockTypes_BlockTypeId",
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
                value: "48bade3b-538c-486c-9ad7-8ce2e3edcc8e");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "780e92dc-cd73-476e-85ca-790184d00e67");

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 1, 20, 29, 12, 949, DateTimeKind.Local).AddTicks(6530), "Login", new Guid("136bd2e8-728d-4ea1-a15e-7b84c7580035"), new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(4150), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5470), "Logout", new Guid("6105c471-fe81-4a48-aa61-62aa7007476c"), new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5490), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5510), "Lockout", new Guid("3759b364-a2f9-4bb7-842a-123f39015e09"), new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5510), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5530), "PasswordReset", new Guid("5ebb007f-3011-4be7-889a-cd94cfa987e1"), new DateTime(2020, 9, 1, 20, 29, 12, 968, DateTimeKind.Local).AddTicks(5530), null });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 20, 29, 12, 986, DateTimeKind.Local).AddTicks(3650), new Guid("36af8030-c4f8-4f86-b049-9907cd66b977"), new DateTime(2020, 9, 1, 20, 29, 12, 986, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 20, 29, 12, 986, DateTimeKind.Local).AddTicks(3850), new Guid("3eda48f5-0c74-4cb2-afab-6ab6acca434c"), new DateTime(2020, 9, 1, 20, 29, 12, 986, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(170), "E1", new Guid("4ca4e266-1b38-453c-a49c-fb6131717745"), new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(200), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(360), "S1", new Guid("6dc7b06c-45a8-4ebd-9ccd-aa747c628445"), new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(370), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(390), "E2", new Guid("6cefbfb7-ab35-4c17-a175-54be8a05ea4d"), new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(390), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(400), "S2", new Guid("0eaf7907-c6f9-482e-873d-7a200615e1b9"), new DateTime(2020, 9, 1, 20, 29, 12, 990, DateTimeKind.Local).AddTicks(410), null });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAudits_ApplicationUserAuditTypeId",
                table: "ApplicationUserAudits",
                column: "ApplicationUserAuditTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBlocks_BlockTypeId",
                table: "AssessmentBlocks",
                column: "BlockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentParticipants_ApplicationUserId",
                table: "AssessmentParticipants",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentParticipants_AssessmentId",
                table: "AssessmentParticipants",
                column: "AssessmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserAudits");

            migrationBuilder.DropTable(
                name: "AssessmentBlocks");

            migrationBuilder.DropTable(
                name: "AssessmentParticipants");

            migrationBuilder.DropTable(
                name: "ApplicationUserAuditTypes");

            migrationBuilder.DropTable(
                name: "BlockTypes");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "ApplicationUsers");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "ee43e1ac-c5d9-4aca-af2a-614feb8f7113");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "42c4b54f-2a90-4c03-8947-e35b1c3a6ddf");

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 30, 11, 12, 55, 918, DateTimeKind.Local).AddTicks(3500), new Guid("65aaf775-8017-4692-b675-5202a43921ae"), new DateTime(2020, 8, 30, 11, 12, 55, 937, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 8, 30, 11, 12, 55, 937, DateTimeKind.Local).AddTicks(7030), new Guid("c1e74233-fe5e-4578-bc54-b5f4fc388767"), new DateTime(2020, 8, 30, 11, 12, 55, 937, DateTimeKind.Local).AddTicks(7050) });
        }
    }
}
