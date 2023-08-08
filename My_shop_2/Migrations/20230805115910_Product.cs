using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_shop_2.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Product",
              columns: table => new
              {
                  PId = table.Column<int>(type: "int", nullable:false),
                  ProductName = table.Column<string>(type: "nvarchar(max)",nullable:false),
                  ProductCount = table.Column<int>(type: "int", nullable:false),
                  ProductPrice = table.Column<decimal>(type: "int", nullable:false),

              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Product", x => x.PId);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
