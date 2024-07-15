using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create_Projects_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Internal_Inv_Id = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    External_Int_Id = table.Column<int>(type: "int", maxLength: 255, nullable: false),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
