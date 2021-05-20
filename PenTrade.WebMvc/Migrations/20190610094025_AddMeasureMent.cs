using Microsoft.EntityFrameworkCore.Migrations;

namespace PenTrade.WebMvc.Migrations
{
    public partial class AddMeasureMent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MesaurmentUnit",
                table: "Merchandises",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MesaurmentUnit",
                table: "Merchandises");
        }
    }
}
