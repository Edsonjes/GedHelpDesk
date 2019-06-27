using Microsoft.EntityFrameworkCore.Migrations;

namespace GedHelpDesk.Migrations
{
    public partial class intrementalChamados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ramal",
                table: "Chamados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Setor",
                table: "Chamados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Chamados",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ramal",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "Setor",
                table: "Chamados");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Chamados");
        }
    }
}
