import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BooksListComponent } from './books-list/books-list.component';
import { HomeComponent } from './home/home.component';
import { BooksDetailComponent } from './books-detail/books-detail.component';
import { BookRegisterComponent } from './book-register/book-register.component';

const routes: Routes = [
  { path: '', component: HomeComponent }, // Redireciona para "books" por padrão
  { path: 'books', component: BooksListComponent },    // Caminho correto
  { path: 'book', component: BooksDetailComponent },    // Caminho correto
  { path: 'book/register', component: BookRegisterComponent },    // Caminho correto
  { path: '**', redirectTo: '' },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
