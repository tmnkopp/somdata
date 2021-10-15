using Microsoft.EntityFrameworkCore.Migrations;

namespace SOMData.Migrations
{
    public partial class Comp_PostTermReplace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostReplaceTerms",
                table: "CompilationWorkspaces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostReplaceTerms",
                table: "CompilationWorkspaces");
        }
    }
}
