import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { EditclienteComponent } from './editcliente/editcliente.component';
import { NovoclienteComponent } from './novocliente/novocliente.component';

const routes: Routes = [
  { path: 'edit/:id', component: EditclienteComponent },
  { path: '', component: ClientesComponent },
  { path: 'create', component: NovoclienteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [EditclienteComponent,ClientesComponent,NovoclienteComponent]