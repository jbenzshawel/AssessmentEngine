using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentEngine.Infrastructure.Migrations
{
    public partial class AdminPortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "e547e6fb-07d4-4819-ab47-14d797385a1f");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "6586a0c1-34cd-46aa-b253-07402d9e53df");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 851, DateTimeKind.Local).AddTicks(1970), new Guid("18e63da4-f65a-4899-92c1-10efc7e4306b"), new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2670), new Guid("ab74ba34-6a32-48cf-a7b1-6820f33723c8"), new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2710), new Guid("e18f5d5b-f8d3-4fd5-8433-5aefd8c23441"), new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2730), new Guid("8468eec9-52e2-4c95-be7f-209095883372"), new DateTime(2020, 9, 2, 23, 47, 16, 871, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9490), new Guid("bc82fa2c-7fe1-4c18-b866-33499d60eb32"), new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9690), new Guid("8dd94aed-3d25-4c37-9ea2-d00112b7c23e"), new DateTime(2020, 9, 2, 23, 47, 16, 887, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2360), new Guid("20dfddc4-430c-459b-b1d1-1684949ad833"), new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2550), new Guid("14182799-a2cb-484b-b30b-c3c02961fc0b"), new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2600), new Guid("0b1b5ab7-5913-4d78-9a82-ce44529a3bf1"), new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2610), new Guid("4555262a-0f84-412b-8bd9-2cb9ba9c5822"), new DateTime(2020, 9, 2, 23, 47, 16, 891, DateTimeKind.Local).AddTicks(2620) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d587953-2fb4-4198-9a5d-e64095439783"),
                column: "ConcurrencyStamp",
                value: "ac6841cc-9e9b-40fd-962a-68ba7b433dfd");

            migrationBuilder.UpdateData(
                table: "ApplicationRoles",
                keyColumn: "Id",
                keyValue: new Guid("d8105d5f-3a2e-428b-8c57-36398b196379"),
                column: "ConcurrencyStamp",
                value: "933bdb11-fc96-405b-aefa-59a8eb7d4bba");

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 821, DateTimeKind.Local).AddTicks(2800), new Guid("253423e9-e8a3-4c5a-b30e-34f0b830249c"), new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6310), new Guid("5e7bbd4f-a114-4a14-9532-df7a3881a345"), new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6350), new Guid("83298d08-00e2-403a-8033-76ee52e58e05"), new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "ApplicationUserAuditTypes",
                keyColumn: "ApplicationUserAuditTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ApplicationUserAuditTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6370), new Guid("926afc7b-5abc-42c3-a642-68e3d9fcc8bc"), new DateTime(2020, 9, 1, 22, 11, 4, 841, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7240), new Guid("5c1a88ad-c071-4ebe-bc19-73b11c7f90e9"), new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "AssessmentTypes",
                keyColumn: "AssessmentTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "AssessmentTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7430), new Guid("71a367ff-011e-481a-9b02-e2fd08deace3"), new DateTime(2020, 9, 1, 22, 11, 4, 857, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4240), new Guid("aedc5a15-16c8-44e3-afd0-e14e1e37a4de"), new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4450), new Guid("5ec16940-1dca-45de-80d0-facb2012a2e4"), new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4470), new Guid("1c8f9067-ab5b-40bb-80d2-eb75c273f316"), new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "BlockTypes",
                keyColumn: "BlockTypeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "BlockTypeUid", "UpdateDate" },
                values: new object[] { new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4490), new Guid("d26306ea-e2f7-4758-9f29-af81913b724e"), new DateTime(2020, 9, 1, 22, 11, 4, 861, DateTimeKind.Local).AddTicks(4490) });
        }
    }
}
