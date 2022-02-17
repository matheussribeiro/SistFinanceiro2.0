using System.Threading.Tasks;
using SistemaFinanceiro.Domain;

namespace SistemaFinanceiro.Persistence.Interface
{
    public interface IDespesaPersistence
    {
        Task<Despesa[]> GetAllDespesasAsync();
        Task<Despesa> GetDespesaByIdAsync(int despesaId);
         
    }
}