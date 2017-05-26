using ControladorDePedidos.Model;
using System.Collections.Generic;
using System.Linq;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioProduto : RepositorioGenerico<Produto>
    {

        public override void Adicione(Produto item)
        {
            var marcaOriginal = contexto.Set<Marca>().Find(item.Marca.Codigo);
            var fornecedor = contexto.Set<Fornecedor>().Find(item.Fornecedor.Codigo);

            item.Marca = marcaOriginal;
            item.Fornecedor = fornecedor;

            base.Adicione(item);
        }

        public override void Atualize(Produto produto)
        {
            var marcaOriginal = contexto.Set<Marca>().Find(produto.Marca.Codigo);
            var fornecedorOriginal = contexto.Set<Fornecedor>().Find(produto.Fornecedor.Codigo);

            var original = contexto.Set<Produto>().Find(produto.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(produto);

            original.Marca = marcaOriginal;
            original.Fornecedor = fornecedorOriginal;

            contexto.SaveChanges();
        }

        public List<Produto> Buscar(string termoDaBusca)
        {
            contexto = new Contexto();
            var lista = contexto.Set<Produto>().Where(x => x.Nome.Contains(termoDaBusca)).ToList();
            return lista;
        }

        public Produto Buscar(int codigo)
        {
            contexto = new Contexto();
            return contexto.Set<Produto>().FirstOrDefault(x => x.Codigo == codigo);
        }

        public List<Produto> ObtenhaProdutosComEstoqueBaixo()
        {
            contexto = new Contexto();
            var lista = contexto.Set<Produto>().Where(x => x.QuantidadeEmEstoque < x.QuantidadeDesejavelEmEstoque).ToList();
            return lista;
        }
    }
}
