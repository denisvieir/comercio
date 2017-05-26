using ControladorDePedidos.Model;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public Usuario Usuario { get; set; }
        public MenuPrincipal(Usuario usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            if(!Usuario.Administrador && !Usuario.Produtos)
            {
                MessageBox.Show("Acesso Negado");
                return;
            }

            var janelaProdutos = new FormProdutos();
            janelaProdutos.Show();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {

            if (!Usuario.Administrador)
            {
                MessageBox.Show("Acesso Negado");
                return;
            }

            var janelaUsuarios = new FormUsuarios();
            janelaUsuarios.Show();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            if (!Usuario.Administrador && !Usuario.Clientes)
            {
                MessageBox.Show("Acesso Negado");
                return;
            }

            var janelaUsuarios = new FormClientes();
            janelaUsuarios.Show();
        }

        private void btnCompras_Click(object sender, RoutedEventArgs e)
        {

            if (!Usuario.Administrador && !Usuario.Compras)
            {
                MessageBox.Show("Acesso Negado");
                return;
            }

            var janelaCompras = new FormCompras();
            janelaCompras.Show();
        }

        private void btnVendas_Click(object sender, RoutedEventArgs e)
        {
            if(!Usuario.Administrador && !Usuario.Vendas)
            {
                MessageBox.Show("Acesso Negado");
                return;
            }
            var janelaVendas = new FormVendas();
            janelaVendas.Show();
        }
    }
}
