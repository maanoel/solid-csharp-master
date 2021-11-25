using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
	public interface ILeilaoDao
	{
		public IEnumerable<Categoria> BuscarCategorias();

		public Leilao BuscarPorId(int id);

		public IEnumerable<Leilao> BuscarLeiloes();

		public void Incluir(Leilao leilao);

		public void Alterar(Leilao leilao);

		public void Excluir(Leilao leilao);
	}
}
