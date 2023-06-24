using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsesslayer.Migrations
{
    public partial class mig_foreing_key8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Web",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Web",
                table: "Guides");
        }
    }
}
