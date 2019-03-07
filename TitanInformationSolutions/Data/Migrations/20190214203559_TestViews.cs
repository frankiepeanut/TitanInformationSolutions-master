using Microsoft.EntityFrameworkCore.Migrations;

namespace TitanInformationSolutions.Data.Migrations
{
    public partial class TestViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Program_BGCPrograms_BGCProgramsID",
                table: "Child_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Program_Child_ChildID",
                table: "Child_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Program_Parent_ParentID",
                table: "Child_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Program_Section_SectionID",
                table: "Child_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Program_Section_SectionID",
                table: "Instructor_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Program_Instructor_instructorID",
                table: "Instructor_Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor_Program",
                table: "Instructor_Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Child_Program",
                table: "Child_Program");

            migrationBuilder.RenameTable(
                name: "Instructor_Program",
                newName: "instructor_Sections");

            migrationBuilder.RenameTable(
                name: "Child_Program",
                newName: "child_Sections");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Program_instructorID",
                table: "instructor_Sections",
                newName: "IX_instructor_Sections_instructorID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_Program_SectionID",
                table: "instructor_Sections",
                newName: "IX_instructor_Sections_SectionID");

            migrationBuilder.RenameIndex(
                name: "IX_Child_Program_SectionID",
                table: "child_Sections",
                newName: "IX_child_Sections_SectionID");

            migrationBuilder.RenameIndex(
                name: "IX_Child_Program_ParentID",
                table: "child_Sections",
                newName: "IX_child_Sections_ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_Child_Program_ChildID",
                table: "child_Sections",
                newName: "IX_child_Sections_ChildID");

            migrationBuilder.RenameIndex(
                name: "IX_Child_Program_BGCProgramsID",
                table: "child_Sections",
                newName: "IX_child_Sections_BGCProgramsID");

            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_instructor_Sections",
                table: "instructor_Sections",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_child_Sections",
                table: "child_Sections",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_child_Sections_BGCPrograms_BGCProgramsID",
                table: "child_Sections",
                column: "BGCProgramsID",
                principalTable: "BGCPrograms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_child_Sections_Child_ChildID",
                table: "child_Sections",
                column: "ChildID",
                principalTable: "Child",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_child_Sections_Parent_ParentID",
                table: "child_Sections",
                column: "ParentID",
                principalTable: "Parent",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_child_Sections_Section_SectionID",
                table: "child_Sections",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_Sections_Section_SectionID",
                table: "instructor_Sections",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_Sections_Instructor_instructorID",
                table: "instructor_Sections",
                column: "instructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_child_Sections_BGCPrograms_BGCProgramsID",
                table: "child_Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_child_Sections_Child_ChildID",
                table: "child_Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_child_Sections_Parent_ParentID",
                table: "child_Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_child_Sections_Section_SectionID",
                table: "child_Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_Sections_Section_SectionID",
                table: "instructor_Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_Sections_Instructor_instructorID",
                table: "instructor_Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_instructor_Sections",
                table: "instructor_Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_child_Sections",
                table: "child_Sections");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "instructor_Sections",
                newName: "Instructor_Program");

            migrationBuilder.RenameTable(
                name: "child_Sections",
                newName: "Child_Program");

            migrationBuilder.RenameIndex(
                name: "IX_instructor_Sections_instructorID",
                table: "Instructor_Program",
                newName: "IX_Instructor_Program_instructorID");

            migrationBuilder.RenameIndex(
                name: "IX_instructor_Sections_SectionID",
                table: "Instructor_Program",
                newName: "IX_Instructor_Program_SectionID");

            migrationBuilder.RenameIndex(
                name: "IX_child_Sections_SectionID",
                table: "Child_Program",
                newName: "IX_Child_Program_SectionID");

            migrationBuilder.RenameIndex(
                name: "IX_child_Sections_ParentID",
                table: "Child_Program",
                newName: "IX_Child_Program_ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_child_Sections_ChildID",
                table: "Child_Program",
                newName: "IX_Child_Program_ChildID");

            migrationBuilder.RenameIndex(
                name: "IX_child_Sections_BGCProgramsID",
                table: "Child_Program",
                newName: "IX_Child_Program_BGCProgramsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor_Program",
                table: "Instructor_Program",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Child_Program",
                table: "Child_Program",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Program_BGCPrograms_BGCProgramsID",
                table: "Child_Program",
                column: "BGCProgramsID",
                principalTable: "BGCPrograms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Program_Child_ChildID",
                table: "Child_Program",
                column: "ChildID",
                principalTable: "Child",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Program_Parent_ParentID",
                table: "Child_Program",
                column: "ParentID",
                principalTable: "Parent",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Program_Section_SectionID",
                table: "Child_Program",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Program_Section_SectionID",
                table: "Instructor_Program",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Program_Instructor_instructorID",
                table: "Instructor_Program",
                column: "instructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
