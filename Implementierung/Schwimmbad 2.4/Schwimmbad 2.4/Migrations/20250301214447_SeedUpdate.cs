using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Schwimmbad_2._4.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutzer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Punkte = table.Column<int>(type: "INTEGER", nullable: false),
                    Besuche = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutzer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Nutzer",
                columns: new[] { "Id", "Besuche", "Email", "Name", "Punkte" },
                values: new object[,]
                {
                    { 1, 1, "Max@gmail.com", "Max Mustermann", 10 },
                    { 2, 1, "Erika@gmail.com", "Erika Mustermann", 8 },
                    { 3, 1, "John@gmail.com", "John Doe", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutzer");
        }
    }
}
