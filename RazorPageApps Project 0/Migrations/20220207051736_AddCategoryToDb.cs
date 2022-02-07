using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageApps_Project_0.Migrations
{
    public partial class AddCategoryToDb : Migration
    {
        // Creates table
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NameOfTableCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NameOfTableCategory", x => x.Id);
                });
        }

        // Down method rolls back the changes if something fails.
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NameOfTableCategory");
        }
    }
}
