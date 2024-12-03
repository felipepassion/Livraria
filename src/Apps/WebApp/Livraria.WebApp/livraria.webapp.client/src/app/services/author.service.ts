// autor.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Autor } from '../models/autor.model';

@Injectable({
  providedIn: 'root'

})
export class AutorService {

  private apiUrl = 'https://localhost:5006/api/autor';

  constructor(private http: HttpClient) { }

  getAutores() {
    return this.http.get<{
      data: Autor[]
    }>(this.apiUrl);
  }
}
