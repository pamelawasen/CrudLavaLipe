import { Component, OnInit } from '@angular/core';
import { clienteModel } from 'src/Models/clienteModel';
import { ClientesService } from '../../Services/clientes.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-editcliente',
  templateUrl: './editcliente.component.html',
  styleUrls: ['./editcliente.component.scss']
})
export class EditclienteComponent implements OnInit {
  id: number = 0;
  cliente:clienteModel = new clienteModel();
  constructor(private ClientesService:ClientesService,private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    console.log(this.id);
  }
  
  editar(){
    this.cliente.id = this.id;
    this.ClientesService.editarCliente(this.cliente).subscribe(cliente =>{
    this.cliente = new clienteModel();
    },err =>
    {console.log('erro',err);
    })
  }

}
