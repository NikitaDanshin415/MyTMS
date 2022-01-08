using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Persistence.Migrations
{
    public partial class TestStepsResultresults2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestCaseResultResultId",
                table: "TestCaseResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseResults_TestCaseResultResultId",
                table: "TestCaseResults",
                column: "TestCaseResultResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCaseResults_TestCaseResultResults_TestCaseResultResultId",
                table: "TestCaseResults",
                column: "TestCaseResultResultId",
                principalTable: "TestCaseResultResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCaseResults_TestCaseResultResults_TestCaseResultResultId",
                table: "TestCaseResults");

            migrationBuilder.DropIndex(
                name: "IX_TestCaseResults_TestCaseResultResultId",
                table: "TestCaseResults");

            migrationBuilder.DropColumn(
                name: "TestCaseResultResultId",
                table: "TestCaseResults");
        }
    }
}
