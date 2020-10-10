using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateBlockVersions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "BlockVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmotionalRating",
                table: "BlockVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeriesRecall",
                table: "BlockVersions",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "BlockVersions");

            migrationBuilder.DropColumn(
                name: "EmotionalRating",
                table: "BlockVersions");

            migrationBuilder.DropColumn(
                name: "SeriesRecall",
                table: "BlockVersions");

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
    }
}
