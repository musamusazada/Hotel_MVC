using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_U_W_U.Migrations
{
    public partial class ReservationForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_rooms_roomid",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "roomid",
                table: "Reservations",
                newName: "roomID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_roomid",
                table: "Reservations",
                newName: "IX_Reservations_roomID");

            migrationBuilder.AlterColumn<int>(
                name: "roomID",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_rooms_roomID",
                table: "Reservations",
                column: "roomID",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_rooms_roomID",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "roomID",
                table: "Reservations",
                newName: "roomid");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_roomID",
                table: "Reservations",
                newName: "IX_Reservations_roomid");

            migrationBuilder.AlterColumn<int>(
                name: "roomid",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_rooms_roomid",
                table: "Reservations",
                column: "roomid",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
