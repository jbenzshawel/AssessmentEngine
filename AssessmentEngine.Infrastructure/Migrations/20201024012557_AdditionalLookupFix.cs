using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AdditionalLookupFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticipantTypeUid",
                table: "ParticipantTypes");

            migrationBuilder.DropColumn(
                name: "BlockTypeUid",
                table: "BlockTypes");

            migrationBuilder.DropColumn(
                name: "AssessmentTypeUid",
                table: "AssessmentTypes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserAuditTypeUid",
                table: "ApplicationUserAuditTypes");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "b055604f-fa42-4b3a-9aca-e4d6ba38ecac");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "2df44374-4b2a-45fa-9277-5773bf7a78a4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParticipantTypeUid",
                table: "ParticipantTypes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BlockTypeUid",
                table: "BlockTypes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssessmentTypeUid",
                table: "AssessmentTypes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserAuditTypeUid",
                table: "ApplicationUserAuditTypes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "572824a6-103c-4ea3-98b1-5c35321c7e87");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "de5eac63-d2aa-42ef-af85-2a7edfbd0412");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                column: "ApplicationUserAuditTypeUid",
                value: new Guid("0e77b3d3-8cd4-4e6e-8b9f-4bd5671bbf91"));

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                column: "ApplicationUserAuditTypeUid",
                value: new Guid("402b0cc5-dfea-44e8-8323-e3b674b855f3"));

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                column: "ApplicationUserAuditTypeUid",
                value: new Guid("df37859a-fd98-4709-a041-19a0c646c7e6"));

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                column: "ApplicationUserAuditTypeUid",
                value: new Guid("6b7c70cc-7879-4c84-9f33-20ff6467b9c7"));

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                column: "AssessmentTypeUid",
                value: new Guid("ff04913e-9668-4466-88a9-6dc8ed545670"));

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                column: "AssessmentTypeUid",
                value: new Guid("4bb34a77-2e0c-4602-8359-fc5d248bad32"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                column: "BlockTypeUid",
                value: new Guid("e21b1b5a-cda1-46fd-af7c-f430d161b5a8"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                column: "BlockTypeUid",
                value: new Guid("27b248a2-59ae-493f-adb9-49931c9584f4"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                column: "BlockTypeUid",
                value: new Guid("09c1fed6-0030-4d3e-9c8d-e4956cfb427a"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                column: "BlockTypeUid",
                value: new Guid("056e1deb-03fc-4015-88f7-6181201ec2f7"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                column: "BlockTypeUid",
                value: new Guid("bb7c9944-31bc-4b23-ac44-90ea9f5de0fe"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                column: "BlockTypeUid",
                value: new Guid("004db876-574c-496c-b627-c50a3f1b4623"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                column: "BlockTypeUid",
                value: new Guid("ac7df5aa-fc96-487e-b97e-1bda1fd566a4"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                column: "BlockTypeUid",
                value: new Guid("a272093d-38f3-4f61-b471-0e860a723e40"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                column: "BlockTypeUid",
                value: new Guid("724b59f4-cf4f-47d8-be37-884e717a7b49"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                column: "BlockTypeUid",
                value: new Guid("22953d40-6d61-4c5a-8e21-89d47cba3cde"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                column: "BlockTypeUid",
                value: new Guid("350437e2-8733-4688-a2ea-20f333dbbc0b"));

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                column: "BlockTypeUid",
                value: new Guid("7e770efb-4f94-4bb0-9f20-87ee36a8409c"));

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                column: "ParticipantTypeUid",
                value: new Guid("501893db-062c-4f01-9b64-4a54f5d8897c"));

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                column: "ParticipantTypeUid",
                value: new Guid("7cbacb14-83c2-44b9-8063-c0ad981d793f"));
        }
    }
}
