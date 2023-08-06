using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class RefereeDivisionEntitySoftDeleteAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "RefereesDivisions",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 18, 59, 40, 506, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 18, 59, 40, 506, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 18, 59, 40, 506, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c266f751-61a5-4705-b024-a85f2be5b44f", "AQAAAAEAACcQAAAAEFHbNnzARRE7FaucqgBZB4cvpWeDZAJGKtyMWGp8zVhsfIKdUgr2jlzuH9cUisolaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77dbfd4e-aa75-47ce-b034-582ec1cdd157", "AQAAAAEAACcQAAAAEDu4Q2CD/anz5g6PVsdiSV1FaA0qrn3lfn2h7v0zJ9utpfc/18w8NCYrZHSJ0mMgXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "496bbb82-5626-4d27-9291-a63f2739be84", "AQAAAAEAACcQAAAAEBwmqwaaBGB7i5HT5OI/ZAhOGnz3TTBdxzxKzwi1JxqukwHNxap658iuSGxsNW+JdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11dec8c8-e980-4786-bc45-62fba872a740", "AQAAAAEAACcQAAAAEKwAbGI922XjD7RxzNn7z95Cq/X0A6zNJGj4XoyNX2AIZ+C0O6b8plu+j2rmh/d1Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb7f7a88-6183-4798-af04-2e28238b60fc", "AQAAAAEAACcQAAAAEE2/ty8rCaMjP9USNkI30VKnjA6ufxNZYMOfhB5nwTrkqONp4vkXel3Kg4ughTSD/g==" });

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 1 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 1 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 2 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 2 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 3 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 3 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 3, 4 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 4, 4 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 5, 4 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 1, 5 },
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "RefereesDivisions",
                keyColumns: new[] { "DivisionId", "RefereeId" },
                keyValues: new object[] { 2, 5 },
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "RefereesDivisions");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 11, 44, 4, 138, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 11, 44, 4, 138, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 6, 11, 44, 4, 138, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f226a8e-935c-4411-9591-25957af69e90", "AQAAAAEAACcQAAAAEJMJfGrX8PDFUxpQ4k/sqrT6IwYKvgco5s35sc2jWHkMpaGNhFRjuYzYnjhzDiXlDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d14b0979-678d-416a-86f7-75a36ca554d5", "AQAAAAEAACcQAAAAEGXnkUO89nlje1MIHvmBzgWP8MNw2y6nHNjPl2BDZ14b9FZzNDUGbEKMP2KkYn8L0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ecec81f-85d8-469d-a6ba-f1203b790de2", "AQAAAAEAACcQAAAAEJNbeecT6bM9B62e66Iv1rYaIhrJbi6lCDHDjW8CkivMO0daiAz1Ob5tb6XNRayndg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8dacc93-6f0b-4596-be2d-7de398f8ee1c", "AQAAAAEAACcQAAAAEE+N67ZKdRReLIa/+NOYYduTWBmeGHPy9vyER3f4uIXLGK1vkXpvtgu22lmnEWbMGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eef2917-4e17-4996-8835-5470a3474103", "AQAAAAEAACcQAAAAEKL4NmRSMGJaffkRT2j2Ks46HLbtmZm25TCfgMhdaEzjNfEC0BcGjH6f31lx+GpwSg==" });
        }
    }
}
