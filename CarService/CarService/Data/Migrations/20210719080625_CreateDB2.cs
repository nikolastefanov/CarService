using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.Data.Migrations
{
    public partial class CreateDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Mechanics_MechanicId1",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_MechanicId1",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "MechanicId1",
                table: "Works");

            migrationBuilder.AlterColumn<int>(
                name: "MechanicId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_MechanicId",
                table: "Works",
                column: "MechanicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Mechanics_MechanicId",
                table: "Works",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Mechanics_MechanicId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_MechanicId",
                table: "Works");

            migrationBuilder.AlterColumn<string>(
                name: "MechanicId",
                table: "Works",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MechanicId1",
                table: "Works",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_MechanicId1",
                table: "Works",
                column: "MechanicId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Mechanics_MechanicId1",
                table: "Works",
                column: "MechanicId1",
                principalTable: "Mechanics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
