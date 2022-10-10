using Microsoft.EntityFrameworkCore.Migrations;

namespace Front_to_back_fiorello.Migrations
{
    public partial class CratTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SliderDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "SliderDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignImage",
                table: "SliderDetails",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SliderDetails");

            migrationBuilder.DropColumn(
                name: "Header",
                table: "SliderDetails");

            migrationBuilder.DropColumn(
                name: "SignImage",
                table: "SliderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
