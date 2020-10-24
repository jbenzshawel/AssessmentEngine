using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
