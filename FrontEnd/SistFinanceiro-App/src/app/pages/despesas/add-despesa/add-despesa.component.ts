import { Component, OnInit } from '@angular/core';
import { Despesa } from 'src/app/interface/despesa';
import { despesaService } from 'src/app/services/despesaService.service';

@Component({
  selector: 'app-add-despesa',
  templateUrl: './add-despesa.component.html',
  styleUrls: ['./add-despesa.component.scss']
})
export class AddDespesaComponent implements OnInit {

  newDespesa : Despesa = {
    DataIncl : new Date,
    Nome : '',
    StatusDespesa : false,
    TipoDespesaId : 0,
    Valor : 0,
  }

  constructor(private despesaService : despesaService) { }

  ngOnInit(): void {
    this.isVisibleTop = true
  }

  public addDespesa() :void{
    this.despesaService.addDespesa(this.newDespesa).subscribe(
      response => {console.log(this.newDespesa)
      this.despesaService.getDespesas().subscribe();}
    );
    this.isVisibleTop = false;
  }

  isVisibleTop = false;

  handleCancelTop(): void {
    this.isVisibleTop = false;
  }



}
