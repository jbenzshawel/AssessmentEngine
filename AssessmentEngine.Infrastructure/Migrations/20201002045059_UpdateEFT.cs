using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateEFT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlankScreenViewingTime",
                table: "AssessmentVersions");

            migrationBuilder.AddColumn<int>(
                name: "FixationCrossViewingTime",
                table: "AssessmentVersions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "f6966a30-5ef6-48f0-8ad2-a1c4bbfc49f1");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "3c865c5e-9093-4022-94be-d61bce5b7b18");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 776, DateTimeKind.Local).AddTicks(5650), new Guid("f4134cae-4896-45e8-bbf0-82e68fbaf256"), new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9050), new Guid("107fb887-c6ce-4875-b088-b76418fc17ee"), new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9290), new Guid("1b9db4e8-9632-4b7e-91dc-465b655ccf29"), new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9310), new Guid("a20abc5a-0ae9-4c31-a3fb-7dbef8f99aa8"), new DateTime(2020, 10, 1, 23, 50, 58, 795, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 819, DateTimeKind.Local).AddTicks(3280), new Guid("2696e77a-2087-4d30-a534-df77c0ad24ca"), new DateTime(2020, 10, 1, 23, 50, 58, 819, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 819, DateTimeKind.Local).AddTicks(3720), new Guid("d1d9319a-f60d-46c9-8cd9-3f443fdfe012"), new DateTime(2020, 10, 1, 23, 50, 58, 819, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(6780), new Guid("745417b6-5c60-4c5e-bfe3-285206a78adf"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7180), new Guid("c113353e-f66d-4335-8c38-ff4fed26cf4d"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7220), new Guid("53cbb377-0608-46a8-986b-0a1b94e18f80"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7230), new Guid("7226396c-2916-4f1c-88f7-643dc59b147d"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7250), new Guid("1571cb3e-833c-432f-9770-4fdc56cd165a"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7270), new Guid("4ce51cdb-fb94-4052-93c4-f66089a5b622"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7290), new Guid("e041b114-b4a8-4fbe-9f5b-e7dc1ccbaec1"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7300), new Guid("5fff8dcc-a0b5-4aa6-809b-e2c575737dae"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7320), new Guid("d34fd98c-9dac-4801-936c-c1b7c8b7f532"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7340), new Guid("e353587c-4dc7-4b8a-adc5-199f7490883d"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7350), new Guid("404caca8-fc22-44e1-b16e-c80c1f28b0ef"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7370), new Guid("555747bb-8af5-4432-9601-6c6a60880f9c"), new DateTime(2020, 10, 1, 23, 50, 58, 822, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 827, DateTimeKind.Local).AddTicks(5440), new Guid("cd844d4e-1a70-4483-b1ae-2fd70a3630ac"), new DateTime(2020, 10, 1, 23, 50, 58, 827, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 10, 1, 23, 50, 58, 827, DateTimeKind.Local).AddTicks(5860), new Guid("2e8ddb27-c4f7-400d-8754-d52d7f76e17f"), new DateTime(2020, 10, 1, 23, 50, 58, 827, DateTimeKind.Local).AddTicks(5870) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FixationCrossViewingTime",
                table: "AssessmentVersions");

            migrationBuilder.AddColumn<int>(
                name: "BlankScreenViewingTime",
                table: "AssessmentVersions",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "e29c6ff0-e290-4df3-b4aa-8d1fcde90318");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "099102f5-f154-4c1e-9d88-3b3f8dc67d1f");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 861, DateTimeKind.Local).AddTicks(5080), new Guid("d3161fea-cb28-49e5-bcab-ae097564ed37"), new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6510), new Guid("28b7f35f-d65b-4d2f-b31a-17083693457f"), new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6670), new Guid("e1557059-b47f-4a58-81e0-217d50cbbd21"), new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6700), new Guid("76150ddf-e397-4e0a-aa7e-2253e36a1cdf"), new DateTime(2020, 9, 24, 23, 44, 14, 880, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 902, DateTimeKind.Local).AddTicks(5940), new Guid("262abec3-ce8a-42be-b110-9bb0eff0aafd"), new DateTime(2020, 9, 24, 23, 44, 14, 902, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 902, DateTimeKind.Local).AddTicks(6350), new Guid("1f933cd1-d480-4d6b-ad69-a8653ff4ffc5"), new DateTime(2020, 9, 24, 23, 44, 14, 902, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9210), new Guid("8ca0387a-433d-438d-b38b-1a3b0d3cdec6"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9590), new Guid("8fee6853-46d4-4a16-9b2e-0333d63d5cf5"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9620), new Guid("7def3ab3-c476-4ed2-8dea-11c784471f20"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9640), new Guid("4c9af79e-5b43-4912-a60d-e02acee26980"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9650), new Guid("61d23a11-046a-40d1-abce-698c62d38705"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9680), new Guid("4ffa0a4d-46b5-4ab7-b61f-9130daa17ac5"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9690), new Guid("dc958e1b-2abf-4be1-aeff-54ea9aa8eeda"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9710), new Guid("e6fd839d-c61f-40e2-a890-7e722e21becd"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9720), new Guid("d8e95dd5-87a9-4bfe-b33f-77110416abc9"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9740), new Guid("fc76af00-4f51-4684-9850-6e886be93352"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9760), new Guid("71367a50-c294-48fd-b187-c6c57e5e7085"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9770), new Guid("3fba7472-9211-4f14-9f8e-b7d3ddb33e18"), new DateTime(2020, 9, 24, 23, 44, 14, 905, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 910, DateTimeKind.Local).AddTicks(9020), new Guid("6f150f2c-bae7-47d2-922b-0620454ba22c"), new DateTime(2020, 9, 24, 23, 44, 14, 910, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 44, 14, 910, DateTimeKind.Local).AddTicks(9480), new Guid("02b7be22-0ddb-4be3-8740-4047fc0c481e"), new DateTime(2020, 9, 24, 23, 44, 14, 910, DateTimeKind.Local).AddTicks(9490) });
        }
    }
}
