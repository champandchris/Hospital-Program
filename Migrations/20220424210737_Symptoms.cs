using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospital.Migrations
{
    public partial class Symptoms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Disease = table.Column<string>(type: "TEXT", nullable: false),
                    SymptomOne = table.Column<string>(type: "TEXT", nullable: false),
                    SymptomTwo = table.Column<string>(type: "TEXT", nullable: false),
                    SymptomThree = table.Column<string>(type: "TEXT", nullable: false),
                    SymptomFour = table.Column<string>(type: "TEXT", nullable: false),
                    SymptomFive = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.DiseaseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
