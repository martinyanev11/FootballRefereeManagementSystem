using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class MatchAndMessageEntitiesChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Referee who created the message");

            migrationBuilder.AlterColumn<Guid>(
                name: "RefereeSquadId",
                table: "Matches",
                type: "uniqueidentifier",
                nullable: true,
                comment: "The referee squad appointed to officiate the match",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "The referee squad appointed to officiate the match");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AuthorId",
                table: "Messages",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Referees_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "Referees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Referees_AuthorId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AuthorId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Name of the message creator");

            migrationBuilder.AlterColumn<Guid>(
                name: "RefereeSquadId",
                table: "Matches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "The referee squad appointed to officiate the match",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true,
                oldComment: "The referee squad appointed to officiate the match");
        }
    }
}
