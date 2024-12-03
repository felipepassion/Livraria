// assunto.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AssuntoService {

  private apiUrl = 'https://localhost:5006/api/assunto/search';

  constructor(private http: HttpClient) { }

  getAssuntos(): Observable<any> {
    return this.http.get(this.apiUrl);
  }
}
