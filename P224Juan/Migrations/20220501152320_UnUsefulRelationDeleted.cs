using Microsoft.EntityFrameworkCore.Migrations;

namespace P224Juan.Migrations
{
    public partial class UnUsefulRelationDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogtoCategories_BlogTags_BlogTagId",
                table: "BlogtoCategories");

            migrationBuilder.DropIndex(
                name: "IX_BlogtoCategories_BlogTagId",
                table: "BlogtoCategories");

            migrationBuilder.DropColumn(
                name: "BlogTagId",
                table: "BlogtoCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogTagId",
                table: "BlogtoCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogtoCategories_BlogTagId",
                table: "BlogtoCategories",
                column: "BlogTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogtoCategories_BlogTags_BlogTagId",
                table: "BlogtoCategories",
                column: "BlogTagId",
                principalTable: "BlogTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
