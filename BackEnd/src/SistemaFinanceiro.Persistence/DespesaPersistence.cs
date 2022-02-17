using System.Linq;
using System.Threading.Tasks;
using SistemaFinanceiro.API.Data;
using SistemaFinanceiro.API.Models;
using SistemaFinanceiro.Persistence.Interface;
using Microsoft.EntityFrameworkCore;

namespace SistemaFinanceiro.Persistence
{
    public class DespesaPersistence : IDespesaPersistence
    {
        private readonly DataContext context;
        public DespesaPersistence(DataContext context)
        {
            this.context = context;
        }
        public async Task<Despesa[]> GetAllDespesasAsync()
        {
            IQueryable<Despesa> query = context.Despesas;
            return await query.ToArrayAsync();
        }
    }
}