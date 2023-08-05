using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class RemovedContactAndAddedSoftDeleteToRefereeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Referees");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Referees",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 10, 19, 538, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 10, 19, 538, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 17, 10, 19, 538, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74c84164-6471-4be6-b2cc-e0d50ab18b12", "AQAAAAEAACcQAAAAECJTQsAlNiE33VImRbyE/5qn4c8jHt+J+Hp4wVkyaeqJOUVKhdAYBcxZl4DK3lEM1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "987cfdac-96ee-4195-96e5-353d821ea73d", "AQAAAAEAACcQAAAAEN/basBMjIbme9j1SbSraLQMVKrsxOQPQa6suuzdFK6ckw6KtJXh10R4hKEZMih9KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fac58c9-272d-4262-8052-90cb7a711269", "AQAAAAEAACcQAAAAELwQsOrJvF3He+KngNB1PRKS1eHCQyz7qGvLtWN/XuXAMavWJU5Sfqjg2fdNxbaI5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12b99454-8d7e-484a-aa5e-4024222b894d", "AQAAAAEAACcQAAAAEKq0FVzmpUEOfcENhbP5jwVjIlS32VlWOjc3G2qsAqU3oq4dYdiqho/xDU8cz2MWaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cfec5f0-f45b-4ff5-bf84-9c4f0802267f", "AQAAAAEAACcQAAAAEM4pFFKK5uVIpwCSoNj2v85oPOEwjWlGgU8Zxb0qW63PuJuQN0cU8s7l55R6GQyYsQ==" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Referees");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Referees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                comment: "Phone number of the person represented by this entity");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 5, 11, 17, 17, 466, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13a50e05-da4d-4700-a6f1-1e46f59e1b89", "AQAAAAEAACcQAAAAEBfJ083zw8yM4bnQdOJ4f5hFXv+R63dHEai0o+B9MhSh1cOA3sgycpiABgiwgtR/Gg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6be4576-a8a9-4305-8388-55dd2b56ed92", "AQAAAAEAACcQAAAAEDdjpolhzx2d87xBEG0PRNmn2wWl5QmWq2ryl5/VGQ5/C6KR3avMZFReIuhmI1LzTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2007953a-a8bd-4a06-9aa2-9bf0133e4fde", "AQAAAAEAACcQAAAAEFkjrI2PaPhPpqqp5jta9lR1mzL299+HaXtd1Z7kpRLhuRCISWII6kXVKhOy1sdW2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae123ac1-3624-48e6-b9d6-5fea7a820908", "AQAAAAEAACcQAAAAEGeNhvMSMP/szY8meP1nMHxFMxB1vpFSrVt9pU5GErhFpyDU3/J3JKW7XyLHK3d1jQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f019473-79bf-4204-ab2b-e550fb27f503", "AQAAAAEAACcQAAAAEB+6cdYpEPIqIBppgA1omYCOjLAxoOKM2ZcLZHlMeYFgue1Nb81a9sBdM9jr0CF9UQ==" });

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Contact",
                value: "0898556248");

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Contact",
                value: "0898556248");

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Contact",
                value: "0898556248");

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Contact",
                value: "0898556248");

            migrationBuilder.UpdateData(
                table: "Referees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Contact",
                value: "0898556248");
        }
    }
}
