using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class SeasonRoundInMatchEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeasonRound",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Specifies in which round of matches this particular match will be played");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeasonRound",
                table: "Matches");
        }
    }
}
