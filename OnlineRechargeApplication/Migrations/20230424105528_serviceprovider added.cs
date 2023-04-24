using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class serviceprovideradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceProviderModel",
                columns: table => new
                {
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviderModel", x => x.ServiceProviderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceProviderModel");
        }
    }
}
