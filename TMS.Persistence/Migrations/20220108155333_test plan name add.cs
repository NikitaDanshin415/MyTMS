using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Persistence.Migrations
{
    public partial class testplannameadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestPlanName",
                table: "TestPlans",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestPlanName",
                table: "TestPlans");
        }
    }
}
