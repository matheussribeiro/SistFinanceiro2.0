import { Component, OnInit } from '@angular/core';
import { Despesa } from 'src/app/interface/despesa';
import { despesaService } from 'src/app/services/despesaService.service';


@Component({
  selector: 'app-despesas',
  templateUrl: './despesas.component.html',
  styleUrls: ['./despesas.component.scss']
})
export class DespesasComponent implements OnInit {

  public despesas : any = [];
  checked = false

  newDespesa : Despesa = {
    DataIncl : new Date,
    Nome : '',
    StatusDespesa : false,
    TipoDespesaId : 0,
    Valor : 0,
  }

  constructor(private despesaService : despesaService) { }

  ngOnInit(): void {
    this.getDespesas();
  }

  public getDespesas() :void {
    this.despesaService.getDespesas().subscribe(
      response => {this.despesas = response , console.log(this.despesas)},
      error => console.log(error)
    );
  }

  public addDespesa() :void{
    this.despesaService.addDespesa(this.newDespesa).subscribe(
      response => {console.log(this.newDespesa)
      debugger;
      this.getDespesas();}
    );
    this.isVisibleTop = false;
  }

  meses = ["Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"];

  data = new Date()

  mes = this.meses[this.data.getMonth()];


  isVisibleTop = false;
  isVisibleMiddle = false;

  OpenModal(): void {
    this.isVisibleTop = true;
  }

  showModalMiddle(): void {
    this.isVisibleMiddle = true;
  }

  handleOkTop(): void {

  }

  handleCancelTop(): void {
    this.isVisibleTop = false;
  }

  handleOkMiddle(): void {
    console.log('click ok');
    this.isVisibleMiddle = false;
  }

  handleCancelMiddle(): void {
    this.isVisibleMiddle = false;
  }

}
