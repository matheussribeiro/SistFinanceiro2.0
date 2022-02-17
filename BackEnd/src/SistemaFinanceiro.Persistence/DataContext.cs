using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain;

namespace SistemaFinanceiro.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Lucro> Lucros { get; set; }
        public DbSet<TipoDespesa> TiposDespesa { get; set; }
    }
}