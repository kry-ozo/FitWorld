using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitWord.Migrations
{
    /// <inheritdoc />
    public partial class addRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PlanOwnerId",
                table: "Plan",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MealOwnerId",
                table: "Meal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 1,
                column: "MealOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 2,
                column: "MealOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 3,
                column: "MealOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 1,
                column: "PlanOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 2,
                column: "PlanOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 3,
                column: "PlanOwnerId",
                value: "f20b2581-3c7f-469c-ac8a-d574be99e067");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_PlanOwnerId",
                table: "Plan",
                column: "PlanOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Meal_MealOwnerId",
                table: "Meal",
                column: "MealOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meal_AspNetUsers_MealOwnerId",
                table: "Meal",
                column: "MealOwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_AspNetUsers_PlanOwnerId",
                table: "Plan",
                column: "PlanOwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meal_AspNetUsers_MealOwnerId",
                table: "Meal");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_AspNetUsers_PlanOwnerId",
                table: "Plan");

            migrationBuilder.DropIndex(
                name: "IX_Plan_PlanOwnerId",
                table: "Plan");

            migrationBuilder.DropIndex(
                name: "IX_Meal_MealOwnerId",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "PlanOwnerId",
                table: "Plan");

            migrationBuilder.DropColumn(
                name: "MealOwnerId",
                table: "Meal");

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
    }
}
