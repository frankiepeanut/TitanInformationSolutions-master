using Microsoft.EntityFrameworkCore.Migrations;

namespace TitanInformationSolutions.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Parent_email",
                table: "Parent");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Instructor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Instructor");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_email",
                table: "Parent",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }
    }
}
