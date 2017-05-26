using ControladorDePedidos.Model;
using System.Linq;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioUsuario : RepositorioGenerico<Usuario>
    {
        
        public static bool ValideAcesso(int codigo, string senha)
        {
            var contexto = new Contexto();
            var usuario = contexto.Set<Usuario>().FirstOrDefault(x => x.Codigo == codigo && x.Senha == senha);
            if (usuario != null)
                return true;
            else
                return false;
        }
    }
}
