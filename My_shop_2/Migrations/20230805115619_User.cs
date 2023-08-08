using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace My_shop_2.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "User",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false),
                  Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Age = table.Column<int>(type:"int", nullable: false),
                  Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_User", x => x.Id);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
