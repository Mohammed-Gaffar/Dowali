﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dowali.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Edit_Projects_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "int_Inv_Department",
                table: "Investigators",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "int_Inv_Department",
                table: "Investigators",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
