using ControladorDePedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioItemDaVenda
    {
        Contexto contexto;

        public RepositorioItemDaVenda()
        {
            contexto = new Contexto();
        }

        public void Adicione(ItemDaVenda itemDaVenda)
        {
            var vendaOriginal = contexto.Set<Venda>().Find(itemDaVenda.Venda.Codigo);
            itemDaVenda.Venda = vendaOriginal;

            var produtoOriginal = contexto.Set<Produto>().Find(itemDaVenda.Produto.Codigo);
            itemDaVenda.Produto = produtoOriginal;

            contexto.Set<ItemDaVenda>().Add(itemDaVenda);
            contexto.SaveChanges();
        }

        public void Atualize(ItemDaVenda itemDaVenda)
        {
            var original = contexto.Set<ItemDaVenda>().Find(itemDaVenda.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(itemDaVenda);
            contexto.SaveChanges();
        }

        public List<ItemDaVenda> Liste()
        {
            contexto = new Contexto();
            return contexto.Set<ItemDaVenda>().ToList();
        }

        public List<ItemDaVenda> Liste(int CodigoDaVenda)
        {
            contexto = new Contexto();
            return contexto.Set<ItemDaVenda>().Where(x => x.Venda.Codigo == CodigoDaVenda).ToList();
        }

        public void Excluir(ItemDaVenda itemDaVenda)
        {
            var original = contexto.Set<ItemDaVenda>().Find(itemDaVenda.Codigo);
            contexto.Set<ItemDaVenda>().Remove(original);
            contexto.SaveChanges();
        }
    }
}
