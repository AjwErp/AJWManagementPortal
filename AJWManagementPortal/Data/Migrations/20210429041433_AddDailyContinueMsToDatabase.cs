using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Data.Migrations
{
    public partial class AddDailyContinueMsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.CreateTable(
                name: "DailyContinueSheetMs",
                columns: table => new
                {
                    DCSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DSDate = table.Column<DateTime>(nullable: false),
                    DCSAccountType = table.Column<string>(nullable: false),
                    DCSDescription = table.Column<string>(nullable: false),
                    DCSDate = table.Column<DateTime>(nullable: false),
                    DCSPaidAmount = table.Column<float>(nullable: false),
                    DCSClearedAmount = table.Column<float>(nullable: false),
                    DCSUnClearedAmount = table.Column<float>(nullable: false),
                    DCSRemainingGaineAmmount = table.Column<float>(nullable: false),
                    DCSIncome = table.Column<float>(nullable: false),
                    DCSPGSCDO = table.Column<float>(nullable: false),
                    DCSOpeningBalance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyContinueSheetMs", x => x.DCSId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyContinueSheetMs");

           
             
        }
    }
}
