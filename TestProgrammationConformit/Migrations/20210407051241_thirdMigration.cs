using Microsoft.EntityFrameworkCore.Migrations;

namespace TestProgrammationConformit.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "evenementEvent",
                table: "commentaires",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_commentaires_evenementEvent",
                table: "commentaires",
                column: "evenementEvent");

            migrationBuilder.AddForeignKey(
                name: "FK_commentaires_evenements_evenementEvent",
                table: "commentaires",
                column: "evenementEvent",
                principalTable: "evenements",
                principalColumn: "Event",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_commentaires_evenements_evenementEvent",
                table: "commentaires");

            migrationBuilder.DropIndex(
                name: "IX_commentaires_evenementEvent",
                table: "commentaires");

            migrationBuilder.DropColumn(
                name: "evenementEvent",
                table: "commentaires");
        }
    }
}
