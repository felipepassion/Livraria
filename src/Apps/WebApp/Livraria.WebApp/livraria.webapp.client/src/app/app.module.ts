import { provideHttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';  // Adicione esta linha

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { BooksListComponent } from './books-list/books-list.component';
import { HomeComponent } from './home/home.component';
import { BooksDetailComponent } from './books-detail/books-detail.component';
import { BookRegisterComponent } from './book-register/book-register.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    BooksListComponent,
    HomeComponent,
    BooksDetailComponent,
    BookRegisterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [provideHttpClient()],
  bootstrap: [AppComponent]
})
export class AppModule { }
