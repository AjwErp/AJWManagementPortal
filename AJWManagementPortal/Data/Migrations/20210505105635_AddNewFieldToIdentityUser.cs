using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AJWManagementPortal.Data.Migrations
{
    public partial class AddNewFieldToIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.AddColumn<byte[]>(
                name: "Profile",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "AspNetUsers");

           
        }
    }
}
