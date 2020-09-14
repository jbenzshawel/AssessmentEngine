using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class UpdateParticipant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "9b0e05e9-6c2d-4e35-bc0a-ddee6772dab2");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "1f29db58-42ab-44b4-9a72-ae21a05bbf02");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 208, DateTimeKind.Local).AddTicks(6780), new Guid("fdfdae4f-4d1f-4fbd-8f69-7189b13953c0"), new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5440), new Guid("bea3247d-b455-4854-8e57-978005a28d7f"), new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5670), new Guid("86909065-99f5-40c7-9247-bff0f9739c1e"), new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5690), new Guid("18942ed4-5b51-4e69-86aa-b890caaaffe9"), new DateTime(2020, 9, 13, 20, 29, 17, 228, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3220), new Guid("dbc2a2cc-b0f1-4d4b-b3dc-134ea99a9924"), new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3660), new Guid("3f5baf40-510e-4802-8cd4-5fa02b5a2cb9"), new DateTime(2020, 9, 13, 20, 29, 17, 249, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(8540), new Guid("935db3eb-fd10-4b1f-8a16-745bcd32e7e9"), new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9060), new Guid("11c29bfc-0699-4a15-bfd7-167afb70b30b"), new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9090), new Guid("3347a1b0-c585-476e-92e2-6c918de6a4be"), new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9110), new Guid("e88272c3-0507-4cbe-b748-91d0d2958c9d"), new DateTime(2020, 9, 13, 20, 29, 17, 252, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9350), new Guid("6e592e84-cec3-4d73-a13b-0a48984678f0"), new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9780), new Guid("bbc35e10-84a4-4bbc-a845-1cc01f55baf6"), new DateTime(2020, 9, 13, 20, 29, 17, 257, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_ParticipantId",
                table: "ApplicationUsers",
                column: "ParticipantId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_ParticipantId",
                table: "ApplicationUsers");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "739c6328-036b-456a-9f7d-bb1337f40547");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "8ec8c68b-d513-4bcf-b8b2-ef294b846f8c");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 570, DateTimeKind.Local).AddTicks(7280), new Guid("917d74e0-b67a-47a3-bbce-d9c1c3e0009e"), new DateTime(2020, 9, 13, 19, 35, 58, 590, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(40), new Guid("611194e9-eacf-4b0b-ab55-1c14f84afbe2"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(290), new Guid("30fb0bb1-c7c1-4478-8e29-d32cba833623"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(310), new Guid("b3a3b5df-8eb9-42cd-8d14-45f1a1e0dcdc"), new DateTime(2020, 9, 13, 19, 35, 58, 591, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2390), new Guid("0722c572-07bc-4f52-9a1a-22e4686e0312"), new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2800), new Guid("b6739a36-513e-4d2e-8c6f-fd61a1c67fd9"), new DateTime(2020, 9, 13, 19, 35, 58, 623, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 626, DateTimeKind.Local).AddTicks(9670), new Guid("67570617-0f6c-4034-9f23-1d52e25fd432"), new DateTime(2020, 9, 13, 19, 35, 58, 626, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(150), new Guid("1bf4f5dd-a37d-44f3-9ced-1a2309923f27"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(190), new Guid("f975426e-eb90-4b74-a99c-8ff9d7bd4e3c"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(200), new Guid("5305701a-8b1e-44c5-a012-2f6dccff9408"), new DateTime(2020, 9, 13, 19, 35, 58, 627, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(5590), new Guid("5cf6d306-fe2e-4c3d-9266-768c5af651e4"), new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(6070), new Guid("4c65859c-880b-475c-958e-5aac72d3ecfd"), new DateTime(2020, 9, 13, 19, 35, 58, 633, DateTimeKind.Local).AddTicks(6080) });
        }
    }
}
