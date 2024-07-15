using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Create_Investigators_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigators",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Int_Inv_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Int_Inv_Academic_Rank = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    int_Inv_Department = table.Column<int>(type: "int", nullable: false),
                    Int_Inv_Address_Of_Institiution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Int_inv_College_Center = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Int_Inv_Office_Phone = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    int_Inv_Mobile_Number = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Int_Inv_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ex_Inv_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ext_Inv_Academic_Rank = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Ext_Inv_Department = table.Column<int>(type: "int", nullable: false),
                    Ext_Inv_Address_Of_Institiution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ext_inv_College_Center = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ext_Inv_Office_Phone = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Ext_Inv_Mobile_Number = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Ext_Inv_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Inv_Type = table.Column<int>(type: "int", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigators", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigators");
        }
    }
}
