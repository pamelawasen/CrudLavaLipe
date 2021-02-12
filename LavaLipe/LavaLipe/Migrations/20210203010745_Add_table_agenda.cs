using Microsoft.EntityFrameworkCore.Migrations;

namespace LavaLipe.Migrations
{
    public partial class Add_table_agenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "AgendaModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "AgendaModels",
                nullable: false,
                defaultValue: 0);
        }
    }
}
