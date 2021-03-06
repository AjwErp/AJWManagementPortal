using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Data.Migrations
{
    public partial class AddDailyPlanInOutModelToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.CreateTable(
                name: "DailyPlanInOutModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    DateTimeIn = table.Column<DateTime>(nullable: false),
                    DateTimeOut = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Sign = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanInOutModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyPlanInOutModels");

            
        }
    }
}
