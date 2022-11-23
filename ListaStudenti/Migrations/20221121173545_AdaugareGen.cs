using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaStudenti.Migrations
{
    public partial class AdaugareGen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GenID",
                table: "Studenti",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Gen",
                columns: table => new
                {
                    GenID = table.Column<string>(nullable: false),
                    Nume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gen", x => x.GenID);
                });

            migrationBuilder.InsertData(
                table: "Gen",
                columns: new[] { "GenID", "Nume" },
                values: new object[] { "M", "Masculin" });

            migrationBuilder.InsertData(
                table: "Gen",
                columns: new[] { "GenID", "Nume" },
                values: new object[] { "F", "Feminin" });

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "GenID",
                value: "F");

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "GenID",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Studenti",
                keyColumn: "StudentID",
                keyValue: 3,
                column: "GenID",
                value: "M");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_GenID",
                table: "Studenti",
                column: "GenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Gen_GenID",
                table: "Studenti",
                column: "GenID",
                principalTable: "Gen",
                principalColumn: "GenID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Gen_GenID",
                table: "Studenti");

            migrationBuilder.DropTable(
                name: "Gen");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_GenID",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "GenID",
                table: "Studenti");
        }
    }
}
