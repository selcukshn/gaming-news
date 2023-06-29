using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    public partial class UserDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "Email", "FirstName", "Image", "LastName", "Password", "Username" },
                values: new object[] { new Guid("ad46b0c3-e37d-4b34-aaa9-fb22e380b923"), "-", "admin@gmail.com", "admin", "-", "admin", "asdasd", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad46b0c3-e37d-4b34-aaa9-fb22e380b923"));
        }
    }
}
