import { Component, OnInit } from '@angular/core';
import { BookStore } from '../services/BookStore.service';

@Component({
  selector: 'book-view',
  templateUrl: 'books-view.component.html',
})
export default class BookView implements OnInit {
  constructor(public bookStore: BookStore) {}

  ngOnInit(): void {
    this.bookStore.loadBooks().subscribe(() => {
      //do something
    });
  }
}
