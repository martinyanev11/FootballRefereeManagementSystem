using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ChangeRefereeContactMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Referees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Phone number of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Phone number of the person represented by this entity");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 31, 16, 59, 31, 138, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ce2e6dc-5333-4abb-a918-d9293a081a56", "AQAAAAEAACcQAAAAEO9pw56w01QGza2Z8NU25h36+FbUAKMzEqqjqxswV/VxVMiGbAUlzs+tRgSN/TBq+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e66d6e2-1c84-47e9-9fa9-07d18f283951", "AQAAAAEAACcQAAAAEAwNYmHTbAkUESfDXD/E/toLq1LugpKE9u4oDOGezuvj5R3wHLfGuD7k37qzPI4G0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40f4a688-da27-40d1-a797-fef387127dc7", "AQAAAAEAACcQAAAAEMRfW2rGXgP3/Iqqs403Uth2wSuKf45ulMBB+X35Q5b74gBAi0uOPkwD4NCuqPHWzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb286228-fab4-4c75-adb1-78eda0c228a5", "AQAAAAEAACcQAAAAEMEuuiyvU4+LKzV2p5qAr8Oqu/UPcPUeuY5WhtFAgNIHcbufvwFwOpZEezDW8b9z+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4feec1a5-9fc6-4e10-927d-edb8072b20f2", "AQAAAAEAACcQAAAAEN3RmyqTC4kirkM7KBqh1OQpmyYo59pf81KSzgtwRrXk/X/yX5kfch1WqrrgSTVlBA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Referees",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Phone number of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Phone number of the person represented by this entity");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 29, 18, 25, 34, 78, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30aee5b8-0b32-464f-8832-4b9a57b3b417", "AQAAAAEAACcQAAAAEFeYpM5wzDrZYiJRag0dfsLKLaXF6UT+ESa1PnPz6BPRLVCTtpZMf7zbtiPL8zYw6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5063a0bb-e142-43a4-b1de-22a89db2515d", "AQAAAAEAACcQAAAAEMD8RH9paXr8r4xxdS+L/wssDtM3+OKXEsTdqE5Z9GajDzbaeH146HPkOQzxk7JqzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ad205e4-5162-4910-a5ec-bb50ad08ae3a", "AQAAAAEAACcQAAAAEGioUum7f+VdCNzT+8Ha98ixuaSX1uUdeqwttqHDQn1xBSaT9TEDhmP+2jmEiO+Bww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d366c9ac-69d8-4eeb-818d-654bf0a54476", "AQAAAAEAACcQAAAAEGsVyVjaR+K3IBWPLZ5gA55Kk4+yQT2oJfTO7cKhI8bCjfXEVCPKbIA+qASnRTOrrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b09d693-07b2-4bb7-ac01-b3620a6b2c7c", "AQAAAAEAACcQAAAAENxrQqSz85dqMITyW4NqkMa7uVD1l5UI0PfIXTxLk3orcxmv9IGwciI/X5W0jowWiQ==" });
        }
    }
}
