#nullable disable
namespace FootballRefereeManagementSystem.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedRefSquadAndMsgEntitiesRemovedRefereeMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefereesMatches");

            migrationBuilder.AddColumn<string>(
                name: "FinalResult",
                table: "Matches",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                comment: "The final result of the match");

            migrationBuilder.AddColumn<Guid>(
                name: "RefereeSquadId",
                table: "Matches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "The referee squad appointed to officiate the match");

            migrationBuilder.CreateTable(
                name: "RefereesSquads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key"),
                    MainRefereeId = table.Column<int>(type: "int", nullable: false, comment: "Main referee of the squad"),
                    FirstAssistantRefereeId = table.Column<int>(type: "int", nullable: false, comment: "First assistant of the match"),
                    SecondAssistantRefereeId = table.Column<int>(type: "int", nullable: false, comment: "Second assistant of the match"),
                    DelegateId = table.Column<int>(type: "int", nullable: false, comment: "Delegate who will supervise the officials"),
                    MatchId = table.Column<int>(type: "int", nullable: false, comment: "Match assigned to the squad")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereesSquads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefereesSquads_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereesSquads_Referees_DelegateId",
                        column: x => x.DelegateId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereesSquads_Referees_FirstAssistantRefereeId",
                        column: x => x.FirstAssistantRefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereesSquads_Referees_MainRefereeId",
                        column: x => x.MainRefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereesSquads_Referees_SecondAssistantRefereeId",
                        column: x => x.SecondAssistantRefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Every referee squad consists of 1 main ref, 2 assitants and a delegate");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Primary key"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the message creator"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Time and date of creation"),
                    Content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "The content of the message"),
                    RefereeSquadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The match center where comment was made")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_RefereesSquads_RefereeSquadId",
                        column: x => x.RefereeSquadId,
                        principalTable: "RefereesSquads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Messages the referee write in match center");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RefereeSquadId",
                table: "Messages",
                column: "RefereeSquadId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesSquads_DelegateId",
                table: "RefereesSquads",
                column: "DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesSquads_FirstAssistantRefereeId",
                table: "RefereesSquads",
                column: "FirstAssistantRefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesSquads_MainRefereeId",
                table: "RefereesSquads",
                column: "MainRefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesSquads_MatchId",
                table: "RefereesSquads",
                column: "MatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefereesSquads_SecondAssistantRefereeId",
                table: "RefereesSquads",
                column: "SecondAssistantRefereeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "RefereesSquads");

            migrationBuilder.DropColumn(
                name: "FinalResult",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "RefereeSquadId",
                table: "Matches");

            migrationBuilder.CreateTable(
                name: "RefereesMatches",
                columns: table => new
                {
                    RefereeId = table.Column<int>(type: "int", nullable: false, comment: "Referee who will officiate a match"),
                    MatchId = table.Column<int>(type: "int", nullable: false, comment: "Match which the referee will officiate")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereesMatches", x => new { x.RefereeId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_RefereesMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereesMatches_Referees_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Mapping table for Referee and Match");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesMatches_MatchId",
                table: "RefereesMatches",
                column: "MatchId");
        }
    }
}
