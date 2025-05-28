using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CestaFeira.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CestaFeiraDbV001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Campanhas",
                columns: table => new
                {
                    IdCampanha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantidadeCestas = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanhas", x => x.IdCampanha);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Unidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.IdItem);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfCnpj = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    NivelAcessoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CestasBasicas",
                columns: table => new
                {
                    IdCestaBasica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    IdCampanha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CestasBasicas", x => x.IdCestaBasica);
                    table.ForeignKey(
                        name: "FK_CestasBasicas_Campanhas_IdCampanha",
                        column: x => x.IdCampanha,
                        principalTable: "Campanhas",
                        principalColumn: "IdCampanha",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doacoes",
                columns: table => new
                {
                    IdDoacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCampanha = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacoes", x => x.IdDoacao);
                    table.ForeignKey(
                        name: "FK_Doacoes_Campanhas_IdCampanha",
                        column: x => x.IdCampanha,
                        principalTable: "Campanhas",
                        principalColumn: "IdCampanha",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doacoes_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItensCestaBasica",
                columns: table => new
                {
                    IdItemCestaBasica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    ItemIdItem = table.Column<int>(type: "int", nullable: false),
                    IdCestaBasica = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensCestaBasica", x => x.IdItemCestaBasica);
                    table.ForeignKey(
                        name: "FK_ItensCestaBasica_CestasBasicas_IdCestaBasica",
                        column: x => x.IdCestaBasica,
                        principalTable: "CestasBasicas",
                        principalColumn: "IdCestaBasica",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensCestaBasica_Itens_ItemIdItem",
                        column: x => x.ItemIdItem,
                        principalTable: "Itens",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItensDoacao",
                columns: table => new
                {
                    IdItemDoacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    IdDoacaoCestaBasica = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<int>(type: "int", nullable: false),
                    Observacoes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensDoacao", x => x.IdItemDoacao);
                    table.ForeignKey(
                        name: "FK_ItensDoacao_Doacoes_IdDoacaoCestaBasica",
                        column: x => x.IdDoacaoCestaBasica,
                        principalTable: "Doacoes",
                        principalColumn: "IdDoacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItensDoacao_ItensCestaBasica_IdItem",
                        column: x => x.IdItem,
                        principalTable: "ItensCestaBasica",
                        principalColumn: "IdItemCestaBasica",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CestasBasicas_IdCampanha",
                table: "CestasBasicas",
                column: "IdCampanha");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_IdCampanha",
                table: "Doacoes",
                column: "IdCampanha");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_IdUsuario",
                table: "Doacoes",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCestaBasica_IdCestaBasica",
                table: "ItensCestaBasica",
                column: "IdCestaBasica");

            migrationBuilder.CreateIndex(
                name: "IX_ItensCestaBasica_ItemIdItem",
                table: "ItensCestaBasica",
                column: "ItemIdItem");

            migrationBuilder.CreateIndex(
                name: "IX_ItensDoacao_IdDoacaoCestaBasica",
                table: "ItensDoacao",
                column: "IdDoacaoCestaBasica");

            migrationBuilder.CreateIndex(
                name: "IX_ItensDoacao_IdItem",
                table: "ItensDoacao",
                column: "IdItem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensDoacao");

            migrationBuilder.DropTable(
                name: "Doacoes");

            migrationBuilder.DropTable(
                name: "ItensCestaBasica");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CestasBasicas");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Campanhas");
        }
    }
}
