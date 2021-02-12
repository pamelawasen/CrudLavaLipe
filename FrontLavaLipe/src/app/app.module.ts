import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule,routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { ClientesComponent } from './clientes/clientes.component';
import { ClientesService } from '../Services/clientes.service';
import { HttpClientModule}  from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { EditclienteComponent } from './editcliente/editcliente.component';
import { NovoclienteComponent } from './novocliente/novocliente.component';
@NgModule({
  declarations: [
    AppComponent,
    ClientesComponent,
    EditclienteComponent,
    routingComponents,
    NovoclienteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule
  ],
  providers: [HttpClientModule,ClientesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
