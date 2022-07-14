import { Component } from "@angular/core";

@Component({
  selector: 'spa-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'conversor';
  fraseDoUsuario:string ='';
  resultado = 'Sua frase será exibida aqui!';


  //[formGroup]="novoUsuarioForm"
  converterParaMaiuscula(): void{
    this.resultado = this.fraseDoUsuario.toUpperCase();
  }
  converterParaMinuscula(){
    this.resultado = this.fraseDoUsuario.toLowerCase();
  }
  converterParaMesclar(){
    this.resultado = '';
    for(let i=0; i<this.fraseDoUsuario.length; i++){
      if(i%2 === 1){
        this.resultado += this.fraseDoUsuario[i].toLowerCase();
      }else{
        this.resultado += this.fraseDoUsuario[i].toUpperCase();
      }
    }
  }
  //novoUsuarioForm!: FormGroup;

}
