import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Book } from "./model/Book";

@Injectable()

export class BookService
{
  private url = "https://api.itbook.store/1.0/new";

  httpOption = {
    headers: new HttpHeaders({'content-types':'application/json'})
  }

  constructor(private http:HttpClient){}

  getBook(){
    return this.http.get(this.url);
  }
}
