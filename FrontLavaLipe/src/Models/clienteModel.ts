export class clienteModel{
    id:number
    name:string;
    cpfcnpj: string; 
    phone: string;
    excluido:number;

    constructor() {
        this.id = 0;
        this.name ='';
        this.cpfcnpj ='';
        this.phone ='';
        this.excluido = 0;

      }
}