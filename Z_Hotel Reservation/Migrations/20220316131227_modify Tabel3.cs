using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation.Migrations
{
    public partial class modifyTabel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPerPerson_MealType_MealTypeId",
                table: "MealPerPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_MealPlane_MealType_MealTypeId",
                table: "MealPlane");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPerPerson_MealType_MealTypeId",
                table: "MealPerPerson",
                column: "MealTypeId",
                principalTable: "MealType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlane_MealType_MealTypeId",
                table: "MealPlane",
                column: "MealTypeId",
                principalTable: "MealType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealPerPerson_MealType_MealTypeId",
                table: "MealPerPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_MealPlane_MealType_MealTypeId",
                table: "MealPlane");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPerPerson_MealType_MealTypeId",
                table: "MealPerPerson",
                column: "MealTypeId",
                principalTable: "MealType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MealPlane_MealType_MealTypeId",
                table: "MealPlane",
                column: "MealTypeId",
                principalTable: "MealType",
                principalColumn: "Id");
        }
    }
}
