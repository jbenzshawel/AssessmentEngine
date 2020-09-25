using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        name: "FK_ApplicationUserAudits_ApplicationUserAuditTypes_Application~",
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                values: new object[,]
                {
                    { new Guid("5d587953-2fb4-4198-9a5d-e64095439783"), "69073451-a310-4251-a242-a9f9d8e04d52", "Administrator", "ADMINISTRATOR" },
                    { new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"), "46d56cd4-25fd-4658-9066-c0c195950257", "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserAuditTypes",
                columns: new[] { "ApplicationUserAuditTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ApplicationUserAuditTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 24, 21, 39, 44, 870, DateTimeKind.Local).AddTicks(5680), "Login", 1, new Guid("75951dc2-87f9-4931-83cd-9e56142607b9"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(4000), null },
                    { 2, null, new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6380), "Logout", 2, new Guid("e7a68348-8242-422b-a54e-8a5689922d9c"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6420), null },
                    { 3, null, new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6680), "Lockout", 3, new Guid("b590f50c-f694-40b7-89e7-eb84f0268411"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6690), null },
                    { 4, null, new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6750), "PasswordReset", 4, new Guid("46a5779d-17c9-4ee5-8b8e-3d9d294fe08d"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6750), null }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "ParticipantId", "ParticipantTypeId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), 0, "66046443-f6a0-4c4a-beed-902dc49f1903", "admin@assessment.com", false, false, null, "ADMIN@ASSESSMENT.COM", "ADMIN@ASSESSMENT.COM", null, null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF", false, "admin@assessment.com" });

            migrationBuilder.InsertData(
                table: "AssessmentTypes",
                columns: new[] { "AssessmentTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "AssessmentTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(3430), "DualNBack", 1, new Guid("f6a5984f-0ef5-4725-9e77-668f87f8a771"), new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(3480), null },
                    { 2, null, new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(4170), "EFT", 2, new Guid("1a78a55f-2441-45b0-b9b7-5e33ff44956d"), new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(4180), null }
                });

            migrationBuilder.InsertData(
                table: "BlockTypes",
                columns: new[] { "BlockTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "BlockTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 12, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9700), "VN2", 12, new Guid("8a0f24d2-6704-4e97-9570-9c1b3f56f226"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9700), null },
                    { 11, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9680), "VN1", 11, new Guid("8346ce6e-7238-47d2-8568-c13e93670bc7"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9690), null },
                    { 10, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9670), "VP2", 10, new Guid("a7ebe745-d48b-450d-a538-91ed77c97800"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9670), null },
                    { 9, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9620), "VP1", 9, new Guid("7831b071-48fe-4a8a-acd5-427e173cb610"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9620), null },
                    { 8, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9600), "SN2", 8, new Guid("0a290bd5-9954-45ce-a536-c6a170d989ec"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9610), null },
                    { 7, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9590), "SN1", 7, new Guid("fee2c4b2-caec-49c4-b530-5eb915629b39"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9590), null },
                    { 3, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9510), "EN1", 3, new Guid("19999c06-55c1-4d24-8ebd-e2a4c7501621"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9510), null },
                    { 5, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9540), "SP1", 5, new Guid("9c750037-fe0d-4bd0-8829-f9d613e3b15c"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9550), null },
                    { 4, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9530), "EN2", 4, new Guid("29f4b46a-94d4-4c5d-a279-0988f7035767"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9530), null },
                    { 2, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9470), "EP2", 2, new Guid("5c87231c-6ad0-46f5-822c-52d6fdb46bfb"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9480), null },
                    { 1, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9000), "EP1", 1, new Guid("c62e0366-5970-46bc-84be-9cbe97900c8b"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9040), null },
                    { 6, null, new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9570), "SP2", 6, new Guid("7697a3dc-8f00-4a78-aeb8-e1301c030d42"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9570), null }
                });

            migrationBuilder.InsertData(
                table: "ParticipantTypes",
                columns: new[] { "ParticipantTypeId", "CreatedBy", "CreatedDate", "Name", "SortOrder", "ParticipantTypeUid", "UpdateDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1320), "Civilian", 1, new Guid("6431a5c9-ca16-4116-8683-bbf58a97fd68"), new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1370), null },
                    { 2, null, new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1870), "Veteran", 2, new Guid("d3ca7dcf-0733-4942-9260-3d81d0da40ab"), new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1880), null }
                });

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
                name: "IX_ApplicationUsers_ParticipantId",
                table: "ApplicationUsers",
                column: "ParticipantId",
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
