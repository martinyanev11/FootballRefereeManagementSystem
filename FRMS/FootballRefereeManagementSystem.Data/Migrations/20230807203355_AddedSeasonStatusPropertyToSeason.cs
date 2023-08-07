using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class AddedSeasonStatusPropertyToSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Seasons",
                type: "int",
                nullable: false,
                defaultValue: 2,
                comment: "Current status of the season");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 7, 20, 33, 54, 375, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 7, 20, 33, 54, 375, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 7, 20, 33, 54, 375, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d999f67-1ad5-47b7-bc3e-8c23520289ba", "AQAAAAEAACcQAAAAEFL8c6lzdqGFaHaJo/ZhZukbyYRKANHO8jhMNkZhTF5ziZ787WI/NBGMCZhSRwiFNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e114a2ec-ba3e-4dc6-ab04-28baccc8e63c", "AQAAAAEAACcQAAAAEFS+nziJdns09gzWtpXKy+BMuEqEC/uHdKYAKM5Br7kLAUiZ+s8V44Q7M0yoXvavnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "866ad94e-0ee6-4141-975e-0c0d424226e3", "AQAAAAEAACcQAAAAEAVdjpmLZyFkSkLlmuRHEXP0NchO8vLTthYlVcIVxyMqgXffkEYDsb8gKAcpcmOZQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ef8ae3b-2ac8-46a3-bcf8-7bab0001807d", "AQAAAAEAACcQAAAAECtxstniZZg6IhfzCZxDuui8er0Yqwu7003GE4tFpKmx6ru9m6eXsJFB3sBbvxOuAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8382d0f2-2137-45e8-8403-0b57d3aac520", "AQAAAAEAACcQAAAAEPVc9PdjxIw3ir8OA3/R6AVntPVgqdhdYy3SqJh1UIVYKVJjqTMufQzHruzp35V62Q==" });

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Seasons");

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
        }
    }
}
