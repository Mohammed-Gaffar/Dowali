using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Financial_Sections",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Project_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Wages_Salaries = table.Column<double>(type: "float", nullable: false),
                    Equepment_And_Accessories = table.Column<double>(type: "float", nullable: false),
                    consumable = table.Column<double>(type: "float", nullable: false),
                    Exchange_Visits = table.Column<double>(type: "float", nullable: false),
                    Other_Expendtiure_items = table.Column<double>(type: "float", nullable: false),
                    External_Partner_Contract_include_Tax = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial_Sections", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Investigators",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Academic_Rank = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Of_Institiution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    College_Center = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Office_Phone = table.Column<int>(type: "int", nullable: false),
                    Mobile_Number = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Inv_Type = table.Column<int>(type: "int", nullable: false),
                    Project_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigators", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
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
                    owner = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    File_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_owner",
                table: "Projects",
                column: "owner",
                unique: true);
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
