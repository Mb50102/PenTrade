using Microsoft.EntityFrameworkCore.Migrations;

namespace PenTrade.WebMvc.Migrations
{
    public partial class AddIsOfferToBuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           // migrationBuilder.DropForeignKey(
              //  name: "FK_CurrentStocks_Merchandises_MerchandiseId",
                //table: "CurrentStocks");

            migrationBuilder.AddColumn<bool>(
                name: "IsOfferToBuy",
                table: "Offers",
                nullable: false,
                defaultValue: false);

        //    migrationBuilder.AlterColumn<int>(
        //        name: "MerchandiseId",
        //        table: "CurrentStocks",
        //        nullable: false,
        //        oldClrType: typeof(int),
        //        oldNullable: true);

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_CurrentStocks_Merchandises_MerchandiseId",
        //        table: "CurrentStocks",
        //        column: "MerchandiseId",
        //        principalTable: "Merchandises",
        //        principalColumn: "Id",
        //        onDelete: ReferentialAction.Cascade);
        //
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentStocks_Merchandises_MerchandiseId",
                table: "CurrentStocks");

            migrationBuilder.DropColumn(
                name: "IsOfferToBuy",
                table: "Offers");

            migrationBuilder.AlterColumn<int>(
                name: "MerchandiseId",
                table: "CurrentStocks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentStocks_Merchandises_MerchandiseId",
                table: "CurrentStocks",
                column: "MerchandiseId",
                principalTable: "Merchandises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
