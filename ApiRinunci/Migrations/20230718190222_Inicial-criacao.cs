using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRinunci.Migrations
{
    /// <inheritdoc />
    public partial class Inicialcriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    produtoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeProduto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    descricaoProduto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    precoProduto = table.Column<int>(type: "int", nullable: false),
                    ativo = table.Column<bool>(type: "bit", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.produtoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
