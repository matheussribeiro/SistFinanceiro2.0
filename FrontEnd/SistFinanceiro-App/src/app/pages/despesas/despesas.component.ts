import { Component, OnInit } from '@angular/core';
import { despesaService } from 'src/app/services/despesaService.service';



interface Person {
  key: string;
  name: string;
  age: number;
  address: string;
}

@Component({
  selector: 'app-despesas',
  templateUrl: './despesas.component.html',
  styleUrls: ['./despesas.component.scss']
})
export class DespesasComponent implements OnInit {

  public despesas : any = [];
  checked = false

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

  meses = ["Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"];

  data = new Date()

  mes = this.meses[this.data.getMonth()];

}
