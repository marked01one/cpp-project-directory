using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectService.Data.Migrations
{
    /// <inheritdoc />
    public partial class Contacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "Projects",
                newName: "ContactsPhone");

            migrationBuilder.AddColumn<string>(
                name: "ContactsDiscord",
                table: "Projects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactsEmail",
                table: "Projects",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactsDiscord",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ContactsEmail",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ContactsPhone",
                table: "Projects",
                newName: "ContactEmail");
        }
    }
}
