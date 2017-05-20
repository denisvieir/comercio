using ControladorDePedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioVenda
    {
        Contexto contexto;

        public RepositorioVenda()
        {
            contexto = new Contexto();
        }

        public void Adicione(Venda venda)
        {
            contexto.Set<Venda>().Add(venda);
            contexto.SaveChanges();
        }

        public void Atualize(Venda venda)
        {
            var original = contexto.Set<Venda>().Find(venda.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(venda);
            contexto.SaveChanges();
        }

        public List<Venda> Liste()
        {
            contexto = new Contexto();
            return contexto.Set<Venda>().ToList();
        }

        public void Excluir(Venda venda)
        {
            var original = contexto.Set<Venda>().Find(venda.Codigo);
            contexto.Set<Venda>().Remove(original);
            contexto.SaveChanges();
        }
    }
}
