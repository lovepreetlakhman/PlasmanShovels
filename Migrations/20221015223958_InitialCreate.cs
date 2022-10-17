using Microsoft.EntityFrameworkCore.Migrations;

namespace PlasmanShovels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shovel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(nullable: true),
                    Usage = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shovel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shovel");
        }
    }
}
