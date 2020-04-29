using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOMData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompilationWorkspaces",
                columns: table => new
                {
                    CompilationWorkspaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompilationTitle = table.Column<string>(nullable: true),
                    Command = table.Column<string>(nullable: true),
                    CommandParams = table.Column<string>(nullable: true),
                    CompileFrom = table.Column<string>(nullable: true),
                    CompileTo = table.Column<string>(nullable: true),
                    WrapExpression = table.Column<string>(nullable: true),
                    ReplaceTerms = table.Column<string>(nullable: true),
                    ParseLines = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompilationWorkspaces", x => x.CompilationWorkspaceId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompilationWorkspaces");
        }
    }
}
