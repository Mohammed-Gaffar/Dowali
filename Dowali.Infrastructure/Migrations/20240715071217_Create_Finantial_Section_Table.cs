using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create_Finantial_Section_Table : Migration
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
                    Totlal = table.Column<double>(type: "float", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial_Sections", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Financial_Sections");
        }
    }
}
