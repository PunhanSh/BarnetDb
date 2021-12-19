using Microsoft.EntityFrameworkCore.Migrations;

namespace BARNET.Migrations
{
    public partial class update7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subscribes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subscribes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
