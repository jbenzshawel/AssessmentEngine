using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRoles", x => x.Id);
                });

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
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ParticipantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

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
                name: "ApplicationRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRoleClaims_ApplicationRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: false),
                    ApplicationUserAuditTypeId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ApplicationUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserClaims_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_ApplicationUserLogins_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRoles_ApplicationRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRoles_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTokens_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentVersions",
                columns: table => new
                {
                    AssessmentVersionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssessmentVersionUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    VersionName = table.Column<string>(nullable: true),
                    AssessmentTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentVersions", x => x.AssessmentVersionId);
                    table.ForeignKey(
                        name: "FK_AssessmentVersions_AssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AssessmentTypes",
                        principalColumn: "AssessmentTypeId",
                        onDelete: ReferentialAction.Cascade);
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
                    AssessmentVersionId = table.Column<int>(nullable: false),
                    StartedDate = table.Column<DateTime>(nullable: false),
                    CompletedDate = table.Column<DateTime>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "FK_Assessments_AssessmentVersions_AssessmentVersionId",
                        column: x => x.AssessmentVersionId,
                        principalTable: "AssessmentVersions",
                        principalColumn: "AssessmentVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlockVersion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CognitiveLoad = table.Column<bool>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    BlockTypeId = table.Column<int>(nullable: false),
                    AssessmentVersionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockVersion_AssessmentVersions_AssessmentVersionId",
                        column: x => x.AssessmentVersionId,
                        principalTable: "AssessmentVersions",
                        principalColumn: "AssessmentVersionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlockVersion_BlockTypes_BlockTypeId",
                        column: x => x.BlockTypeId,
                        principalTable: "BlockTypes",
                        principalColumn: "BlockTypeId",
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

            migrationBuilder.InsertData(
                table: "ApplicationRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("5d587953-2fb4-4198-9a5d-e64095439783"), "579cb547-2624-492e-ba71-7f2ab0870d2d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "ApplicationRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"), "07a2edf3-3da2-4e2a-82ce-0a557627ec90", "Participant", "PARTICIPANT" });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 4, 11, 16, 47, 867, DateTimeKind.Local).AddTicks(4030), "Login", new Guid("6fa9fe49-0067-400b-a424-7b5a6ff1062c"), new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(3230), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4610), "Logout", new Guid("4b258262-78c0-4935-8d62-f5235b9590e9"), new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4640), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4670), "Lockout", new Guid("7741e81d-6fd6-40a3-b502-8a479df8a594"), new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4680), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4690), "PasswordReset", new Guid("94d4a3a9-fe5a-4b8a-bc1b-e4dc1e704eaf"), new DateTime(2020, 9, 4, 11, 16, 47, 887, DateTimeKind.Local).AddTicks(4690), null });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParticipantId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), 0, "66046443-f6a0-4c4a-beed-902dc49f1903", "admin@assessment.com", false, false, null, "ADMIN@ASSESSMENT.COM", "ADMIN@ASSESSMENT.COM", null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF", false, "admin@assessment.com" });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 4, 11, 16, 47, 909, DateTimeKind.Local).AddTicks(1430), "DualNBack", new Guid("2c0f3166-c415-46f6-b411-55beb294f799"), new DateTime(2020, 9, 4, 11, 16, 47, 909, DateTimeKind.Local).AddTicks(1470), null });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 4, 11, 16, 47, 909, DateTimeKind.Local).AddTicks(1630), "EFT", new Guid("92384660-59db-4042-b371-b219a019a71c"), new DateTime(2020, 9, 4, 11, 16, 47, 909, DateTimeKind.Local).AddTicks(1640), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8620), "E1", new Guid("210da08c-5410-47f3-87fc-3eab371c0206"), new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8660), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8830), "S1", new Guid("30eb5956-8ae9-4f46-b504-7186e50b323b"), new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8830), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8850), "E2", new Guid("05c64d69-5640-430a-a697-6a367e595a5b"), new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8860), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8870), "S2", new Guid("f8ff6201-5859-4489-8c52-64d686c3e87a"), new DateTime(2020, 9, 4, 11, 16, 47, 912, DateTimeKind.Local).AddTicks(8870), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), new Guid("5d587953-2fb4-4198-9a5d-e64095439783") });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleClaims_RoleId",
                table: "ApplicationRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "ApplicationRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAudits_ApplicationUserAuditTypeId",
                table: "ApplicationUserAudits",
                column: "ApplicationUserAuditTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserAudits_ApplicationUserId",
                table: "ApplicationUserAudits",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserClaims_UserId",
                table: "ApplicationUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserLogins_UserId",
                table: "ApplicationUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRoles_RoleId",
                table: "ApplicationUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "ApplicationUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUsers",
                column: "NormalizedUserName",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_AssessmentVersionId",
                table: "Assessments",
                column: "AssessmentVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentVersions_AssessmentTypeId",
                table: "AssessmentVersions",
                column: "AssessmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockVersion_AssessmentVersionId",
                table: "BlockVersion",
                column: "AssessmentVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockVersion_BlockTypeId",
                table: "BlockVersion",
                column: "BlockTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRoleClaims");

            migrationBuilder.DropTable(
                name: "ApplicationUserAudits");

            migrationBuilder.DropTable(
                name: "ApplicationUserClaims");

            migrationBuilder.DropTable(
                name: "ApplicationUserLogins");

            migrationBuilder.DropTable(
                name: "ApplicationUserRoles");

            migrationBuilder.DropTable(
                name: "ApplicationUserTokens");

            migrationBuilder.DropTable(
                name: "AssessmentBlocks");

            migrationBuilder.DropTable(
                name: "AssessmentParticipants");

            migrationBuilder.DropTable(
                name: "BlockVersion");

            migrationBuilder.DropTable(
                name: "ApplicationUserAuditTypes");

            migrationBuilder.DropTable(
                name: "ApplicationRoles");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "BlockTypes");

            migrationBuilder.DropTable(
                name: "AssessmentVersions");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");
        }
    }
}
