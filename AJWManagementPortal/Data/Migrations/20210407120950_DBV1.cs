using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTJ_Product.Migrations
{
    public partial class DBV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aDailyCashes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    paidAmount = table.Column<float>(nullable: false),
                    clearedAmount = table.Column<float>(nullable: false),
                    lnClearedAmount = table.Column<float>(nullable: false),
                    remainingGained = table.Column<float>(nullable: false),
                    surplus = table.Column<float>(nullable: false),
                    purchaser = table.Column<string>(nullable: false),
                    income = table.Column<float>(nullable: false),
                    pOrder = table.Column<float>(nullable: false),
                    online = table.Column<float>(nullable: false),
                    accountant = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aDailyCashes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bankBalane",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankBalance = table.Column<int>(nullable: false),
                    deposit = table.Column<int>(nullable: false),
                    transaction = table.Column<int>(nullable: false),
                    tax = table.Column<int>(nullable: false),
                    closingBankBalance = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bankBalane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankIEReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CDO = table.Column<string>(nullable: false),
                    Debit = table.Column<float>(nullable: false),
                    Cradit = table.Column<float>(nullable: false),
                    Balance = table.Column<float>(nullable: false),
                    Imgceo = table.Column<string>(nullable: true),
                    Imggm = table.Column<string>(nullable: true),
                    Imgdgm = table.Column<string>(nullable: true),
                    Imgam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankIEReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeezanBankIEVouchers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(nullable: false),
                    checkNumber = table.Column<string>(nullable: true),
                    amount = table.Column<string>(nullable: true),
                    purpose = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeezanBankIEVouchers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aDailyCashes");

            migrationBuilder.DropTable(
                name: "bankBalane");

            migrationBuilder.DropTable(
                name: "MeezanBankIEReports");

            migrationBuilder.DropTable(
                name: "MeezanBankIEVouchers");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
