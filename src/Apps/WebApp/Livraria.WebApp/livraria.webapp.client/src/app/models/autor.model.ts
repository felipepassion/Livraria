import { Livro } from "./livro.model";

// autor.model.ts
export interface Autor {
  id: number;
  nome: string;
  livros: Livro[];
}
