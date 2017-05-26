using ControladorDePedidos.Model;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioGenerico<T> where T : ClasseBase
    {
        protected Contexto contexto;

        public RepositorioGenerico()
        {
            contexto = new Contexto();
        }

        public virtual void Adicione(T item)
        {
            contexto.Set<T>().Add(item);
            contexto.SaveChanges();
        }

        public virtual void Atualize(T item)
        {
            var original = contexto.Set<T>().Find(item.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(item);
            contexto.SaveChanges();
        }

        public List<T> Liste()
        {
            return contexto.Set<T>().ToList();
        }

        public virtual void Excluir(T item)
        {
            try {
                var original = contexto.Set<T>().Find(item.Codigo);
                contexto.Set<T>().Remove(original);
                contexto.SaveChanges();
            }catch(DbUpdateException e)
            {
                MessageBox.Show("Não é possível excluir itens associados");
            }
        }

    }
}
