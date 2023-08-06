using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class RefereeNameAndAgeChangedToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Referees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "Last name of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Last name of the person represented by this entity");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Referees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "First name of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "First name of the person represented by this entity");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Referees",
                type: "int",
                nullable: true,
                comment: "Age of the person represented by this entity",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Age of the person represented by this entity");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Referees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Last name of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "Last name of the person represented by this entity");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Referees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "First name of the person represented by this entity",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "First name of the person represented by this entity");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Referees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Age of the person represented by this entity",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Age of the person represented by this entity");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 40, 1, 149, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 40, 1, 149, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 40, 1, 149, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "537c2056-28b8-45cb-810f-a10ac301f4d2", "AQAAAAEAACcQAAAAEDJf9i4/nzA8TAJrJ3eEayUOs+GlG21RjM8INbckeYnSg1zt+bRBtwV+CI4QX3ds7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be3e9c1a-2247-41b7-9d8c-50228c8720e7", "AQAAAAEAACcQAAAAEFQh2cJZYEgGFXNTdToeC01g3t4kNc4v1C1NhGnVZSl6iBKTRd/G2LT3KyEx5uwRVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa549f42-997a-4c4a-893f-eda9defb2b56", "AQAAAAEAACcQAAAAEDdH8mjZCs/gSCmGKp5XBt7G9qz/esXYNBCwIbLwyhYZmX998Y7GqQ9cAPg/fFXvlA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e95178d-c963-4064-8216-352bcbda4ca3", "AQAAAAEAACcQAAAAEB/keXrH6jB0llZrDjFeiM3qW+1ViUcKWF5CNlGPWifrj4Y9yqE3pJCgpZzgcx/q5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "238e3f6f-3031-4ed3-8ce6-c611ac0dd904", "AQAAAAEAACcQAAAAEFyNQTABhdg0G4zTF0gRhKmZPcMmcDY57Q4y5FipkPfyo+tPGyc7KMzpGneT+MW38g==" });
        }
    }
}
