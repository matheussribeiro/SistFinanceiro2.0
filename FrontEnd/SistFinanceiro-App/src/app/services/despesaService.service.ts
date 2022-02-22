import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';



@Injectable({
  providedIn: 'root'
})
export class despesaService {

baseUrl = 'https://localhost:5001/Despesa'


constructor(private http : HttpClient) { }

getDespesas(){
  return this.http.get(this.baseUrl)
}

}
