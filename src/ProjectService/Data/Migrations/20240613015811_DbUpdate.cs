using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectService.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Majors",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Compensation",
                table: "Projects",
                newName: "CompensationType");

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationId",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "Wage",
                table: "Projects",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Acronym = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MajorProject",
                columns: table => new
                {
                    MajorsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorProject", x => new { x.MajorsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_MajorProject_Major_MajorsId",
                        column: x => x.MajorsId,
                        principalTable: "Major",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajorProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OrganizationId",
                table: "Projects",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_MajorProject_ProjectsId",
                table: "MajorProject",
                column: "ProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Organization_OrganizationId",
                table: "Projects",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Organization_OrganizationId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "MajorProject");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OrganizationId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Wage",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "CompensationType",
                table: "Projects",
                newName: "Compensation");

            migrationBuilder.AddColumn<int[]>(
                name: "Majors",
                table: "Projects",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "Projects",
                type: "text",
                nullable: true);
        }
    }
}
