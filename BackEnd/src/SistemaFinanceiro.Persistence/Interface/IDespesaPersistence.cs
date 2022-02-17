using System.Threading.Tasks;
using SistemaFinanceiro.API.Models;

namespace SistemaFinanceiro.Persistence.Interface
{
    public interface IDespesaPersistence
    {
        Task<Despesa[]> GetAllDespesasAsync();
        Task<Despesa> GetDespesaByIdAsync(int despesaId);
         
    }
}