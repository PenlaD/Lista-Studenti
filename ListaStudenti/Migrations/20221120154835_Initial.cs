using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaStudenti.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: false),
                    AnStudiu = table.Column<int>(nullable: false),
                    Nota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.StudentID);
                });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 1, 3, 10, "Sirbu Doina" });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 2, 2, 8, "Moraru Eusebiu" });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "StudentID", "AnStudiu", "Nota", "Nume" },
                values: new object[] { 3, 1, 9, "Popescu Ion" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studenti");
        }
    }
}
