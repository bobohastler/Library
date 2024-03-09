using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryWinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBooks_tblCategories_CategoryEntityCategoryId",
                table: "tblBooks");

            migrationBuilder.DropIndex(
                name: "IX_tblBooks_CategoryEntityCategoryId",
                table: "tblBooks");

            migrationBuilder.DropColumn(
                name: "CategoryEntityCategoryId",
                table: "tblBooks");

            migrationBuilder.CreateIndex(
                name: "IX_tblBooks_CategoryId",
                table: "tblBooks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBooks_tblCategories_CategoryId",
                table: "tblBooks",
                column: "CategoryId",
                principalTable: "tblCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblBooks_tblCategories_CategoryId",
                table: "tblBooks");

            migrationBuilder.DropIndex(
                name: "IX_tblBooks_CategoryId",
                table: "tblBooks");

            migrationBuilder.AddColumn<int>(
                name: "CategoryEntityCategoryId",
                table: "tblBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblBooks_CategoryEntityCategoryId",
                table: "tblBooks",
                column: "CategoryEntityCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblBooks_tblCategories_CategoryEntityCategoryId",
                table: "tblBooks",
                column: "CategoryEntityCategoryId",
                principalTable: "tblCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
