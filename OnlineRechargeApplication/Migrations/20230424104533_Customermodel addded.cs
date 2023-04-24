using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class Customermodeladdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerModel",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<int>(type: "int", nullable: false),
                    ServiceProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModel", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModel");
        }
    }
}
