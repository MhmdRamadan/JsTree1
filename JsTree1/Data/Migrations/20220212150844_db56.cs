using Microsoft.EntityFrameworkCore.Migrations;

namespace JsTree1.Data.Migrations
{
    public partial class db56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriesCars",
                table: "CategoriesCars");

            migrationBuilder.RenameTable(
                name: "CategoriesCars",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoriesCars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriesCars",
                table: "CategoriesCars",
                column: "Id");
        }
    }
}
