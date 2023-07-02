using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class ApplicationUserRefereeIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RefereeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                comment: "The navigation to the referee for this user",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The navigation to the referee for this user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RefereeId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The navigation to the referee for this user",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "The navigation to the referee for this user");
        }
    }
}
