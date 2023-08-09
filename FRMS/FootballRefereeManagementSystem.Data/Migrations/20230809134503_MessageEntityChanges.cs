using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballRefereeManagementSystem.Data.Migrations
{
    public partial class MessageEntityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete value");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "User who created the message");

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
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 18, 13, 38, 140, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 18, 13, 38, 140, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 18, 13, 38, 140, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("065a8654-fc52-43b4-8d3d-7e90a87e2bd9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2a2ea8a-31a0-4444-a3fb-858b6bf99b17", "AQAAAAEAACcQAAAAEFRWY+YVXSawF+/RNe/7M0np4mzMmHyAEAh/txWTx0G7dcAYJtxIxuUEyi0MhfLVSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e48bbc8-cbf0-494c-89e0-6bcccc36cc6a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3f0cebd-301c-4f86-b1c7-c63593c28b48", "AQAAAAEAACcQAAAAEHYzGvBLEaBVYjR92lpNuMgJdvdSTa/Z3E+CsThnXBO9hQhexIrx4dOgQ34cSAvfuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("35e56d1c-a7c2-445d-9eb5-0cdaecb0ebb1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8c0f199-3b6c-46f7-9e3d-0f36741a344c", "AQAAAAEAACcQAAAAEOwhG0oNugS7ZKWEP4p3VDtQBH403vzpAtPMSsDMOoBzw4fRzkRlaJWvBegHVdZ06w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9f18631-5bdb-4b41-86f4-8d6dbe71efb6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc59af64-c76f-4101-857d-0a57de687137", "AQAAAAEAACcQAAAAEOjl/79hWrSz95xuuXRZyGZK0yGPjRgmZBOYQVqdxSEoHTnOg7/hVH6BD9n/fFqlaw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea01fe26-36c8-4daa-b1c8-8b9209e82478"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd962470-2ddb-4652-8e6b-9a5600bf494c", "AQAAAAEAACcQAAAAEMtoqXXtq44L9Y+jjCqW+XAsnqKO7P+8kcqCKWYOIWRVevyEBSig7luexdyp2ETDFw==" });
        }
    }
}
