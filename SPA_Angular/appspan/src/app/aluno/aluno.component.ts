import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'spa-aluno',
  templateUrl: './aluno.component.html',
  styleUrls: ['./aluno.component.css']
})
export class AlunoComponent implements OnInit {

  constructor() { }

  @Input() valorInicial: number = 10;

  ngOnInit(): void {
  }


}
