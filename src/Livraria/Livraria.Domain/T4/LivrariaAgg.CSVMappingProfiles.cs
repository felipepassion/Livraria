
using CsvHelper.Configuration;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles
{
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Entities;
	public partial class Livro_AutorCsvMap : ClassMap<Livro_Autor>
	{
		public Livro_AutorCsvMap()
		{
			Map(x=>x.Livro_Codl).Name("Livro_Codl");Map(x=>x.Autor_CodAut).Name("Autor_CodAut");Map(x=>x.Autor.CodAu).Name("Autor_CodAu");Map(x=>x.Autor.Nome).Name("Autor_Nome");Map(x=>x.Livro.AnoPublicacao).Name("Livro_AnoPublicacao");Map(x=>x.Livro.Assunto.CodAs).Name("Livro_Assunto_CodAs");Map(x=>x.Livro.Assunto.Descricao).Name("Livro_Assunto_Descricao");Map(x=>x.Livro.Edicao).Name("Livro_Edicao");Map(x=>x.Livro.Editora).Name("Livro_Editora");Map(x=>x.Livro.Titulo).Name("Livro_Titulo");
		}
	}
	public partial class LivroCsvMap : ClassMap<Livro>
	{
		public LivroCsvMap()
		{
			Map(x=>x.Titulo).Name("Titulo");Map(x=>x.Editora).Name("Editora");Map(x=>x.Edicao).Name("Edicao");Map(x=>x.AnoPublicacao).Name("AnoPublicacao");Map(x=>x.Autor.CodAu).Name("Autor_CodAu");Map(x=>x.Autor.Nome).Name("Autor_Nome");Map(x=>x.Assunto.CodAs).Name("Assunto_CodAs");Map(x=>x.Assunto.Descricao).Name("Assunto_Descricao");
		}
	}
	public partial class AssuntoCsvMap : ClassMap<Assunto>
	{
		public AssuntoCsvMap()
		{
			Map(x=>x.CodAs).Name("CodAs");Map(x=>x.Descricao).Name("Descricao");
		}
	}
	public partial class Livro_AssuntoCsvMap : ClassMap<Livro_Assunto>
	{
		public Livro_AssuntoCsvMap()
		{
			Map(x=>x.Livro_Codl).Name("Livro_Codl");Map(x=>x.Assunto_CodAut).Name("Assunto_CodAut");Map(x=>x.Assunto.CodAs).Name("Assunto_CodAs");Map(x=>x.Assunto.Descricao).Name("Assunto_Descricao");Map(x=>x.Livro.AnoPublicacao).Name("Livro_AnoPublicacao");Map(x=>x.Livro.Autor.CodAu).Name("Livro_Autor_CodAu");Map(x=>x.Livro.Autor.Nome).Name("Livro_Autor_Nome");Map(x=>x.Livro.Edicao).Name("Livro_Edicao");Map(x=>x.Livro.Editora).Name("Livro_Editora");Map(x=>x.Livro.Titulo).Name("Livro_Titulo");
		}
	}
	public partial class AutorCsvMap : ClassMap<Autor>
	{
		public AutorCsvMap()
		{
			Map(x=>x.CodAu).Name("CodAu");Map(x=>x.Nome).Name("Nome");
		}
	}
	public partial class LivrariaAggSettingsCsvMap : ClassMap<LivrariaAggSettings>
	{
		public LivrariaAggSettingsCsvMap()
		{
			Map(x=>x.UserId).Name("UserId");
		}
	}
}
