import { Component, OnInit } from '@angular/core';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'booksDetail-component',
  templateUrl: './books-detail.component.html',
  standalone: false,
  styleUrl: './books-detail.component.css'
})
export class BooksDetailComponent {
  title = 'livraria.webapp.client';

}
