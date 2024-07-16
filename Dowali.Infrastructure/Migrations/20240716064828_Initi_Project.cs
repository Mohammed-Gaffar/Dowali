using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initi_Project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Financial_Sections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_Id = table.Column<int>(type: "int", nullable: false),
                    Wages_Salaries = table.Column<double>(type: "float", nullable: false),
                    Equepment_And_Accessories = table.Column<double>(type: "float", nullable: false),
                    consumable = table.Column<double>(type: "float", nullable: false),
                    Exchange_Visits = table.Column<double>(type: "float", nullable: false),
                    Other_Expendtiure_items = table.Column<double>(type: "float", nullable: false),
                    External_Partner_Contract_include_Tax = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial_Sections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Investigators",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Academic_Rank = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Of_Institiution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    College_Center = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Office_Phone = table.Column<int>(type: "int", nullable: false),
                    Mobile_Number = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Inv_Type = table.Column<int>(type: "int", nullable: false),
                    Project_Id = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigators", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Title_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Douration = table.Column<int>(type: "int", nullable: false),
                    Summary_Ar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Summary_En = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Main_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sub_Field = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    File_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Financial_Sections");

            migrationBuilder.DropTable(
                name: "Investigators");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
