using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkWebApi.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cbd5f20-8ada-4c94-98a1-ae0871cbe270");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a33f11e2-cd11-4df9-9290-76a04c4ff04a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4539c29-be3c-47ae-92cc-d194867a0730");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d8ec6837-56bd-428e-8df0-8868316cacb0", "7b5559a4-5689-4a2d-aa98-368a6c88732b", "User", "USER" },
                    { "eac4bf8d-f4db-4acb-a467-0d20bde9964d", "71b1351e-f264-43c4-9846-bdd414d55da0", "Admin", "ADMIN" },
                    { "f1b3b47e-c804-40fc-99ce-69db8272d4f9", "1aef70b7-f6d0-4bac-846e-d3e7ab88f8cd", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Computer Science" },
                    { 2, "Network" },
                    { 3, "Database Managemet Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8ec6837-56bd-428e-8df0-8868316cacb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eac4bf8d-f4db-4acb-a467-0d20bde9964d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1b3b47e-c804-40fc-99ce-69db8272d4f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3cbd5f20-8ada-4c94-98a1-ae0871cbe270", "366b1de2-1439-45c3-9072-8e663bc2b5d0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a33f11e2-cd11-4df9-9290-76a04c4ff04a", "f54cd779-4fa9-4d31-bb23-0c055fc6a03d", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4539c29-be3c-47ae-92cc-d194867a0730", "bf597c6e-8939-4522-a6a6-b64ae7cbf84b", "User", "USER" });
        }
    }
}
