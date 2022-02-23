import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Despesa } from '../interface/despesa';



@Injectable({
  providedIn: 'root'
})
export class despesaService {

baseUrl = 'https://localhost:5001/Despesa'


constructor(private http : HttpClient) { }

getDespesas(){
  return this.http.get(this.baseUrl)
}

addDespesa(despesa : Despesa){
  return this.http.post(this.baseUrl,despesa)
}

}
