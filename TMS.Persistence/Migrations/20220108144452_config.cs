using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.Persistence.Migrations
{
    public partial class config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticipants_Users_UserId",
                table: "ProjectParticipants");

            migrationBuilder.DropIndex(
                name: "IX_ProjectParticipants_ProjectId",
                table: "ProjectParticipants");

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "ProjectStatus",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProjectParticipants",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProjectStatus_StatusName",
                table: "ProjectStatus",
                column: "StatusName");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ProjectParticipants_ProjectId_UserId",
                table: "ProjectParticipants",
                columns: new[] { "ProjectId", "UserId" });

            migrationBuilder.InsertData(
                table: "ProjectStatus",
                columns: new[] { "Id", "StatusName" },
                values: new object[] { 1, "Open" });

            migrationBuilder.InsertData(
                table: "ProjectStatus",
                columns: new[] { "Id", "StatusName" },
                values: new object[] { 2, "Close" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticipants_Users_UserId",
                table: "ProjectParticipants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectParticipants_Users_UserId",
                table: "ProjectParticipants");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProjectStatus_StatusName",
                table: "ProjectStatus");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ProjectParticipants_ProjectId_UserId",
                table: "ProjectParticipants");

            migrationBuilder.DeleteData(
                table: "ProjectStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "ProjectStatus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProjectParticipants",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticipants_ProjectId",
                table: "ProjectParticipants",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectParticipants_Users_UserId",
                table: "ProjectParticipants",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
