using ControladorDePedidos.Model;
using System.Data.Entity.Infrastructure;
using System.Windows;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioVenda : RepositorioGenerico<Venda>
    {
        public override void Adicione(Venda item)
        {
            if(item.Cliente != null)
                item.Cliente = contexto.Set<Cliente>().Find(item.Cliente.Codigo);
            
            base.Adicione(item);
        }

        public override void Atualize(Venda item)
        {
            
            var original = contexto.Set<Venda>().Find(item.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(item);

            if (item.Cliente != null)
                item.Cliente = contexto.Set<Cliente>().Find(item.Cliente.Codigo);

            contexto.SaveChanges();
            
        }

        public override void Excluir(Venda item)
        {
            try
            {
                contexto.Set<ItemDaVenda>().RemoveRange(item.ItensDaVenda);

                var original = contexto.Set<Venda>().Find(item.Codigo);
                contexto.Set<Venda>().Remove(original);
                contexto.SaveChanges();

            }catch(DbUpdateException e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
    }
}
