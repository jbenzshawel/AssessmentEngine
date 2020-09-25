using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AddBlockVersionSortOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "BlockVersions",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "BlockVersions");

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
    }
}
