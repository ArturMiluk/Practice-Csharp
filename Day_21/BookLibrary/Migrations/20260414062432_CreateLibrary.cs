using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLibrary.Migrations
{
    /// <inheritdoc />
    public partial class CreateLibrary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "DateAdded", "Genre", "ISBN", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Лев Толстой", new DateTime(2026, 4, 14, 9, 24, 31, 774, DateTimeKind.Local).AddTicks(187), "Роман-эпопея", "9785170909373", "Война и мир", 1869 },
                    { 2, "Фёдор Достоевский", new DateTime(2026, 4, 14, 9, 24, 31, 774, DateTimeKind.Local).AddTicks(189), "Роман", "9785171180804", "Преступление и наказание", 1866 },
                    { 3, "Михаил Булгаков", new DateTime(2026, 4, 14, 9, 24, 31, 774, DateTimeKind.Local).AddTicks(192), "Мистический роман", "9785170922877", "Мастер и Маргарита", 1967 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
