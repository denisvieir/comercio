using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for FormCadastroDeClientes.xaml
    /// </summary>
    public partial class FormCadastroDeCliente : Window
    {
        RepositorioCliente repositorio;

        public FormCadastroDeCliente()
        {
            repositorio = new RepositorioCliente();
            InitializeComponent();
            this.DataContext = new Cliente();

        }

        public FormCadastroDeCliente(Cliente cliente)
        {
            repositorio = new RepositorioCliente();
            InitializeComponent();
            this.DataContext = cliente;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var clientes = repositorio.Liste();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var cliente = (Cliente)this.DataContext;

            if (cliente.Codigo == 0)
            {
                repositorio.Adicione(cliente);
            }
            else
            {
                repositorio.Atualize(cliente);
            }
            this.Close();
        }
    }
}
