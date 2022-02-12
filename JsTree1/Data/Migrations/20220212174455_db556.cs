using Microsoft.EntityFrameworkCore.Migrations;

namespace JsTree1.Data.Migrations
{
    public partial class db556 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "num",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "num",
                table: "Categories");
        }
    }
}
