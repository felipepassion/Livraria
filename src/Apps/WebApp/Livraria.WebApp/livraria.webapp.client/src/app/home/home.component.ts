import { Component, OnInit } from '@angular/core';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'home-component',
  templateUrl: './home.component.html',
  standalone: false,
  styleUrl: './home.component.css'
})
export class HomeComponent {
  title = 'livraria.webapp.client';

}
