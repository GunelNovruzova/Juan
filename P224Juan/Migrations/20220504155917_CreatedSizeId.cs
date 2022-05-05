using Microsoft.EntityFrameworkCore.Migrations;

namespace P224Juan.Migrations
{
    public partial class CreatedSizeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Colors_ColorId",
                table: "ProductColorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Products_ProductId",
                table: "ProductColorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Sizes_SizeId",
                table: "ProductColorSizes");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "ProductColorSizes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductColorSizes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "ProductColorSizes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Colors_ColorId",
                table: "ProductColorSizes",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Products_ProductId",
                table: "ProductColorSizes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Sizes_SizeId",
                table: "ProductColorSizes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Colors_ColorId",
                table: "ProductColorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Products_ProductId",
                table: "ProductColorSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColorSizes_Sizes_SizeId",
                table: "ProductColorSizes");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "ProductColorSizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductColorSizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "ProductColorSizes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Colors_ColorId",
                table: "ProductColorSizes",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Products_ProductId",
                table: "ProductColorSizes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColorSizes_Sizes_SizeId",
                table: "ProductColorSizes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
