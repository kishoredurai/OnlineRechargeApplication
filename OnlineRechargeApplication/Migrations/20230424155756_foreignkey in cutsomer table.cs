using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class foreignkeyincutsomertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceProvider",
                table: "CustomerModel");

            migrationBuilder.AddColumn<int>(
                name: "ServiceProviderId",
                table: "CustomerModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModel_ServiceProviderId",
                table: "CustomerModel",
                column: "ServiceProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerModel_ServiceProviderModel_ServiceProviderId",
                table: "CustomerModel",
                column: "ServiceProviderId",
                principalTable: "ServiceProviderModel",
                principalColumn: "ServiceProviderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerModel_ServiceProviderModel_ServiceProviderId",
                table: "CustomerModel");

            migrationBuilder.DropIndex(
                name: "IX_CustomerModel_ServiceProviderId",
                table: "CustomerModel");

            migrationBuilder.DropColumn(
                name: "ServiceProviderId",
                table: "CustomerModel");

            migrationBuilder.AddColumn<string>(
                name: "ServiceProvider",
                table: "CustomerModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
