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
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserAuditTypes", x => x.ApplicationUserAuditTypeId);
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
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
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
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockTypes", x => x.BlockTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantTypes",
                columns: table => new
                {
                    ParticipantTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParticipantTypeUid = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantTypes", x => x.ParticipantTypeId);
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
                    AssessmentTypeId = table.Column<int>(nullable: false),
                    ImageViewingTime = table.Column<int>(nullable: true),
                    CognitiveLoadViewingTime = table.Column<int>(nullable: true),
                    BlankScreenViewingTime = table.Column<int>(nullable: true)
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
                    ParticipantId = table.Column<string>(nullable: true),
                    ParticipantTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_ParticipantTypes_ParticipantTypeId",
                        column: x => x.ParticipantTypeId,
                        principalTable: "ParticipantTypes",
                        principalColumn: "ParticipantTypeId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "BlockVersions",
                columns: table => new
                {
                    BlockVersionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlockVersionUid = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_BlockVersions", x => x.BlockVersionId);
                    table.ForeignKey(
                        name: "FK_BlockVersions_AssessmentVersions_AssessmentVersionId",
                        column: x => x.AssessmentVersionId,
                        principalTable: "AssessmentVersions",
                        principalColumn: "AssessmentVersionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlockVersions_BlockTypes_BlockTypeId",
                        column: x => x.BlockTypeId,
                        principalTable: "BlockTypes",
                        principalColumn: "BlockTypeId",
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
                values: new object[] { new Guid("5d587953-2fb4-4198-9a5d-e64095439783"), "739c6328-036b-456a-9f7d-bb1337f40547", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "ApplicationRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"), "8ec8c68b-d513-4bcf-b8b2-ef294b846f8c", "Participant", "PARTICIPANT" });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 13, 19, 35, 58, 570, DateTimeKind.Local).AddTicks(7280), "Login", 1, new Guid("917d74e0-b67a-47a3-bbce-d9c1c3e0009e"), new DateTime(2020, 9, 13, 19, 35, 58, 590, DateTimeKind.Local).AddTicks(7940), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(40), "Logout", 2, new Guid("611194e9-eacf-4b0b-ab55-1c14f84afbe2"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(80), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(290), "Lockout", 3, new Guid("30fb0bb1-c7c1-4478-8e29-d32cba833623"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(290), null });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(310), "PasswordReset", 4, new Guid("b3a3b5df-8eb9-42cd-8d14-45f1a1e0dcdc"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(320), null });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParticipantId", "ParticipantTypeId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), 0, "66046443-f6a0-4c4a-beed-902dc49f1903", "admin@assessment.com", false, false, null, "ADMIN@ASSESSMENT.COM", "ADMIN@ASSESSMENT.COM", null, null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF", false, "admin@assessment.com" });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2390), "DualNBack", 1, new Guid("0722c572-07bc-4f52-9a1a-22e4686e0312"), new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2420), null });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2800), "EFT", 2, new Guid("b6739a36-513e-4d2e-8c6f-fd61a1c67fd9"), new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2810), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 13, 19, 35, 58, 626, DateTimeKind.Local).AddTicks(9670), "E1", 1, new Guid("67570617-0f6c-4034-9f23-1d52e25fd432"), new DateTime(2020, 9, 13, 19, 35, 58, 626, DateTimeKind.Local).AddTicks(9700), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(150), "S1", 2, new Guid("1bf4f5dd-a37d-44f3-9ced-1a2309923f27"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(160), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 3, null, new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(190), "E2", 3, new Guid("f975426e-eb90-4b74-a99c-8ff9d7bd4e3c"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(190), null });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 4, null, new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(200), "S2", 4, new Guid("5305701a-8b1e-44c5-a012-2f6dccff9408"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(210), null });

            migrationBuilder.InsertData(
                table: "ParticipantTypes",
                columns: new[] { "ParticipantTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ParticipantTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(5590), "Civilian", 1, new Guid("5cf6d306-fe2e-4c3d-9266-768c5af651e4"), new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(5630), null });

            migrationBuilder.InsertData(
                table: "ParticipantTypes",
                columns: new[] { "ParticipantTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ParticipantTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[] { 2, null, new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(6070), "Veteran", 2, new Guid("4c65859c-880b-475c-958e-5aac72d3ecfd"), new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(6080), null });

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
                name: "IX_ApplicationUsers_ParticipantTypeId",
                table: "ApplicationUsers",
                column: "ParticipantTypeId");

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
                name: "IX_BlockVersions_AssessmentVersionId",
                table: "BlockVersions",
                column: "AssessmentVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockVersions_BlockTypeId",
                table: "BlockVersions",
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
                name: "BlockVersions");

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
                name: "ParticipantTypes");

            migrationBuilder.DropTable(
                name: "AssessmentVersions");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");
        }
    }
}
