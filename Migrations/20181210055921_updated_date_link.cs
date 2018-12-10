using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class updated_date_link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "LinkModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "LinkModels");
        }
    }
}
