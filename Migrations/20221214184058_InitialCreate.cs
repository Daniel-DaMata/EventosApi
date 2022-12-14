using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventosApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baladas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bebida = table.Column<bool>(type: "bit", nullable: false),
                    Entrada = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baladas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "baladas",
                columns: new[] { "Id", "Bebida", "Endereco", "Entrada", "Nome" },
                values: new object[,]
                {
                    { 1, true, "Santana", 0f, "Robinho" },
                    { 2, true, "Avenida Nova", 30f, "Red" },
                    { 3, true, "Avenida Engenheiro", 20f, "Lux" },
                    { 4, true, "Avenida Nova", 10f, "Barcelona" },
                    { 5, true, "Avenida Cruzeiro", 60f, "Dubai" },
                    { 6, true, "Avenida Guilherme", 25f, "Slim" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "baladas");
        }
    }
}
