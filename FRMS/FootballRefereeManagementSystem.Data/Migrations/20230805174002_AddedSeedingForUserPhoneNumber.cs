using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class AddedSeedingForUserPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "537c2056-28b8-45cb-810f-a10ac301f4d2", "AQAAAAEAACcQAAAAEDJf9i4/nzA8TAJrJ3eEayUOs+GlG21RjM8INbckeYnSg1zt+bRBtwV+CI4QX3ds7g==", "0897123456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "be3e9c1a-2247-41b7-9d8c-50228c8720e7", "AQAAAAEAACcQAAAAEFQh2cJZYEgGFXNTdToeC01g3t4kNc4v1C1NhGnVZSl6iBKTRd/G2LT3KyEx5uwRVQ==", "0897123456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "aa549f42-997a-4c4a-893f-eda9defb2b56", "AQAAAAEAACcQAAAAEDdH8mjZCs/gSCmGKp5XBt7G9qz/esXYNBCwIbLwyhYZmX998Y7GqQ9cAPg/fFXvlA==", "0897123456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1e95178d-c963-4064-8216-352bcbda4ca3", "AQAAAAEAACcQAAAAEB/keXrH6jB0llZrDjFeiM3qW+1ViUcKWF5CNlGPWifrj4Y9yqE3pJCgpZzgcx/q5A==", "0897123456" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "238e3f6f-3031-4ed3-8ce6-c611ac0dd904", "AQAAAAEAACcQAAAAEFyNQTABhdg0G4zTF0gRhKmZPcMmcDY57Q4y5FipkPfyo+tPGyc7KMzpGneT+MW38g==", "0897123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "74c84164-6471-4be6-b2cc-e0d50ab18b12", "AQAAAAEAACcQAAAAECJTQsAlNiE33VImRbyE/5qn4c8jHt+J+Hp4wVkyaeqJOUVKhdAYBcxZl4DK3lEM1Q==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "987cfdac-96ee-4195-96e5-353d821ea73d", "AQAAAAEAACcQAAAAEN/basBMjIbme9j1SbSraLQMVKrsxOQPQa6suuzdFK6ckw6KtJXh10R4hKEZMih9KQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "5fac58c9-272d-4262-8052-90cb7a711269", "AQAAAAEAACcQAAAAELwQsOrJvF3He+KngNB1PRKS1eHCQyz7qGvLtWN/XuXAMavWJU5Sfqjg2fdNxbaI5A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "12b99454-8d7e-484a-aa5e-4024222b894d", "AQAAAAEAACcQAAAAEKq0FVzmpUEOfcENhbP5jwVjIlS32VlWOjc3G2qsAqU3oq4dYdiqho/xDU8cz2MWaw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "6cfec5f0-f45b-4ff5-bf84-9c4f0802267f", "AQAAAAEAACcQAAAAEM4pFFKK5uVIpwCSoNj2v85oPOEwjWlGgU8Zxb0qW63PuJuQN0cU8s7l55R6GQyYsQ==", null });
        }
    }
}
