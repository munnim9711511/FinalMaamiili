using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class dateadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "anouncementsModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "anouncementsModels");
        }
    }
}
