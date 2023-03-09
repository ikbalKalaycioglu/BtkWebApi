using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkWebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61733068-837b-497b-b20c-ff0b9f704327", "bdf33b04-2840-46b4-baac-fd9e9e252a5f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63d36bfe-7314-4821-b958-46c576402500", "bfec1b70-6ea4-4052-a5c0-feac72033335", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66cf5854-5feb-4614-9746-d3ddc1630eb1", "46bdbdf1-06b1-4e7f-80b2-7b6d368e68a3", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61733068-837b-497b-b20c-ff0b9f704327");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63d36bfe-7314-4821-b958-46c576402500");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66cf5854-5feb-4614-9746-d3ddc1630eb1");
        }
    }
}
