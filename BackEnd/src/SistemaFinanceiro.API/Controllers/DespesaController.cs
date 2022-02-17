using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.API.Models;
using SistemaFinanceiro.Application.Interface;

namespace SistemaFinanceiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DespesaController : ControllerBase
    {
        private readonly IDespesaService despesaService;
        public DespesaController(IDespesaService despesaService)
        {
            this.despesaService = despesaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var despesas = await despesaService.GetAllDespesasAsync();
                if(despesas == null) return NotFound("Nenhuma Despesa Encontrada");

                return Ok(despesas);
                
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar despesas. erro : {ex.Message}");
            }
        }

        [HttpGet("soma")]
        public async Task<float> GetSumDespesas()
        {
            try
            {
                var soma = await despesaService.GetSumDespesas();
                if(soma == 0 ) throw new Exception("Não foi possível somar as despesas");

                return soma;
            }
            catch (System.Exception)
            {
                throw new Exception("Erro ao somar as despesas");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Despesa model)
        {
            try
            {
                var despesa = await despesaService.AddDespesa(model);
                if(despesa == null) return BadRequest("Erro ao cadastrar despesa.");

                return Ok(despesa);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar inserir a despesa. erro : {ex.Message}");
            }
        }
    }
}