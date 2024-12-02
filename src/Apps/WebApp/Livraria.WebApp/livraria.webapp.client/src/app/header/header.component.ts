import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'header-component',
  templateUrl: './header.component.html',
  standalone: false,
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  title = 'livraria.webapp.client';

}
