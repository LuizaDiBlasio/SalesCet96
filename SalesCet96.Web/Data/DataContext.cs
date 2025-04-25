using Microsoft.EntityFrameworkCore;
using SalesCet96.Web.Data.Entities;

namespace SalesCet96.Web.Data
{
    public class DataContext : DbContext //DbContext é a classe dos dados, representa a conexão com o banco, gerencia tabelas e consultas
                                         //DataContext: Classe que herda de DbContext, onde configuro as tabelas

    {
        // Recebe as configurações através do objeto options (DbContextOptions) e passa para a classe base DbContext,
        // permitindo que o Entity Framework configure e acesse o banco de dados.
        // A tabela Countries é definida por DbSet
        public DataContext(DbContextOptions<DataContext> options) : base(options)  //DbOptions: Contém configurações (tipo de banco, string de conexão etc.)
        {      
        }

        public DbSet<Country> Countries { get; set; } 
    }
}
