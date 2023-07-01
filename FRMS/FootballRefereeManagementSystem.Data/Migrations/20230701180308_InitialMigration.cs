#nullable disable
namespace FootballRefereeManagementSystem.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefereeId = table.Column<int>(type: "int", nullable: false, comment: "The navigation to the referee for this user"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                },
                comment: "Customization of Default Identity User");

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Division name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                },
                comment: "Division represents the level of the teams playing in it");

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the person represented by this entity"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the person represented by this entity"),
                    Age = table.Column<int>(type: "int", nullable: false, comment: "Age of the person represented by this entity")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                },
                comment: "Manager is the one who is in charge of team");

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the player"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the player"),
                    Age = table.Column<int>(type: "int", nullable: false, comment: "Age of the player"),
                    Position = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "In what position the player plays in the team")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                },
                comment: "Player playing in specific team during specific season");

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false, comment: "Short name for the season (e.g. 2004/05, 2011/12, 2022/23)"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start of the season"),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End of the season")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                },
                comment: "Season is the timespan in which all matches between teams are played");

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Name of the zone")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                },
                comment: "Zone that is part of region in the country");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: false, comment: "Name of the town"),
                    ZoneId = table.Column<int>(type: "int", nullable: false, comment: "Zone in which town is located"),
                    Distance = table.Column<double>(type: "float", nullable: false, comment: "Distance to town from given location"),
                    TravelTime = table.Column<int>(type: "int", nullable: false, comment: "The time it takes to go to the town from given location"),
                    TravelCost = table.Column<double>(type: "float", nullable: false, comment: "The cost of travel which is calculated from distance and gas price")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Where teams and referees are located and matches are played");

            migrationBuilder.CreateTable(
                name: "Referees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "First name of the person represented by this entity"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Last name of the person represented by this entity"),
                    Age = table.Column<int>(type: "int", nullable: false, comment: "Age of the person represented by this entity"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "~/Images/Referees/referee-default-avatar.png", comment: "Picture of the person represented by this entity"),
                    Contact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Phone number of the person represented by this entity"),
                    Role = table.Column<int>(type: "int", nullable: false, comment: "Current role of the person represented by this entity within the organization"),
                    CareerStart = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of registration within the organization"),
                    TotalMatchesOfficiated = table.Column<int>(type: "int", nullable: false, comment: "Number of matches officiated"),
                    TownId = table.Column<int>(type: "int", nullable: false, comment: "Current town which the person represented by this entity resides"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "The registered user related to this entity"),
                    IsAvaliable = table.Column<bool>(type: "bit", nullable: false, comment: "Gives information if person is free to officiate matches for current round"),
                    CurrentlyAppointedMatchesCount = table.Column<int>(type: "int", nullable: false, comment: "The number of matches appointed to this entity on current round")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Referees_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The main entity of the application");

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the team"),
                    Abbreviation = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false, comment: "Abbreviation of the team"),
                    TownId = table.Column<int>(type: "int", nullable: false, comment: "In which town the team is located")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Team that plays matches in specific division during specific season");

            migrationBuilder.CreateTable(
                name: "RefereesDivisions",
                columns: table => new
                {
                    RefereeId = table.Column<int>(type: "int", nullable: false, comment: "Referee in specific division"),
                    DivisionId = table.Column<int>(type: "int", nullable: false, comment: "Division in which referee is allowed to offciate"),
                    DivisionMatchesOfficiated = table.Column<int>(type: "int", nullable: false, comment: "The count of matches referee officiated in this division")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereesDivisions", x => new { x.RefereeId, x.DivisionId });
                    table.ForeignKey(
                        name: "FK_RefereesDivisions_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefereesDivisions_Referees_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Referee and Division");

            migrationBuilder.CreateTable(
                name: "TeamsSeasons",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false, comment: "Team that participates specific season"),
                    SeasonId = table.Column<int>(type: "int", nullable: false, comment: "The specific season"),
                    DivisionId = table.Column<int>(type: "int", nullable: false, comment: "In which division the team plays"),
                    Points = table.Column<int>(type: "int", nullable: false, comment: "Points earned during season"),
                    Placement = table.Column<int>(type: "int", nullable: false, comment: "Placement in the division during the season"),
                    ShirtColor = table.Column<int>(type: "int", nullable: false, comment: "Color of the player's shirts"),
                    ManagerId = table.Column<int>(type: "int", nullable: false, comment: "The manager of the team for specific season")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsSeasons", x => new { x.TeamId, x.SeasonId });
                    table.ForeignKey(
                        name: "FK_TeamsSeasons_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsSeasons_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsSeasons_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsSeasons_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for team and season");

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionId = table.Column<int>(type: "int", nullable: false, comment: "In what division is the match played"),
                    TownId = table.Column<int>(type: "int", nullable: false, comment: "Town in which the match is played"),
                    FixtureTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time the match is played"),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false, comment: "Information about host team"),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false, comment: "Information about guest team"),
                    SeasonId = table.Column<int>(type: "int", nullable: false, comment: "Season during which match takes place")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matches_TeamsSeasons_AwayTeamId_SeasonId",
                        columns: x => new { x.AwayTeamId, x.SeasonId },
                        principalTable: "TeamsSeasons",
                        principalColumns: new[] { "TeamId", "SeasonId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_TeamsSeasons_HomeTeamId_SeasonId",
                        columns: x => new { x.HomeTeamId, x.SeasonId },
                        principalTable: "TeamsSeasons",
                        principalColumns: new[] { "TeamId", "SeasonId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Information about a football match");

            migrationBuilder.CreateTable(
                name: "PlayerTeamSeason",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false, comment: "Team playing in specific season"),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false, comment: "The player in the team")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTeamSeason", x => new { x.TeamId, x.SeasonId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_PlayerTeamSeason_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerTeamSeason_TeamsSeasons_TeamId_SeasonId",
                        columns: x => new { x.TeamId, x.SeasonId },
                        principalTable: "TeamsSeasons",
                        principalColumns: new[] { "TeamId", "SeasonId" },
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Player playing in a team during a season");

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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefereesMatches_Referees_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Referee and Match");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId_SeasonId",
                table: "Matches",
                columns: new[] { "AwayTeamId", "SeasonId" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_DivisionId",
                table: "Matches",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId_SeasonId",
                table: "Matches",
                columns: new[] { "HomeTeamId", "SeasonId" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TownId",
                table: "Matches",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeamSeason_PlayerId",
                table: "PlayerTeamSeason",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_TownId",
                table: "Referees",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Referees_UserId",
                table: "Referees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefereesDivisions_DivisionId",
                table: "RefereesDivisions",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereesMatches_MatchId",
                table: "RefereesMatches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TownId",
                table: "Teams",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSeasons_DivisionId",
                table: "TeamsSeasons",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSeasons_ManagerId",
                table: "TeamsSeasons",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsSeasons_SeasonId",
                table: "TeamsSeasons",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_ZoneId",
                table: "Towns",
                column: "ZoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PlayerTeamSeason");

            migrationBuilder.DropTable(
                name: "RefereesDivisions");

            migrationBuilder.DropTable(
                name: "RefereesMatches");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Referees");

            migrationBuilder.DropTable(
                name: "TeamsSeasons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
