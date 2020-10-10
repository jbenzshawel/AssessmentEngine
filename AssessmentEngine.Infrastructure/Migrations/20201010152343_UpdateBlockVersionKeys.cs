using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateBlockVersionKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlockVersions_AssessmentVersions_AssessmentVersionId",
                table: "BlockVersions");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentVersionId",
                table: "BlockVersions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "75785d05-d8ab-463f-8ff8-fe6b87b62c37");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "bc0cafc2-d927-405e-b800-9406b3a1804f");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 259, DateTimeKind.Local).AddTicks(7590), new Guid("909176b8-d52c-4776-ab9f-de60666c79db"), new DateTime(2020, 10, 10, 10, 23, 42, 278, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2040), new Guid("ba64c161-8471-484d-b2ee-d745392eabc3"), new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2240), new Guid("846b169c-1968-4452-8d34-03b43c09cf4c"), new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2270), new Guid("3b226e12-c128-4293-8d6a-10e375c1d556"), new DateTime(2020, 10, 10, 10, 23, 42, 279, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 300, DateTimeKind.Local).AddTicks(4020), new Guid("be04d279-fb82-4191-af57-600341ad3ac9"), new DateTime(2020, 10, 10, 10, 23, 42, 300, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 300, DateTimeKind.Local).AddTicks(4450), new Guid("e269b004-efee-4713-93a6-237f0d8b9c85"), new DateTime(2020, 10, 10, 10, 23, 42, 300, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3320), new Guid("78689d5c-0a68-43fd-9b93-7810e9e89c36"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3760), new Guid("01a87e05-6791-42e4-ad7d-acd282828c68"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3790), new Guid("ccb1f630-a639-46bd-bab0-769b9942fe56"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3810), new Guid("a13f5b9c-5cb3-48b0-81a4-9394bc336dbc"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3830), new Guid("92ab0a69-84ec-4104-be7c-b8814c81d77d"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3850), new Guid("0554c27a-91c0-44e5-be5a-69bcd603af1d"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3870), new Guid("cb8f62bf-40a7-4541-8e9c-abc620377a19"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3890), new Guid("11605b9d-9f36-451d-8b56-b69063100065"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3900), new Guid("d5231b27-bf21-47a2-b6f5-54aeb4fc4650"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3920), new Guid("af6667db-cc7f-4520-a75c-6b920e8426d7"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3940), new Guid("129453cc-d7e4-4444-b976-7b495a9290b7"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3960), new Guid("aff43a7e-9e69-4e59-85bf-26370e1da9e1"), new DateTime(2020, 10, 10, 10, 23, 42, 304, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 312, DateTimeKind.Local).AddTicks(3120), new Guid("8303cfda-9785-4278-85d4-85b8fb0b8965"), new DateTime(2020, 10, 10, 10, 23, 42, 312, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 10, 23, 42, 312, DateTimeKind.Local).AddTicks(3610), new Guid("d201b963-3137-4c7a-8fa4-0706d73e70b1"), new DateTime(2020, 10, 10, 10, 23, 42, 312, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.AddForeignKey(
                name: "FK_BlockVersions_AssessmentVersions_AssessmentVersionId",
                table: "BlockVersions",
                column: "AssessmentVersionId",
                principalTable: "AssessmentVersions",
                principalColumn: "AssessmentVersionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlockVersions_AssessmentVersions_AssessmentVersionId",
                table: "BlockVersions");

            migrationBuilder.AlterColumn<int>(
                name: "AssessmentVersionId",
                table: "BlockVersions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "eeb48e55-ee4d-4011-b5fe-b832dc22974c");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "df150e1b-0c8e-4eb3-b0f6-e32e9e1e8905");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 350, DateTimeKind.Local).AddTicks(5100), new Guid("391507b1-88cf-498e-95c8-bb27fdde4b69"), new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7560), new Guid("3c1472fb-6aee-4aea-bebb-6fc4be2908a3"), new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7730), new Guid("928e3736-255f-44fa-86b6-327742778ea5"), new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7750), new Guid("f747115f-1b3b-4973-b991-366903586a03"), new DateTime(2020, 10, 10, 9, 56, 39, 369, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 391, DateTimeKind.Local).AddTicks(5760), new Guid("3d7dee4d-55b3-4bae-a0c8-6086b69bc4b4"), new DateTime(2020, 10, 10, 9, 56, 39, 391, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 391, DateTimeKind.Local).AddTicks(6160), new Guid("35b2c26b-a782-488d-a790-b6bb56c6d548"), new DateTime(2020, 10, 10, 9, 56, 39, 391, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(8740), new Guid("f4d448de-3813-404a-b52a-8ae29813cb78"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9110), new Guid("bcc9dc80-722c-4bc2-b810-c7ddcc1d64f4"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9140), new Guid("d23181ad-f786-4368-87ed-4f73318b92e4"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9160), new Guid("cdad8522-19aa-472a-8ae0-cae0fdd6284c"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9170), new Guid("4abcca05-a76e-42ed-abdd-beb85fbeb5b1"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9190), new Guid("c9ae01fb-a9c6-4fe1-aea1-b30f5e7ac676"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9210), new Guid("8980e642-c9d9-4122-8669-92f87ab3f3e2"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9230), new Guid("06c858ee-dfe2-4688-87c8-eb77d2c61437"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9240), new Guid("627d5704-29d7-407b-a3e6-ca847d50dd90"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9260), new Guid("b3e7f46b-030b-4b34-90f4-f8aa259b4d64"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9270), new Guid("b06b2b21-f867-4ec7-96ab-fc3d96c7e917"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9290), new Guid("87072436-43a4-45e5-8905-005ac57a66bd"), new DateTime(2020, 10, 10, 9, 56, 39, 394, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 400, DateTimeKind.Local).AddTicks(140), new Guid("9989eaa2-23c4-43b3-bd63-3dd697785d65"), new DateTime(2020, 10, 10, 9, 56, 39, 400, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 56, 39, 400, DateTimeKind.Local).AddTicks(540), new Guid("0dff2865-0035-4b32-8a7a-543238438228"), new DateTime(2020, 10, 10, 9, 56, 39, 400, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.AddForeignKey(
                name: "FK_BlockVersions_AssessmentVersions_AssessmentVersionId",
                table: "BlockVersions",
                column: "AssessmentVersionId",
                principalTable: "AssessmentVersions",
                principalColumn: "AssessmentVersionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
