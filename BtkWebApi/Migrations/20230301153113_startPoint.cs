using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkWebApi.Migrations
{
    public partial class startPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Karagöz Ve Hacıvat", 75.0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Mesnevi", 175.0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Devlet", 375.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
