using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcsesslayer.Migrations
{
    public partial class mig_commentuser_remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentUser",
                table: "Commentlers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentUser",
                table: "Commentlers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
