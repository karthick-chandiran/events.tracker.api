using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventTracker.Migrations
{
    public partial class AddDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventDescription",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDescription",
                table: "Events");
        }
    }
}
