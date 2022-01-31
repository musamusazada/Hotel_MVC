using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_U_W_U.Migrations
{
    public partial class UserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hasHotel",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasHotel",
                table: "AspNetUsers");
        }
    }
}
