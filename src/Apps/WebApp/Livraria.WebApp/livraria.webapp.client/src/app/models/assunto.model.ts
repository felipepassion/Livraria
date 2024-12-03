import { Livro } from "./livro.model";

export interface Assunto {
  id: number;
  descricao: string;
  livros: Livro[]
}
