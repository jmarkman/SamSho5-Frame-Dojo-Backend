using Microsoft.EntityFrameworkCore.Migrations;

namespace SamSho5SpcWebApi.Migrations
{
    public partial class SummaryAndLore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    GameplayDetails = table.Column<string>(nullable: true),
                    Lore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: true),
                    StartupFrames = table.Column<int>(nullable: true),
                    ActiveFrames = table.Column<int>(nullable: true),
                    TotalFrames = table.Column<int>(nullable: true),
                    CancelWindowStart = table.Column<int>(nullable: true),
                    CancelWindowEnd = table.Column<int>(nullable: true),
                    LateCancelWindowStart = table.Column<int>(nullable: true),
                    LateCancelWindowEnd = table.Column<int>(nullable: true),
                    WeaponClashStart = table.Column<int>(nullable: true),
                    WeaponClashEnd = table.Column<int>(nullable: true),
                    LateWeaponClashStart = table.Column<int>(nullable: true),
                    LateWeaponClashEnd = table.Column<int>(nullable: true),
                    OnHit = table.Column<int>(nullable: true),
                    OnBackhit = table.Column<int>(nullable: true),
                    OnBlock = table.Column<int>(nullable: true),
                    CausesKnockdown = table.Column<bool>(nullable: false),
                    GuardStance = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moves_CharacterId",
                table: "Moves",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
