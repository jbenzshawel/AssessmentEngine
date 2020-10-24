using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class FixLookupAuditColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ParticipantTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ParticipantTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BlockTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "BlockTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AssessmentTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssessmentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ApplicationUserAuditTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ApplicationUserAuditTypes");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ParticipantTypes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ParticipantTypes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BlockTypes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "BlockTypes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentTypes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssessmentTypes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ApplicationUserAuditTypes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ApplicationUserAuditTypes",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "b8cfff60-82dd-4fa3-8e18-844119836079");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "ff9ef563-9b55-4971-859a-e6d594726b3b");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 287, DateTimeKind.Local).AddTicks(3230), new Guid("d14b96c1-66d6-474a-abe9-d5dd64d57135"), new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2650), new Guid("3f418f95-d6f3-4bdf-9f67-474cb3d349e0"), new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2820), new Guid("41a2df46-8232-47c4-84cf-55893fb6aaf2"), new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2850), new Guid("229fe87e-bf5f-4d3f-aebc-c318efed54e7"), new DateTime(2020, 10, 23, 20, 15, 10, 309, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 330, DateTimeKind.Local).AddTicks(9460), new Guid("990fbb34-0591-424f-8d3a-1e290a57cd67"), new DateTime(2020, 10, 23, 20, 15, 10, 330, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 330, DateTimeKind.Local).AddTicks(9860), new Guid("af9f7e7c-72b5-464a-bc92-b8118619b2f2"), new DateTime(2020, 10, 23, 20, 15, 10, 330, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4560), new Guid("560cf419-6da2-416b-9074-39b42d6cf4aa"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4960), new Guid("46ca8444-fd89-467c-8e29-3a3f075d2365"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4980), new Guid("39d43c88-e7b7-48e3-8809-66cfd770625e"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5000), new Guid("a389614a-51e4-48fa-b0d2-bf36e5fc699d"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5020), new Guid("23d9fa7a-6977-4c0d-908f-46d1bd3fe29d"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5040), new Guid("1ff80d7d-96d1-4c6c-a25a-85aa72f94a86"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5060), new Guid("65b95695-f90f-4644-8703-10d870bdebd8"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5080), new Guid("f3dabcd5-a842-4f9c-972b-cdfbb5f69c8c"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5090), new Guid("e2d9de8b-406a-47fe-9d5d-22b2084499f0"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5110), new Guid("f06ccd74-8d1a-4dbc-b620-985682bafd4d"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5130), new Guid("3d723f78-910f-4f8f-a1a3-99b163f4a88c"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5140), new Guid("718e8784-3e2e-458c-8d53-51d48154e9b2"), new DateTime(2020, 10, 23, 20, 15, 10, 334, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 340, DateTimeKind.Local).AddTicks(6170), new Guid("2ab438ae-3b78-43eb-affd-bf664a2ec323"), new DateTime(2020, 10, 23, 20, 15, 10, 340, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 23, 20, 15, 10, 340, DateTimeKind.Local).AddTicks(6550), new Guid("58d6fa71-8766-4a6d-8bcc-c0fb347a48c5"), new DateTime(2020, 10, 23, 20, 15, 10, 340, DateTimeKind.Local).AddTicks(6560) });
        }
    }
}
