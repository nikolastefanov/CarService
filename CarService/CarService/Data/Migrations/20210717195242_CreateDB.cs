using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Data.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mechanics_AspNetUsers_UserId1",
                table: "Mechanics");

            migrationBuilder.DropIndex(
                name: "IX_Mechanics_UserId1",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Mechanics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Mechanics",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Mechanics_UserId1",
                table: "Mechanics",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Mechanics_AspNetUsers_UserId1",
                table: "Mechanics",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
