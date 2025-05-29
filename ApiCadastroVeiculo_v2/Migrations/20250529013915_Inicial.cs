using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiCadastrarVeiculo.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Cor = table.Column<string>(type: "TEXT", nullable: false),
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Chassis = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Chassis", "Cor", "Marca", "Modelo", "Placa", "Status" },
                values: new object[,]
                {
                    { 1, "CHS001", "Prata", "Chevrolet", "Onix", "ABC1234", "Roubado" },
                    { 2, "CHS002", "Preto", "Honda", "Civic", "DEF5678", "Recuperado" },
                    { 3, "CHS003", "Branco", "Volkswagen", "Gol", "GHI9012", "Roubado" },
                    { 4, "CHS004", "Azul", "Ford", "Fiesta", "JKL3456", "Roubado" },
                    { 5, "CHS005", "Vermelho", "Hyundai", "HB20", "MNO7890", "Recuperado" },
                    { 6, "CHS006", "Cinza", "Ford", "Ka", "PQR1234", "Roubado" },
                    { 7, "CHS007", "Preto", "Fiat", "Palio", "STU5678", "Recuperado" },
                    { 8, "CHS008", "Branco", "Toyota", "Corolla", "VWX9012", "Roubado" },
                    { 9, "CHS009", "Azul", "Chevrolet", "Cruze", "YZA3456", "Roubado" },
                    { 10, "CHS010", "Verde", "Fiat", "Uno", "BCD7890", "Recuperado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
