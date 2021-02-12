import { Component, OnInit } from '@angular/core';
import { clienteModel } from 'src/Models/clienteModel';
import { ClientesService } from '../../Services/clientes.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-novocliente',
  templateUrl: './novocliente.component.html',
  styleUrls: ['./novocliente.component.scss']
})
export class NovoclienteComponent implements OnInit {

  cliente:clienteModel = new clienteModel();
  constructor(private ClientesService:ClientesService,private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  criar(){
    this.ClientesService.criarCliente(this.cliente).subscribe(cliente =>{
    this.cliente = new clienteModel();
    },err =>
    {console.log('erro',err);
    })
  }

}
