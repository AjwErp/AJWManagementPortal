using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Data.Migrations
{
    public partial class AddDailyPlanOutAccountsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyPlanOutAccountss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAccount = table.Column<string>(nullable: false),
                    DesignationAccount = table.Column<string>(nullable: false),
                    DateTimeoutAccount = table.Column<DateTime>(nullable: false),
                    DescriptionoutAccount = table.Column<string>(nullable: false),
                    signAccount = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyPlanOutAccountss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyPlanOutAccountss");
        }
    }
}
