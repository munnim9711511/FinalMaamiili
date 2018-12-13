using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class titleprimary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleryModels",
                table: "GalleryModels");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GalleryModels");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "GalleryModels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleryModels",
                table: "GalleryModels",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GalleryModels",
                table: "GalleryModels");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "GalleryModels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GalleryModels",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GalleryModels",
                table: "GalleryModels",
                column: "Id");
        }
    }
}
