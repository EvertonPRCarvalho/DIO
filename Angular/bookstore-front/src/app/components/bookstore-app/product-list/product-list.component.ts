import { Component, OnInit } from '@angular/core';
import { Book } from './model/Book';
import { BookService } from './product-list.component.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  livros: any;
  bookService: BookService;

  constructor(bookService : BookService) {
    this.bookService = bookService;
  }

  ngOnInit(): void {/*Quando ele iniciar, o que quero que aconteça? Esta pergunta é respondida aqui.*/
    this.livros = this.bookService.getBook().subscribe((data => {
      this.livros = data;
      this.livros = this.livros['books'];
    }))
  }

}
