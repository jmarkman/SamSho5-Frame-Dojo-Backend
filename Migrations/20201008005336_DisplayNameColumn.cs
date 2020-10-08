using Microsoft.EntityFrameworkCore.Migrations;

namespace SamSho5SpcWebApi.Migrations
{
    public partial class DisplayNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Moves",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Moves");
        }
    }
}
