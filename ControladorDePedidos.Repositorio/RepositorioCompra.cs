using ControladorDePedidos.Model;
using System.Data.Entity.Infrastructure;
using System.Windows;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioCompra : RepositorioGenerico<Compra>
    {
        public override void Excluir(Compra item)
        {
            try
            {
                contexto.Set<ItemDaCompra>().RemoveRange(item.ItensDaCompra);

                var original = contexto.Set<Compra>().Find(item.Codigo);
                contexto.Set<Compra>().Remove(original);
                contexto.SaveChanges();

            }
            catch (DbUpdateException e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }
    }
}
