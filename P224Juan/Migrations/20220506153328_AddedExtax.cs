using Microsoft.EntityFrameworkCore.Migrations;

namespace P224Juan.Migrations
{
    public partial class AddedExtax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ExTax",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExTax",
                table: "Products");
        }
    }
}
