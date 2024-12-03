import { Assunto } from "./assunto.model";
import { Autor } from "./autor.model";

// livro.model.ts
export interface Livro {
  titulo: string;
  editora: string;
  edicao: number;
  anoPublicacao: Date
  autores: Autor[];
  assuntos: Assunto[];
}
