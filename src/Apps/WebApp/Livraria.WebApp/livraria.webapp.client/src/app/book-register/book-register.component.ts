import { Component, OnInit } from '@angular/core';
import { AssuntoService } from '../services/assunto.service';
import { Assunto } from '../models/assunto.model';  // Importando a interface Assunto
import { Autor } from '../models/autor.model';  // Importando a interface Autor
import { AutorService } from '../services/author.service';
import { LivroService } from '../services/livro.service';
import { Livro } from '../models/livro.model';

@Component({
  selector: 'bookRegister-component',
  standalone: false,
  templateUrl: './book-register.component.html',
  styleUrls: ['./book-register.component.css']
})
export class BookRegisterComponent implements OnInit {
  assuntos: Assunto[] = [];
  autores: Autor[] = [];
  selectedAssuntos: Assunto[] = [];
  selectedAutores: Autor[] = [];
  autorId: string = '';
  assuntoId: string = '';
  titulo: string = '';
  editora: string = '';
  edicao: number = 1;
  anoPublicacao: number = 2024;

  constructor(
    private assuntoService: AssuntoService,
    private autorService: AutorService,  // Injetando o AutorService
    private livroService: LivroService
  ) { }

  ngOnInit() {
    this.loadAssuntos();
    this.loadAutores();
  }

  loadAssuntos() {
    this.assuntoService.getAssuntos().subscribe((response: any) => {
      this.assuntos = Array.isArray(response.data.$values) ? response.data.$values : [response.data];
    });
  }

  loadAutores() {
    this.autorService.getAutores().subscribe(response => {
      // Se a resposta data for um objeto único, coloque-o dentro de um array
      this.autores = Array.isArray(response.data) ? response.data : [response.data];
    });
  }


  addAutor(): void {
    const autor = this.autores.find(a => a.id === Number.parseInt(this.autorId));
    if (autor && !this.selectedAutores.find(a => a.id === autor.id)) {
      this.selectedAutores = [...this.selectedAutores, autor];
    }
    this.autorId = '';
  }

  addAssunto(): void {
    const assunto = this.assuntos.find(a => a.id === Number.parseInt(this.assuntoId));
    if (assunto && !this.selectedAssuntos.find(a => a.id === assunto.id)) {
      this.selectedAssuntos = [...this.selectedAssuntos, assunto];
    }
    this.assuntoId = '';
  }

  setAutorId(event: Event): void {
    this.autorId = (event.target as HTMLSelectElement).value;
  }

  setAssuntoId(event: Event): void {
    this.assuntoId = (event.target as HTMLSelectElement).value;
  }

  removeAutor(autor: Autor): void {
    this.selectedAutores = this.selectedAutores.filter(a => a.id !== autor.id);
  }

  removeAssunto(assunto: Assunto): void {
    this.selectedAssuntos = this.selectedAssuntos.filter((a: Assunto) => a.id !== assunto.id);
  }

  createLivro(): void {
    const livro: Livro = {
      titulo: this.titulo,
      editora: this.editora,
      edicao: this.edicao,
      anoPublicacao: new Date(this.anoPublicacao),
      autores: this.selectedAutores.map(a => ({
        id: a.id,
        nome: a.nome, // Incluindo o nome do autor
        livros: [] // Livros vazios, ou preenchidos conforme necessário
      })),
      assuntos: this.selectedAssuntos.map(a => ({
        id: a.id,
        descricao: a.descricao, // Incluindo a descrição do assunto
        livros: [] // Livros vazios, ou preenchidos conforme necessário
      }))
    };

    // Chama o serviço para enviar o livro
    this.livroService.createLivro(livro).subscribe(
      response => {
        console.log('Livro criado com sucesso', response);
      },
      error => {
        console.error('Erro ao criar livro', error);
      }
    );
  }
}
