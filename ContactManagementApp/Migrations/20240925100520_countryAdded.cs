using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class countryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(type: "nchar(15)", fixedLength: true, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contacts__3214EC0716B5A031", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
