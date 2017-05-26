using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;
using System.Windows.Input;

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for FormBuscaDeProduto.xaml
    /// </summary>
    public partial class FormBuscaDeProduto : Window
    {
        RepositorioProduto repositorio;
        public Produto ProdutoSelecionado { get; set; }
        public int Quantidade { get; set; }

        public FormBuscaDeProduto()
        {
            InitializeComponent();
            repositorio = new RepositorioProduto();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstProdutos.DataContext = repositorio.Liste();
        }

        private void txtTermoDaBusca_KeyDown(object sender, KeyEventArgs e)
        {
            var listaDeProdutos = repositorio.Buscar(txtTermoDaBusca.Text);
            lstProdutos.DataContext = listaDeProdutos;
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item na lista");
                return;
            }

            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade");
                return;
            }

            int quantidade;

            if (int.TryParse(txtQuantidade.Text, out quantidade))
            {
                Quantidade = quantidade;
            }
            else
            {
                MessageBox.Show("Informe um valor numérico no campo Quantidade");
                return;
            }

            ProdutoSelecionado = (Produto)lstProdutos.SelectedItem;
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }
    }
}
