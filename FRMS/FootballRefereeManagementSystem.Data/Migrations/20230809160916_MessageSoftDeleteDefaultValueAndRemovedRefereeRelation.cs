using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class MessageSoftDeleteDefaultValueAndRemovedRefereeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "Soft delete value",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Soft delete value");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 16, 9, 15, 388, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2941b6d-9e2a-4983-a52b-cbf5e6987d4d", "AQAAAAEAACcQAAAAEDmlvKUB360yC2q38GYwd0+DVEGNvAGR5ojhBWopd9VZ9zLxRIBdGAnFhaTeVpkxzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3899e519-88a0-4cbf-993e-9dffd3e1f8a3", "AQAAAAEAACcQAAAAEObwVPiIqJC2opIOUuUUaFfJIcBKFD7sCSiikArAMnREmfyxWu7UKzviCaB8UdwJwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "945b8757-0ea0-4a15-8b52-d801b019b495", "AQAAAAEAACcQAAAAEK4Es45HBx6xh9HVP6Mvw4lr7lizf8VvcMTSWkuIqzHkGl1cVehroLqA/3VeMS79/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5dc0f90c-eda7-4fff-80dc-6931b1174852", "AQAAAAEAACcQAAAAEN59L55RvJjo6L+clLvejACU1M0/Hlz7sZYEHaMkN5puiap85h5lBGoyVyWH7mPz8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69cf2ce8-a33d-4455-941c-65c3184615fe", "AQAAAAEAACcQAAAAEGfDHJiRrEfDT7QglrqOTxT5OC5luPfx9VDSIz312EvUWNcXEGcLqzgaCgj3SnJGbw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Messages",
                type: "bit",
                nullable: false,
                comment: "Soft delete value",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true,
                oldComment: "Soft delete value");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Referee who created the message");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 45, 2, 407, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 45, 2, 407, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 45, 2, 407, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bada5b28-71ff-4aba-875c-8443fe7c8ef4", "AQAAAAEAACcQAAAAEMQDB/aalLZEm1VTba6ZxmN3U1J317/a5vMYRMxZf6qcT5BmVyhk1cGJGKr2NEOlYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1028bab1-21de-4645-87b8-dd89e5b251ec", "AQAAAAEAACcQAAAAEPKISbKXQYbnIVLU+5LIvb8AwcYfWDVZQwAbbPCJ8D8WGN9Fg8c8+qzGpiR3gQ/xRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bba562a1-4e2f-47ee-a3ff-c8fbbfce409d", "AQAAAAEAACcQAAAAEMjefz+bmxQcc8ffSSSCL6zNZsSbTcc97OpFkf1FvJh60ijqmMyMD/WVyHs7JHdxdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5150cb0d-23fa-4658-b961-e3828d7919e0", "AQAAAAEAACcQAAAAEPl3QwqMWrF2NT9mkYb1d9TjrTzP0f11VMcDKVY5iwZFdGfMFCZY7lSiRvupZG1s2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f8b617c-2f56-4f63-af23-c496f6a0f32f", "AQAAAAEAACcQAAAAEID6P/6qdB/ctJyCqnSEphPBrg8s6mKkxC27IXtSwLgUEbcfycHPQrn9TOFqSt2dYw==" });

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
    }
}
