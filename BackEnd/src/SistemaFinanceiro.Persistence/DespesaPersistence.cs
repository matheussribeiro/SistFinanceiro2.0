using System.Linq;
using System.Threading.Tasks;
using SistemaFinanceiro.API.Data;
using SistemaFinanceiro.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Domain;

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

        public async Task<Despesa> GetDespesaByIdAsync(int despesaId)
        {
            IQueryable<Despesa> query = context.Despesas.Where(dp => dp.Id == despesaId);
            return await query.FirstOrDefaultAsync();
        }
    }
}