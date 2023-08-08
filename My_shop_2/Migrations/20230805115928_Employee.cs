using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_shop_2.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Employee",
                columns: table => new
                {
                    EId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal", nullable: false),
                    CountOfSalesPerMonth = table.Column<int>(type: "int", nullable: false),
                    JobTittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfBirth = table.Column<DateTime>(type:"datetime2", nullable: false),
                    YearOfStartWorking = table.Column<DateTime>(type:"datetime2", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EId);
                }) ;
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

        }
    }
}
