using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class AddedUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropPrimaryKey(
                name: "PK_DatingApp.API.Models.Value",
                table: "DatingApp.API.Models.Value");*/

            /*migrationBuilder.RenameTable(
                name: "DatingApp.API.Models.User",
                newName: "Users");*/

            /*migrationBuilder.AddPrimaryKey(
                name: "PK_Values",
                table: "Values",
                column: "Id");*/

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Values",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "DatingApp.API.Models.User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatingApp.API.Models.User",
                table: "DatingApp.API.Models.User",
                column: "Id");
        }
    }
}
