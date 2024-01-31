using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitWord.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Plan",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Meal",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 3,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 2,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 3,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Plan_ApplicationUserId",
                table: "Plan",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Meal_ApplicationUserId",
                table: "Meal",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meal_AspNetUsers_ApplicationUserId",
                table: "Meal",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_AspNetUsers_ApplicationUserId",
                table: "Plan",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meal_AspNetUsers_ApplicationUserId",
                table: "Meal");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_AspNetUsers_ApplicationUserId",
                table: "Plan");

            migrationBuilder.DropIndex(
                name: "IX_Plan_ApplicationUserId",
                table: "Plan");

            migrationBuilder.DropIndex(
                name: "IX_Meal_ApplicationUserId",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Plan");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Meal");
        }
    }
}
