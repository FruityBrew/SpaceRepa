using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IdentityDb.API.Migrations
{
    public partial class IdentityModel_Pass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassHash",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Pass",
                table: "Users",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pass",
                table: "Users");

            migrationBuilder.AddColumn<byte[]>(
                name: "PassHash",
                table: "Users",
                nullable: false,
                defaultValue: new byte[] {  });
        }
    }
}
