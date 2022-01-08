using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Persistence.Migrations
{
    public partial class TestStepsResult123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TestCaseResults",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseResults_UserId",
                table: "TestCaseResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCaseResults_Users_UserId",
                table: "TestCaseResults",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCaseResults_Users_UserId",
                table: "TestCaseResults");

            migrationBuilder.DropIndex(
                name: "IX_TestCaseResults_UserId",
                table: "TestCaseResults");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TestCaseResults");
        }
    }
}
