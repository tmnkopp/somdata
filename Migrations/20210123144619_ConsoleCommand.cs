using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOMData.Migrations
{
    public partial class ConsoleCommand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsoleCommands",
                columns: table => new
                {
                    ConsoleCommandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommandLine = table.Column<string>(nullable: true),
                    CommandAssembly = table.Column<string>(nullable: true),
                    CommandType = table.Column<string>(nullable: true),
                    InstanceType = table.Column<string>(nullable: true),
                    CommandDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsoleCommands", x => x.ConsoleCommandID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsoleCommands");
        }
    }
}
