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
                    name = table.Column<string>(maxLength: 500, nullable: false),
                    sort_order = table.Column<int>(nullable: false)
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
                    name = table.Column<string>(maxLength: 500, nullable: false),
                    sort_order = table.Column<int>(nullable: false)
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
                    name = table.Column<string>(maxLength: 500, nullable: false),
                    sort_order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_block_types", x => x.BlockTypeId);
                });

            migrationBuilder.CreateTable(
                name: "participant_types",
                columns: table => new
                {
                    ParticipantTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParticipantTypeUid = table.Column<Guid>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    updated_by = table.Column<string>(nullable: true),
                    update_date = table.Column<DateTime>(nullable: true),
                    name = table.Column<string>(maxLength: 500, nullable: false),
                    sort_order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_participant_types", x => x.ParticipantTypeId);
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
                    assessment_type_id = table.Column<int>(nullable: false),
                    image_viewing_time = table.Column<int>(nullable: true),
                    cognitive_load_viewing_time = table.Column<int>(nullable: true),
                    blank_screen_viewing_time = table.Column<int>(nullable: true)
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
                    participant_id = table.Column<string>(nullable: true),
                    participant_type_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                    table.ForeignKey(
                        name: "fk_users_participant_types_participant_type_id",
                        column: x => x.participant_type_id,
                        principalTable: "participant_types",
                        principalColumn: "ParticipantTypeId",
                        onDelete: ReferentialAction.Restrict);
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
                    { new Guid("5d587953-2fb4-4198-9a5d-e64095439783"), "ecfb8b45-dd88-49ba-96a2-9988baa7756b", "Administrator", "ADMINISTRATOR" },
                    { new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"), "15b7d210-1b99-4b85-9609-9a228adb7534", "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "id", "access_failed_count", "concurrency_stamp", "email", "email_confirmed", "lockout_enabled", "lockout_end", "normalized_email", "normalized_user_name", "participant_id", "participant_type_id", "password_hash", "phone_number", "phone_number_confirmed", "security_stamp", "two_factor_enabled", "user_name" },
                values: new object[] { new Guid("61479990-b62a-40e4-8973-f6d6eb1ab9b8"), 0, "66046443-f6a0-4c4a-beed-902dc49f1903", "admin@assessment.com", false, false, null, "ADMIN@ASSESSMENT.COM", "ADMIN@ASSESSMENT.COM", null, null, "AQAAAAEAACcQAAAAEGwu9ZqklcHcnJ2rf9wzQDYQZKFmGpJ6Ye65my0yvVsjqBW4yfFZ+gli0PicTseu0Q==", null, false, "QJYMV3R4ITNYXH7EV3JVN3M2DZXEQZEF", false, "admin@assessment.com" });

            migrationBuilder.InsertData(
                table: "application_user_audit_types",
                columns: new[] { "ApplicationUserAuditTypeId", "created_by", "created_date", "name", "sort_order", "ApplicationUserAuditTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 12, 19, 58, 43, 305, DateTimeKind.Local).AddTicks(9220), "Login", 1, new Guid("7787220a-51f0-452b-9169-bed1d0e223c1"), new DateTime(2020, 9, 12, 19, 58, 43, 325, DateTimeKind.Local).AddTicks(7770), null },
                    { 2, null, new DateTime(2020, 9, 12, 19, 58, 43, 325, DateTimeKind.Local).AddTicks(9820), "Logout", 2, new Guid("731a8f8b-2abe-4dc4-8e58-7dad814dc19c"), new DateTime(2020, 9, 12, 19, 58, 43, 325, DateTimeKind.Local).AddTicks(9840), null },
                    { 3, null, new DateTime(2020, 9, 12, 19, 58, 43, 325, DateTimeKind.Local).AddTicks(9990), "Lockout", 3, new Guid("7e6730e6-8783-4b95-8822-7aa847667d4d"), new DateTime(2020, 9, 12, 19, 58, 43, 326, DateTimeKind.Local), null },
                    { 4, null, new DateTime(2020, 9, 12, 19, 58, 43, 326, DateTimeKind.Local).AddTicks(10), "PasswordReset", 4, new Guid("7087d4eb-fd7b-4e6c-a3b0-eaf12e076ab6"), new DateTime(2020, 9, 12, 19, 58, 43, 326, DateTimeKind.Local).AddTicks(20), null }
                });

            migrationBuilder.InsertData(
                table: "assessment_types",
                columns: new[] { "AssessmentTypeId", "created_by", "created_date", "name", "sort_order", "AssessmentTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 12, 19, 58, 43, 346, DateTimeKind.Local).AddTicks(4610), "DualNBack", 1, new Guid("deef710f-70ea-4f23-8263-1b5153a58fb4"), new DateTime(2020, 9, 12, 19, 58, 43, 346, DateTimeKind.Local).AddTicks(4640), null },
                    { 2, null, new DateTime(2020, 9, 12, 19, 58, 43, 346, DateTimeKind.Local).AddTicks(5090), "EFT", 2, new Guid("56d67e12-7ef6-447f-9d66-35f5aac97cc7"), new DateTime(2020, 9, 12, 19, 58, 43, 346, DateTimeKind.Local).AddTicks(5100), null }
                });

            migrationBuilder.InsertData(
                table: "block_types",
                columns: new[] { "BlockTypeId", "created_by", "created_date", "name", "sort_order", "BlockTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(280), "E1", 1, new Guid("4f5dd866-26c2-4ff6-b042-e000b7265c99"), new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(310), null },
                    { 2, null, new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(660), "S1", 2, new Guid("24982c3f-0905-43fe-9709-8fe1c0ddf572"), new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(660), null },
                    { 3, null, new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(680), "E2", 3, new Guid("595a13d6-077d-4dfa-94ef-83e2b914353b"), new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(690), null },
                    { 4, null, new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(700), "S2", 4, new Guid("c6be6eb6-9f00-4d6d-83bb-965aa5ce5cba"), new DateTime(2020, 9, 12, 19, 58, 43, 350, DateTimeKind.Local).AddTicks(700), null }
                });

            migrationBuilder.InsertData(
                table: "participant_types",
                columns: new[] { "ParticipantTypeId", "created_by", "created_date", "name", "sort_order", "ParticipantTypeUid", "update_date", "updated_by" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 9, 12, 19, 58, 43, 354, DateTimeKind.Local).AddTicks(9130), "Civilian", 1, new Guid("8b2018c5-6d9f-40ea-9b26-ebbfb963f30d"), new DateTime(2020, 9, 12, 19, 58, 43, 354, DateTimeKind.Local).AddTicks(9160), null },
                    { 2, null, new DateTime(2020, 9, 12, 19, 58, 43, 354, DateTimeKind.Local).AddTicks(9530), "Veteran", 2, new Guid("8bda851b-3d8d-4822-94ee-698c68058cf4"), new DateTime(2020, 9, 12, 19, 58, 43, 354, DateTimeKind.Local).AddTicks(9530), null }
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
                name: "ix_users_participant_type_id",
                table: "ApplicationUsers",
                column: "participant_type_id");

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
                name: "participant_types");

            migrationBuilder.DropTable(
                name: "assessment_versions");

            migrationBuilder.DropTable(
                name: "assessment_types");
        }
    }
}
