using System.Threading.Tasks;
using SistemaFinanceiro.API.Models;

namespace SistemaFinanceiro.Application.Interface
{
    public interface IDespesaService
    {
        Task<Despesa> AddDespesa(Despesa model);
        Task<Despesa> UpdateDespesa(int despesaId,Despesa model);
        Task<bool> DeleteDespesa(int despesaId);
        Task<Despesa[]> GetAllDespesasAsync();
        Task<float> GetSumDespesas();
         
    }
}