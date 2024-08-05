using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Change_table_Name_Researches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Douration = table.Column<int>(type: "int", nullable: false),
                    Summary_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Summary_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Main_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sub_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    satatus = table.Column<int>(type: "int", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    File_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Researches_owner",
                table: "Researches",
                column: "owner",
                unique: true,
                filter: "[owner] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Douration = table.Column<int>(type: "int", nullable: false),
                    File_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Main_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sub_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Summary_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Summary_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    satatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_owner",
                table: "Projects",
                column: "owner",
                unique: true);
        }
    }
}
