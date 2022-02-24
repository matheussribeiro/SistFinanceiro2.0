import { Component, OnInit } from '@angular/core';
import { NzModalService } from 'ng-zorro-antd/modal';
import { despesaService } from 'src/app/services/despesaService.service';
import { AddDespesaComponent } from './add-despesa/add-despesa.component';


@Component({
  selector: 'app-despesas',
  templateUrl: './despesas.component.html',
  styleUrls: ['./despesas.component.scss']
})
export class DespesasComponent implements OnInit {

  public despesas : any = [];
  checked = false



  constructor(private despesaService : despesaService , private modalService: NzModalService) { }

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


  isVisibleTop = false;

  showModal2(): void {
    this.modalService.create({nzContent: AddDespesaComponent});
  }

  handleOkTop(): void {
  }


}
