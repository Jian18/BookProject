import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Book } from '../shared/Book';
import { Observable } from 'rxjs';

@Injectable()
export class BookStore {
  constructor(private http: HttpClient) {}
  public books: Book[] = [];

  loadBooks(): Observable<void> {
    return this.http.get<[]>('https://localhost:7061/api/Books').pipe(
      map((data) => {
        this.books = data;
        return;
      })
    );
  }
}
