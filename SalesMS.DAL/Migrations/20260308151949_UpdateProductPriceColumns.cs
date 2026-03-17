using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductPriceColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "salePrice");

            migrationBuilder.AddColumn<decimal>(
                name: "costPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "salePrice",
                table: "Products",
                newName: "Price");
        }
    }
}
