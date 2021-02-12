import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../../Services/clientes.service';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})
export class ClientesComponent implements OnInit {

  clientes:Array<any> = new Array();

  constructor(private ClientesService:ClientesService) { }

  
  ngOnInit(): void {
    this.ListarClientes();
  }
  
  ListarClientes(){
    this.ClientesService.Listaclientes().subscribe( clientes =>{
      this.clientes = clientes
      console.log(clientes);
    },err =>{
      console.log('erro',err);
    })
  }

  remover(id: number){
   
    if (id == null)
    {
      console.log("null")
    }
    this.ClientesService.removerAluno(id).subscribe( clientes =>{
      this.clientes = clientes
      this.ListarClientes(); 
    },err =>{
      console.log('erro',err);
    })
  }
}
