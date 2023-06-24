using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsesslayer.Migrations
{
    public partial class mig_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentlers_Destinations_DestinationID",
                table: "Commentlers");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationID",
                table: "Commentlers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentlers_Destinations_DestinationID",
                table: "Commentlers",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentlers_Destinations_DestinationID",
                table: "Commentlers");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationID",
                table: "Commentlers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentlers_Destinations_DestinationID",
                table: "Commentlers",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
