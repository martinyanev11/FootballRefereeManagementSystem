using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class AddedPlayerTeamSeasonDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeamSeason_Players_PlayerId",
                table: "PlayerTeamSeason");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeamSeason_TeamsSeasons_TeamId_SeasonId",
                table: "PlayerTeamSeason");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerTeamSeason",
                table: "PlayerTeamSeason");

            migrationBuilder.RenameTable(
                name: "PlayerTeamSeason",
                newName: "PlayersTeamsSeasons");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerTeamSeason_PlayerId",
                table: "PlayersTeamsSeasons",
                newName: "IX_PlayersTeamsSeasons_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayersTeamsSeasons",
                table: "PlayersTeamsSeasons",
                columns: new[] { "TeamId", "SeasonId", "PlayerId" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 26, 15, 58, 2, 443, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f8b14e8-7c71-4ff0-a509-c5dfe568ec44", "AQAAAAEAACcQAAAAEInvjWtZNIlE7LNQEkMgV9W+ShKl93oYpPnk1KdW6rZR+yV2XbVNVgtgxVAM5L6wGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5b2a109-6d3f-4fdf-9683-08bdfa3239e7", "AQAAAAEAACcQAAAAEL9V0uv09YSKgcBlHIR0nQUeBjWtfETcvBwi5tSWG0Nq8Dieu7cd87EEFLLR66Lsmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46eff332-d210-4d38-a12f-1c74a99ec865", "AQAAAAEAACcQAAAAEF95oqwS84Ez6zhB3o6z2koOdr0L957fXhYB0OHCWy6miQmUmH+80hNwCAv1qEnZUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56ca116a-0986-424a-b132-7d3054f71736", "AQAAAAEAACcQAAAAEBPqIsBM5zmcEhNdfU8hK0yZA5OyKKpkHKn1B5BIvJm87hqcqlg98ZSVcUZFBxkf6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a4b13cac-4329-4591-a809-044f022444a0", "AQAAAAEAACcQAAAAEFwTVDQZHifTh6TQ6f6qTEeQiHMYPeXmdXVPF+eYBe6MvifHYKmiHoe39r7K9of7Iw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersTeamsSeasons_Players_PlayerId",
                table: "PlayersTeamsSeasons",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersTeamsSeasons_TeamsSeasons_TeamId_SeasonId",
                table: "PlayersTeamsSeasons",
                columns: new[] { "TeamId", "SeasonId" },
                principalTable: "TeamsSeasons",
                principalColumns: new[] { "TeamId", "SeasonId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersTeamsSeasons_Players_PlayerId",
                table: "PlayersTeamsSeasons");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersTeamsSeasons_TeamsSeasons_TeamId_SeasonId",
                table: "PlayersTeamsSeasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayersTeamsSeasons",
                table: "PlayersTeamsSeasons");

            migrationBuilder.RenameTable(
                name: "PlayersTeamsSeasons",
                newName: "PlayerTeamSeason");

            migrationBuilder.RenameIndex(
                name: "IX_PlayersTeamsSeasons_PlayerId",
                table: "PlayerTeamSeason",
                newName: "IX_PlayerTeamSeason_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerTeamSeason",
                table: "PlayerTeamSeason",
                columns: new[] { "TeamId", "SeasonId", "PlayerId" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 24, 8, 24, 47, 646, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9fb59782-101d-474a-b954-d773df109e4b", "AQAAAAEAACcQAAAAEL+g1CUVFxxFGlSjZ0BpcV+UnkP8Olp/XOtUHk4JGyXPBc7RlUU8zisEb0NqxV9seQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6948a76-1c5d-41e1-863d-c5eb57f18b55", "AQAAAAEAACcQAAAAECJbu35t/+xWfsJBqpUirIHs1hAqUKwZUj845Grd/0cDh4RvQzfqVTNC6VTJLwK02A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69f29cf1-0f80-4d9f-9d19-4bb997f70761", "AQAAAAEAACcQAAAAEGz6YYH/DnmNr9y5Za6RWetGGRuMGb1Ln5M17namYzKfYrKvMKPEvS40GEudmhhBvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3baf9a45-b2cc-474a-9195-ca2eb9a7156a", "AQAAAAEAACcQAAAAEOaXQnXdHIQdepz9f9NQHBHCW/ubK06p0YPgTKhJYzgBWx/GzCtUFkjAQfce5nqAYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99aedc19-6c72-40fa-9ce9-72dc1c6a73de", "AQAAAAEAACcQAAAAEEKVvI2KIQR0+Q5k1Lh2JAXggoCiBAO21//WR67YuzWF2Se0RNWgisqEVPwux9nw9g==" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeamSeason_Players_PlayerId",
                table: "PlayerTeamSeason",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeamSeason_TeamsSeasons_TeamId_SeasonId",
                table: "PlayerTeamSeason",
                columns: new[] { "TeamId", "SeasonId" },
                principalTable: "TeamsSeasons",
                principalColumns: new[] { "TeamId", "SeasonId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
