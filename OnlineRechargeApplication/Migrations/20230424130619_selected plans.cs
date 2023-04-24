using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRechargeApplication.Migrations
{
    public partial class selectedplans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SelectedPlanModel",
                columns: table => new
                {
                    SelectedPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedPlanModel", x => x.SelectedPlanId);
                    table.ForeignKey(
                        name: "FK_SelectedPlanModel_CustomerModel_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerModel",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedPlanModel_PlanModel_planId",
                        column: x => x.planId,
                        principalTable: "PlanModel",
                        principalColumn: "planId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedPlanModel_CustomerId",
                table: "SelectedPlanModel",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedPlanModel_planId",
                table: "SelectedPlanModel",
                column: "planId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedPlanModel");
        }
    }
}
