using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AddTaskUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "AssessmentVersions",
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

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentVersions_ApplicationUserId",
                table: "AssessmentVersions",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentVersions_ApplicationUsers_ApplicationUserId",
                table: "AssessmentVersions",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentVersions_ApplicationUsers_ApplicationUserId",
                table: "AssessmentVersions");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentVersions_ApplicationUserId",
                table: "AssessmentVersions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AssessmentVersions");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "3256948c-b7f7-446d-8c89-4b130466abc9");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "b412ab30-1fd2-485a-95d0-c4a13f2f5c99");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 481, DateTimeKind.Local).AddTicks(6780), new Guid("aa56a491-c78c-49dd-8cf6-1cfca5b0207d"), new DateTime(2020, 9, 24, 22, 53, 55, 522, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(2660), new Guid("eafbcf82-b4dc-479b-8060-ea0c1d473ced"), new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(2990), new Guid("7facb441-2213-451a-8bb5-39277c2bf232"), new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(3030), new Guid("e14f788f-3c69-45d9-972d-c466899c5fa0"), new DateTime(2020, 9, 24, 22, 53, 55, 523, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 557, DateTimeKind.Local).AddTicks(8310), new Guid("db525c47-67b4-479a-98a0-a16a5726c5c8"), new DateTime(2020, 9, 24, 22, 53, 55, 557, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 557, DateTimeKind.Local).AddTicks(9090), new Guid("d9118b60-dd04-41aa-a702-035a940b33d1"), new DateTime(2020, 9, 24, 22, 53, 55, 557, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4220), new Guid("97d23e90-70e8-443f-b57f-ffd88f4726d6"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4910), new Guid("110d0ff2-219e-4230-83dc-d37f21ecdfff"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4950), new Guid("e198724b-9340-4cc2-a2f5-a194691c1a28"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4980), new Guid("dda15917-71fa-4a46-b6a2-582c9a0f5342"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5170), new Guid("d1eb0142-542e-42c0-ba94-6dfe55fb48d1"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5210), new Guid("0b5853af-9a01-43bc-ace4-6a5adae2c382"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5240), new Guid("2b781410-d181-4637-9bc2-28b5fbd5e742"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5270), new Guid("66030510-2851-4d1f-9dc9-8ad9fe7fba79"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5300), new Guid("805e10cd-3a1d-4fcc-97dc-ab3111be12bf"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5340), new Guid("5bbe72fd-113d-490b-a67f-8f908e79536f"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5370), new Guid("c3539c3b-621f-455c-90d8-0b50a2bb1b47"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5390), new Guid("6f5ad4e6-0c21-423c-92e1-4006ac13fcb5"), new DateTime(2020, 9, 24, 22, 53, 55, 563, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 575, DateTimeKind.Local).AddTicks(8970), new Guid("4d77c33b-a2a3-4af7-bbdb-813c7d68df27"), new DateTime(2020, 9, 24, 22, 53, 55, 575, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "ParticipantTypes",
                keyColumn: "ParticipantTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ParticipantTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 24, 22, 53, 55, 576, DateTimeKind.Local).AddTicks(1280), new Guid("45bdce13-7dd3-44a6-919c-cde81b8018f0"), new DateTime(2020, 9, 24, 22, 53, 55, 576, DateTimeKind.Local).AddTicks(1310) });
        }
    }
}
