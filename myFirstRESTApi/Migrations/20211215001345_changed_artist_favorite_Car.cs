using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myFirstRESTApi.Migrations
{
    public partial class changed_artist_favorite_Car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteCar",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteCar",
                table: "Artists");
        }
    }
}
