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
                name: "application_user_audit_types",
                columns: table => new
                {
                    ApplicationUserAuditTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserAuditTypeUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_application_user_audit_types", x => x.ApplicationUserAuditTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRoles",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_name = table.Column<string>(maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    user_name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(maxLength: 256, nullable: true),
                    email = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(nullable: false),
                    password_hash = table.Column<string>(nullable: true),
                    security_stamp = table.Column<string>(nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    phone_number_confirmed = table.Column<bool>(nullable: false),
                    two_factor_enabled = table.Column<bool>(nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(nullable: true),
                    lockout_enabled = table.Column<bool>(nullable: false),
                    access_failed_count = table.Column<int>(nullable: false),
                    participant_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "assessment_types",
                columns: table => new
                {
                    AssessmentTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentTypeUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assessment_types", x => x.AssessmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "block_types",
                columns: table => new
                {
                    BlockTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlockTypeUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_block_types", x => x.BlockTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRoleClaims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<Guid>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_role_claims_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "ApplicationRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "application_user_audits",
                columns: table => new
                {
                    ApplicationUserAuditId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserAuditUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    application_user_id = table.Column<Guid>(nullable: false),
                    action_date = table.Column<DateTime>(nullable: false),
                    application_user_audit_type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_application_user_audits", x => x.ApplicationUserAuditId);
                    table.ForeignKey(
                        name: "fk_application_user_audits_application_user_audit_types_applic",
                        column: x => x.application_user_audit_type_id,
                        principalTable: "application_user_audit_types",
                        principalColumn: "ApplicationUserAuditTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_application_user_audits_users_application_user_id",
                        column: x => x.application_user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserClaims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<Guid>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_claims_users_user_id",
                        column: x => x.user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserLogins",
                columns: table => new
                {
                    login_provider = table.Column<string>(maxLength: 128, nullable: false),
                    provider_key = table.Column<string>(maxLength: 128, nullable: false),
                    provider_display_name = table.Column<string>(nullable: true),
                    user_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_user_logins_users_user_id",
                        column: x => x.user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserRoles",
                columns: table => new
                {
                    user_id = table.Column<Guid>(nullable: false),
                    role_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_user_roles_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "ApplicationRoles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_roles_users_user_id",
                        column: x => x.user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTokens",
                columns: table => new
                {
                    user_id = table.Column<Guid>(nullable: false),
                    login_provider = table.Column<string>(maxLength: 128, nullable: false),
                    name = table.Column<string>(maxLength: 128, nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_user_tokens_users_user_id",
                        column: x => x.user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assessment_versions",
                columns: table => new
                {
                    AssessmentVersionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentVersionUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    version_name = table.Column<string>(nullable: true),
                    assessment_type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assessment_versions", x => x.AssessmentVersionId);
                    table.ForeignKey(
                        name: "fk_assessment_versions_assessment_types_assessment_type_id",
                        column: x => x.assessment_type_id,
                        principalTable: "assessment_types",
                        principalColumn: "AssessmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assessments",
                columns: table => new
                {
                    AssessmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    assessment_version_id = table.Column<int>(nullable: false),
                    started_date = table.Column<DateTime>(nullable: false),
                    completed_date = table.Column<DateTime>(nullable: false),
                    deleted_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assessments", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "fk_assessments_assessment_versions_assessment_version_id",
                        column: x => x.assessment_version_id,
                        principalTable: "assessment_versions",
                        principalColumn: "AssessmentVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "block_versions",
                columns: table => new
                {
                    BlockVersionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlockVersionUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    cognitive_load = table.Column<bool>(nullable: false),
                    series = table.Column<string>(nullable: true),
                    block_type_id = table.Column<int>(nullable: false),
                    assessment_version_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_block_versions", x => x.BlockVersionId);
                    table.ForeignKey(
                        name: "fk_block_versions_assessment_versions_assessment_version_id",
                        column: x => x.assessment_version_id,
                        principalTable: "assessment_versions",
                        principalColumn: "AssessmentVersionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_block_versions_block_types_block_type_id",
                        column: x => x.block_type_id,
                        principalTable: "block_types",
                        principalColumn: "BlockTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assessment_blocks",
                columns: table => new
                {
                    AssessmentBlockId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentBlockUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    assessment_id = table.Column<int>(nullable: false),
                    block_type_id = table.Column<int>(nullable: false),
                    series_recall = table.Column<string>(nullable: true),
                    completed_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assessment_blocks", x => x.AssessmentBlockId);
                    table.ForeignKey(
                        name: "fk_assessment_blocks_assessments_assessment_id",
                        column: x => x.block_type_id,
                        principalTable: "assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_assessment_blocks_block_types_block_type_id",
                        column: x => x.block_type_id,
                        principalTable: "block_types",
                        principalColumn: "BlockTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assessment_participants",
                columns: table => new
                {
                    AssessmentParticipantId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssessmentParticipantUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    application_user_id = table.Column<Guid>(nullable: false),
                    assessment_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_assessment_participants", x => x.AssessmentParticipantId);
                    table.ForeignKey(
                        name: "fk_assessment_participants_users_application_user_id",
                        column: x => x.application_user_id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_assessment_participants_assessments_assessment_id",
                        column: x => x.assessment_id,
                        principalTable: "assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationRoles",
                columns: new[] { "id", "concurrency_stamp", "name", "normalized_name" },
                values: new object[,]
                {
                    { new Guid("5d587953-2fb4-4198-9a5d-e64095439783"), "35502786-27eb-43a8-bed1-0a5822eb07d9", "Administrator", "ADMINISTRATOR" },
                    { new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"), "7f61b5fa-94cb-4e76-b76d-323b69227a8c", "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "id", "access_failed_count", "concurrency_stamp", "email", "email_confirmed", "lockout_enabled", "lockout_end", "normalized_email", "normalized_user_name", "participant_id", "password_hash", "phone_number", "phone_number_confirmed", "security_stamp", "two_factor_enabled", "user_name" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), 0, "66046443-f6a0-4c4a-beed-902dc49f1903", "admin@assessment.com", false, false, null, "ADMIN@ASSESSMENT.COM", "ADMIN@ASSESSMENT.COM", null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF", false, "admin@assessment.com" });

            migrationBuilder.InsertData(
                table: "application_user_audit_types",
                columns: new[] { "ApplicationUserAuditTypeId", "created_by", "created_date", "name", "ApplicationUserAuditTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 11, 22, 26, 51, 658, DateTimeKind.Local).AddTicks(5800), "Login", new Guid("63685018-fffc-4325-8976-f9fa3cdea565"), new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(4320), null },
                    { 2, null, new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6290), "Logout", new Guid("913007a1-8a28-49fe-8490-d45c7d7daef6"), new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6330), null },
                    { 3, null, new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6380), "Lockout", new Guid("138e6edb-b9cc-4337-8974-73a8f072924a"), new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6390), null },
                    { 4, null, new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6410), "PasswordReset", new Guid("21ead010-bb2b-45ef-a505-7af6a76fac9d"), new DateTime(2020, 9, 11, 22, 26, 51, 683, DateTimeKind.Local).AddTicks(6420), null }
                });

            migrationBuilder.InsertData(
                table: "assessment_types",
                columns: new[] { "AssessmentTypeId", "created_by", "created_date", "name", "AssessmentTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 11, 22, 26, 51, 706, DateTimeKind.Local).AddTicks(6450), "DualNBack", new Guid("8d9dcec4-f89f-4a65-80fd-20ce5ef4a462"), new DateTime(2020, 9, 11, 22, 26, 51, 706, DateTimeKind.Local).AddTicks(6490), null },
                    { 2, null, new DateTime(2020, 9, 11, 22, 26, 51, 706, DateTimeKind.Local).AddTicks(6670), "EFT", new Guid("030ba1dc-826c-41a4-8cc7-7b384bfb9f4c"), new DateTime(2020, 9, 11, 22, 26, 51, 706, DateTimeKind.Local).AddTicks(6680), null }
                });

            migrationBuilder.InsertData(
                table: "block_types",
                columns: new[] { "BlockTypeId", "created_by", "created_date", "name", "BlockTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5120), "E1", new Guid("a407c2d4-1660-4237-a9c7-012af20428dd"), new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5150), null },
                    { 2, null, new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5310), "S1", new Guid("5b2ea032-5baf-440a-b482-4223f01b5d03"), new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5320), null },
                    { 3, null, new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5340), "E2", new Guid("495628f0-1084-4542-9601-7bf091d7f9cf"), new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5340), null },
                    { 4, null, new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5350), "S2", new Guid("fddd5ca2-ad01-4cb9-8398-15886a2ec155"), new DateTime(2020, 9, 11, 22, 26, 51, 710, DateTimeKind.Local).AddTicks(5360), null }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserRoles",
                columns: new[] { "user_id", "role_id" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), new Guid("5d587953-2fb4-4198-9a5d-e64095439783") });

            migrationBuilder.CreateIndex(
                name: "ix_application_user_audits_application_user_audit_type_id",
                table: "application_user_audits",
                column: "application_user_audit_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_application_user_audits_application_user_id",
                table: "application_user_audits",
                column: "application_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_role_claims_role_id",
                table: "ApplicationRoleClaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "ApplicationRoles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_user_claims_user_id",
                table: "ApplicationUserClaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_logins_user_id",
                table: "ApplicationUserLogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_roles_role_id",
                table: "ApplicationUserRoles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "ApplicationUsers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ApplicationUsers",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_assessment_blocks_block_type_id",
                table: "assessment_blocks",
                column: "block_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_assessment_participants_application_user_id",
                table: "assessment_participants",
                column: "application_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_assessment_participants_assessment_id",
                table: "assessment_participants",
                column: "assessment_id");

            migrationBuilder.CreateIndex(
                name: "ix_assessment_versions_assessment_type_id",
                table: "assessment_versions",
                column: "assessment_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_assessments_assessment_version_id",
                table: "assessments",
                column: "assessment_version_id");

            migrationBuilder.CreateIndex(
                name: "ix_block_versions_assessment_version_id",
                table: "block_versions",
                column: "assessment_version_id");

            migrationBuilder.CreateIndex(
                name: "ix_block_versions_block_type_id",
                table: "block_versions",
                column: "block_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_user_audits");

            migrationBuilder.DropTable(
                name: "ApplicationRoleClaims");

            migrationBuilder.DropTable(
                name: "ApplicationUserClaims");

            migrationBuilder.DropTable(
                name: "ApplicationUserLogins");

            migrationBuilder.DropTable(
                name: "ApplicationUserRoles");

            migrationBuilder.DropTable(
                name: "ApplicationUserTokens");

            migrationBuilder.DropTable(
                name: "assessment_blocks");

            migrationBuilder.DropTable(
                name: "assessment_participants");

            migrationBuilder.DropTable(
                name: "block_versions");

            migrationBuilder.DropTable(
                name: "application_user_audit_types");

            migrationBuilder.DropTable(
                name: "ApplicationRoles");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "assessments");

            migrationBuilder.DropTable(
                name: "block_types");

            migrationBuilder.DropTable(
                name: "assessment_versions");

            migrationBuilder.DropTable(
                name: "assessment_types");
        }
    }
}
