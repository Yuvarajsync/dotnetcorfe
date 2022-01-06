using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationFinalAssignment.Migrations
{
    public partial class CreateDatabaseWithTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookcategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookcategory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherYear = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookCategoryId = table.Column<int>(type: "int", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookDept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Bookcategory_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "Bookcategory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bookcategory",
                columns: new[] { "CategoryId", "CategoryName", "IsDeleted", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "IT", false, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Electronics", false, new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Mechanical", false, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Civil", false, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Electricals", false, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Economics", true, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorName", "BookCategoryId", "BookDept", "BookName", "IsDeleted", "Price", "PublisherYear", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Balaguruswamy", 1, null, "C++", false, 500m, 2001, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "", 1, null, "Data Structure", false, 430m, 0, new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Abraham Silberschatz", 1, null, "Operating systems", true, 0m, 2007, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Mazidi", 2, null, "Microcontrollers", false, 550m, 2002, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "William Gothmann", 2, null, "Digital Electronics", false, 0m, 0, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sebastian", 3, null, "Robotics", false, 600m, 2003, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Jacques Heyman", 4, null, "Structural Engineering", false, 800m, 2004, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Michael Faraday", 5, null, "DC Motors", false, 400m, 2004, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Nassim Nicholas", 6, null, "Economics", true, 300m, 2005, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookCategoryId",
                table: "Book",
                column: "BookCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Bookcategory");
        }
    }
}
