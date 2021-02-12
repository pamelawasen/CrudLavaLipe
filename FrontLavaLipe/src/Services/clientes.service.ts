import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { clienteModel } from 'src/Models/clienteModel';
import { environment} from 'src/environments/environment'
@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  constructor(private http: HttpClient) { }

  Listaclientes() :Observable<any>{
    return this.http.get(environment.apiUrl);
  }
  editarCliente(cliente:clienteModel) :Observable<any>{
    return this.http.put(environment.apiUrl+"edit",cliente);
  }
  criarCliente(cliente:clienteModel) :Observable<any>{
    return this.http.post(environment.apiUrl+"create",cliente);
  }

  removerAluno(id:number) :Observable<any>{
    return this.http.post(environment.apiUrl+"/delete/"+id,id);
  }
}
