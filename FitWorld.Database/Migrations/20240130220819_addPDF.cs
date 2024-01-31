 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitWord.Migrations
{
    /// <inheritdoc />
    public partial class addPDF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "planName",
                table: "Plan",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "pdfPlan",
                table: "Plan",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "mealName",
                table: "Meal",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mealDescription",
                table: "Meal",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte[]>(
                name: "pdfMeal",
                table: "Meal",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 1,
                column: "pdfMeal",
                value: new byte[] { 69, 175 });

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 2,
                column: "pdfMeal",
                value: new byte[] { 69, 175 });

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "mealId",
                keyValue: 3,
                column: "pdfMeal",
                value: new byte[] { 69, 175 });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 1,
                column: "pdfPlan",
                value: new byte[] { 69, 175, 35 });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 2,
                column: "pdfPlan",
                value: new byte[] { 69, 175, 35 });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "planId",
                keyValue: 3,
                column: "pdfPlan",
                value: new byte[] { 69, 175, 35 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pdfPlan",
                table: "Plan");

            migrationBuilder.DropColumn(
                name: "pdfMeal",
                table: "Meal");

            migrationBuilder.AlterColumn<string>(
                name: "planName",
                table: "Plan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "mealName",
                table: "Meal",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "mealDescription",
                table: "Meal",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
