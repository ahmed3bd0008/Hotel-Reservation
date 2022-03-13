using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation.Migrations
{
    public partial class addpersontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomRate_RoomRateRoomTypeId_RoomRateFromDate_RoomRateToDate",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomRateRoomTypeId_RoomRateFromDate_RoomRateToDate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomRateFromDate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomRateId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomRateRoomTypeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomRateToDate",
                table: "Rooms");

            migrationBuilder.CreateTable(
                name: "ReservesٌRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservesٌRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservesٌRoom_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReservesٌRoom_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservesٌRoom_PersonId",
                table: "ReservesٌRoom",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservesٌRoom_RoomId",
                table: "ReservesٌRoom",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservesٌRoom");

            migrationBuilder.AddColumn<DateTime>(
                name: "RoomRateFromDate",
                table: "Rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomRateId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomRateRoomTypeId",
                table: "Rooms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RoomRateToDate",
                table: "Rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomRateRoomTypeId_RoomRateFromDate_RoomRateToDate",
                table: "Rooms",
                columns: new[] { "RoomRateRoomTypeId", "RoomRateFromDate", "RoomRateToDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomRate_RoomRateRoomTypeId_RoomRateFromDate_RoomRateToDate",
                table: "Rooms",
                columns: new[] { "RoomRateRoomTypeId", "RoomRateFromDate", "RoomRateToDate" },
                principalTable: "RoomRate",
                principalColumns: new[] { "RoomTypeId", "FromDate", "ToDate" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
