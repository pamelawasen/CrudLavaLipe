using Microsoft.EntityFrameworkCore.Migrations;

namespace LavaLipe.Migrations
{
    public partial class Alter_table_Cliente_add_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Excluido",
                table: "ClienteModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "ClienteModel");
        }
    }
}
