using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_shop_2.Migrations
{
    /// <inheritdoc />
    public partial class Admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Admin",
              columns: table => new
              {
               AId = table.Column<int>(type:"nvarchar(max)", nullable: false),
               AName = table.Column<string>(type:"nvarchar(max)",nullable:false),
               Sales = table.Column<int>(type:"int",nullable:false),
               Purchases = table.Column<decimal>(type:"decimal",nullable: false),
               countOfEmloyees = table.Column<int>(type: "int",nullable: false),
               countOfSales = table.Column<int>(type: "int", nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Employee", x => x.AId);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
