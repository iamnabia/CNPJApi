using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CNPJApi.Migrations
{
    /// <inheritdoc />
    public partial class CriandoEmpresas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EMPRESAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EMPRESAS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_EMPRESAS",
                columns: new[] { "Id", "CNPJ", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "26.375.761/0001-11", "ana.silva@saintgobain.com", "SaintGoabin", "11 93718-2661" },
                    { 2, "42.575.821/0002-15", "ana.silva@marabraz2.com", "Marabraz2", "11 93128-5567" },
                    { 3, "64.634.859/0046-83", "ana.silva@telhanorte.com", "Telha Norte", "11 97402-9123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_EMPRESAS");
        }
    }
}
