using System;

namespace SistemaFinanceiro.Domain
{
    public class Despesa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public int? Parcela { get; set; }
        public int TipoDespesaId  { get; set; }
        public Boolean StatusDespesa { get; set; }
        public DateTime DataIncl { get; set; }
        
    }
}