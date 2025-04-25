using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCet96.Web.Migrations 
{
    /// <inheritdoc />
    public partial class InitialDB : Migration // Classe gerada automaticamente após executar o comando `Add-Migration InitialDB` no Package Manager Console.
                                               // OBS: "InitialDB" é só o nome dado à migration.
    {
        /// <inheritdoc />
        /// Define as alterações a serem aplicadas no banco de dados (ex: criação de tabelas).
        protected override void Up(MigrationBuilder migrationBuilder) // Código C# gerado pelo EF Core para definir a estrutura da tabela.
                                                                      // Para aplicar essa estrutura no banco de dados real (gerar SQL e executar),
                                                                      // é necessário rodar o comando `Update-Database` no Package Manager Console.
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });
        }

        /// <inheritdoc />
        ///Define como desfazer a migration (rollback do sql).
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
