using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_U_W_U.Migrations
{
    public partial class FixRoomHotelRoomImageRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roomImages_rooms_roomID",
                table: "roomImages");

            migrationBuilder.DropIndex(
                name: "IX_roomImages_roomID",
                table: "roomImages");

            migrationBuilder.AddColumn<int>(
                name: "hotelID",
                table: "roomImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_roomImages_hotelID",
                table: "roomImages",
                column: "hotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_roomImages_rooms_hotelID",
                table: "roomImages",
                column: "hotelID",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roomImages_rooms_hotelID",
                table: "roomImages");

            migrationBuilder.DropIndex(
                name: "IX_roomImages_hotelID",
                table: "roomImages");

            migrationBuilder.DropColumn(
                name: "hotelID",
                table: "roomImages");

            migrationBuilder.CreateIndex(
                name: "IX_roomImages_roomID",
                table: "roomImages",
                column: "roomID");

            migrationBuilder.AddForeignKey(
                name: "FK_roomImages_rooms_roomID",
                table: "roomImages",
                column: "roomID",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
