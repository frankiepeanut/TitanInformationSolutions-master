using Microsoft.EntityFrameworkCore.Migrations;

namespace TitanInformationSolutions.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "BGCPrograms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "BGCPrograms",
                nullable: false,
                defaultValue: 0);
        }
    }
}
