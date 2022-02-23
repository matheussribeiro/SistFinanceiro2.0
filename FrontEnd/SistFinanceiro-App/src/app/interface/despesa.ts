export interface Despesa {
  Id?: number
  Nome: string
  Valor: number
  Parcela?: number
  TipoDespesaId : number
  StatusDespesa: Boolean
  DataIncl: Date
}
