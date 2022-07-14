import { Component, OnInit } from '@angular/core';
import { aluno } from '../model/modeloAluno';

@Component({
  selector: 'spa-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  exibeTabela: boolean = false;
  valor!: number;
  listaAlunos: aluno[] = [
    {nome: 'Camila', idade: 27, email: 'camisa.tramo@gamio.com', curso: 'Ciencia da Computacao'},
    {nome: 'Teste 01', idade: 29, email: 'camisa.tramo@gamio.com', curso: 'Eng. Computacao'},
    {nome: 'Teste 02', idade: 35, email: 'camisa.tramo@gamio.com', curso: 'Sistemas de Informação'},
    {nome: 'Teste 03', idade: 19, email: 'camisa.tramo@gamio.com', curso: 'Analise e Desenvolvimento de Sistemas'},
  ]

  displayedColumns: string[] = ['Nome', 'Idade', 'E-mail', 'Curso'];

  ngOnInit(): void {
    this.valor = 4;
  }
  mudarValor(){
    this.valor++;
  }
  reiniciarValor(){
    this.valor=0;
  }
  exibirTabela(){
    if(this.exibeTabela === true){
      this.exibeTabela = false;
    }else{
      this.exibeTabela = true;
    }
  }

}
