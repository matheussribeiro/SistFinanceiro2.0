using System;
using System.Threading.Tasks;
using SistemaFinanceiro.Application.Interface;
using SistemaFinanceiro.Domain;
using SistemaFinanceiro.Persistence.Interface;

namespace SistemaFinanceiro.Application
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaPersistence desppersist;
        private readonly IGeralPersistence geralpersist;

        public DespesaService(IDespesaPersistence desppersist, IGeralPersistence geralpersist)
        {
            this.geralpersist = geralpersist;
            this.desppersist = desppersist;
        }
        public async Task<Despesa> AddDespesa(Despesa model)
        {
            try
            {
                geralpersist.Add<Despesa>(model);
                if(await geralpersist.SaveChangesAsync())
                    return await desppersist.GetDespesaByIdAsync(model.Id);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Despesa> UpdateDespesa(int despesaId, Despesa model)
        {
            try
            {
                var despesa = await desppersist.GetDespesaByIdAsync(despesaId);
                if (despesa == null) return null;

                model.Id = despesa.Id;

                geralpersist.Update(model);
                if(await geralpersist.SaveChangesAsync())
                    return await desppersist.GetDespesaByIdAsync(model.Id);

                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteDespesa(int despesaId)
        {
            try
            {
                var despesa = await desppersist.GetDespesaByIdAsync(despesaId);
                if(despesa == null) throw new Exception("Despesa não encontrada para deletar");

                geralpersist.Delete<Despesa>(despesa);

                return await geralpersist.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Despesa[]> GetAllDespesasAsync()
        {
            try
            {
                var despesas = await desppersist.GetAllDespesasAsync();
                if(despesas == null) return null;

                return despesas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<float> GetSumDespesas()
        {
            try
            {
                var despesas = await desppersist.GetAllDespesasAsync();
                if(despesas == null) throw new Exception ("Erro ao carregar Lista de Despesas");

                float somaDespesas  = 0;

                foreach(var despesa in despesas)
                {
                    somaDespesas += despesa.Valor;
                }

                return somaDespesas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}