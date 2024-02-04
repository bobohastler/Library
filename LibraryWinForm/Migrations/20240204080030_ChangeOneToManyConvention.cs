﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWinForm.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOneToManyConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "tblBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "tblBooks");
        }
    }
}