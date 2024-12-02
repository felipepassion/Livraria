import { Component, OnInit } from '@angular/core';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'booksList-component',
  templateUrl: './books-list.component.html',
  standalone: false,
  styleUrl: './books-list.component.css'
})
export class BooksListComponent {
  title = 'livraria.webapp.client';

}
