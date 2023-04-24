using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class updateinplandetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "planDescription",
                table: "PlanModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "planDescription",
                table: "PlanModel");
        }
    }
}
