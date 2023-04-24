using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class planmodeladded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanModel",
                columns: table => new
                {
                    planId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planPrice = table.Column<int>(type: "int", nullable: false),
                    planValidity = table.Column<int>(type: "int", nullable: false),
                    ServiceProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanModel", x => x.planId);
                    table.ForeignKey(
                        name: "FK_PlanModel_ServiceProviderModel_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalTable: "ServiceProviderModel",
                        principalColumn: "ServiceProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanModel_ServiceProviderId",
                table: "PlanModel",
                column: "ServiceProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanModel");
        }
    }
}
