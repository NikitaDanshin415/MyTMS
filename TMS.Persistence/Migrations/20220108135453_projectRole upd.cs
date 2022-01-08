using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Persistence.Migrations
{
    public partial class projectRoleupd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectRoleId",
                table: "ProjectParticipants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipants_ProjectRoleId",
                table: "ProjectParticipants",
                column: "ProjectRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticipants_ProjectRoles_ProjectRoleId",
                table: "ProjectParticipants",
                column: "ProjectRoleId",
                principalTable: "ProjectRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticipants_ProjectRoles_ProjectRoleId",
                table: "ProjectParticipants");

            migrationBuilder.DropIndex(
                name: "IX_ProjectParticipants_ProjectRoleId",
                table: "ProjectParticipants");

            migrationBuilder.DropColumn(
                name: "ProjectRoleId",
                table: "ProjectParticipants");
        }
    }
}
