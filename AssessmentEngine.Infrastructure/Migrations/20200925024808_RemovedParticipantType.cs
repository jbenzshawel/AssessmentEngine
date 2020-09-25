using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class RemovedParticipantType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "7d6a0316-75cf-495c-bf6c-bac3432d837e");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "1cf52bc0-dc2e-4b18-9cf3-0f5317ec4c27");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 11, DateTimeKind.Local).AddTicks(4320), new Guid("4f4c8ccc-f460-43e3-86a8-913ff362b587"), new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9460), new Guid("701509aa-d0a7-4419-948b-60785546b13e"), new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9780), new Guid("61bb1f90-9f7e-4e5f-b3d2-ca3e0df7960c"), new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9820), new Guid("301cdbb2-6a08-4b15-8dad-117779ba9976"), new DateTime(2020, 9, 24, 21, 48, 7, 42, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 80, DateTimeKind.Local).AddTicks(1790), new Guid("9762c4fd-5d4e-4cb4-acfa-244e5dde51e0"), new DateTime(2020, 9, 24, 21, 48, 7, 80, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 80, DateTimeKind.Local).AddTicks(2980), new Guid("a7531e94-4686-4976-ad21-f1957f477e11"), new DateTime(2020, 9, 24, 21, 48, 7, 80, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 85, DateTimeKind.Local).AddTicks(9970), new Guid("7a0d1d53-dff2-4618-a779-027ee8be2611"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1700), new Guid("28e972b7-9831-4de8-80c5-3aaf604d41ad"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1760), new Guid("1f878970-72dd-4bc7-9c6e-e606e0bf6d1d"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1790), new Guid("a2397dc0-2967-4bad-b097-639ce0b7f760"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1810), new Guid("c91fdee9-de3c-4423-9ad7-0f52af4f45db"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1850), new Guid("378afa94-e88e-4d3d-b34b-ec5106743fbe"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1880), new Guid("76743abd-6929-4d28-8b60-12b3d117e6a4"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1900), new Guid("873faece-669a-482a-882d-c0619a715489"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1930), new Guid("a94475b4-0973-4ffe-b5e9-4a3ccf121eee"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1960), new Guid("2d40465f-5ce0-4055-af28-3ee1bd1adf55"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1980), new Guid("a753c184-fc6d-481a-982b-9f3549de0aa5"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(2000), new Guid("d74301a4-a07a-4695-be50-37a479184094"), new DateTime(2020, 9, 24, 21, 48, 7, 86, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 92, DateTimeKind.Local).AddTicks(4950), new Guid("29a421b0-161f-472c-be3e-f39dd33e4749"), new DateTime(2020, 9, 24, 21, 48, 7, 92, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 48, 7, 92, DateTimeKind.Local).AddTicks(5480), new Guid("0ee944aa-1d9b-46f7-9e2e-999b7319db9a"), new DateTime(2020, 9, 24, 21, 48, 7, 92, DateTimeKind.Local).AddTicks(5490) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "69073451-a310-4251-a242-a9f9d8e04d52");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "46d56cd4-25fd-4658-9066-c0c195950257");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 870, DateTimeKind.Local).AddTicks(5680), new Guid("75951dc2-87f9-4931-83cd-9e56142607b9"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6380), new Guid("e7a68348-8242-422b-a54e-8a5689922d9c"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6680), new Guid("b590f50c-f694-40b7-89e7-eb84f0268411"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6750), new Guid("46a5779d-17c9-4ee5-8b8e-3d9d294fe08d"), new DateTime(2020, 9, 24, 21, 39, 44, 892, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(3430), new Guid("f6a5984f-0ef5-4725-9e77-668f87f8a771"), new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(4170), new Guid("1a78a55f-2441-45b0-b9b7-5e33ff44956d"), new DateTime(2020, 9, 24, 21, 39, 44, 920, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9000), new Guid("c62e0366-5970-46bc-84be-9cbe97900c8b"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9470), new Guid("5c87231c-6ad0-46f5-822c-52d6fdb46bfb"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9510), new Guid("19999c06-55c1-4d24-8ebd-e2a4c7501621"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9530), new Guid("29f4b46a-94d4-4c5d-a279-0988f7035767"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9540), new Guid("9c750037-fe0d-4bd0-8829-f9d613e3b15c"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9570), new Guid("7697a3dc-8f00-4a78-aeb8-e1301c030d42"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9590), new Guid("fee2c4b2-caec-49c4-b530-5eb915629b39"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9600), new Guid("0a290bd5-9954-45ce-a536-c6a170d989ec"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9620), new Guid("7831b071-48fe-4a8a-acd5-427e173cb610"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9670), new Guid("a7ebe745-d48b-450d-a538-91ed77c97800"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9680), new Guid("8346ce6e-7238-47d2-8568-c13e93670bc7"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9700), new Guid("8a0f24d2-6704-4e97-9570-9c1b3f56f226"), new DateTime(2020, 9, 24, 21, 39, 44, 929, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1320), new Guid("6431a5c9-ca16-4116-8683-bbf58a97fd68"), new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1870), new Guid("d3ca7dcf-0733-4942-9260-3d81d0da40ab"), new DateTime(2020, 9, 24, 21, 39, 44, 936, DateTimeKind.Local).AddTicks(1880) });
        }
    }
}
