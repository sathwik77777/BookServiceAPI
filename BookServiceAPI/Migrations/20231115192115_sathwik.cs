using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookServiceAPI.Migrations
{
    public partial class sathwik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BookPrice = table.Column<double>(type: "float", nullable: false),
                    Authorname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "Datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
