using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Interaction logic for FormCadastroDeVenda.xaml
    /// </summary>
    public partial class FormCadastroDeVenda : Window
    {
        RepositorioVenda repositorio;
        RepositorioItemDaVenda repositorioItemDaVenda;
        RepositorioProduto repositorioProduto;

        public int Codigo { get; set; }
        public Venda Venda { get; set; }

        private void InicializeOperacoes()
        {
            repositorio = new RepositorioVenda();
            repositorioItemDaVenda = new RepositorioItemDaVenda();
            repositorioProduto = new RepositorioProduto();
        }

        public FormCadastroDeVenda()
        {
            InitializeComponent();
            InicializeOperacoes();

            var venda = new Venda
            {
                DataDeCadastro = DateTime.Now,
                Status = eStatusDaVenda.NOVA
            };

            repositorio.Adicione(venda);
            Codigo = venda.Codigo;
            Venda = venda;

            lstProdutos.DataContext = venda.ItensDaVenda;
        }

        public FormCadastroDeVenda(Venda venda)
        {
            InitializeComponent();
            InicializeOperacoes();

            lstProdutos.DataContext = venda.ItensDaVenda;
            Codigo = venda.Codigo;
            Venda = venda;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btnObterRecomendacao_Click(object sender, RoutedEventArgs e)
        {
            if (Venda.Status != eStatusDaVenda.NOVA)
            {
                MessageBox.Show("Não é possível adicionar produtos a uma venda já efetivada!");
                return;
            }

            var listaEstoqueBaixo = repositorioProduto.ObtenhaProdutosComEstoqueBaixo();

            foreach (var produto in listaEstoqueBaixo)
            {
                var itemDaVenda = new ItemDaVenda
                {
                    Venda = new Venda { Codigo = this.Codigo },
                    Produto = produto,
                    Quantidade = produto.QuantidadeDesejavelEmEstoque - produto.QuantidadeEmEstoque,
                    Valor = produto.ValorDeVenda
                };

                repositorioItemDaVenda.Adicione(itemDaVenda);
            }

            lstProdutos.DataContext = repositorioItemDaVenda.Liste(Codigo);
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (Venda.Status != eStatusDaVenda.NOVA)
            {
                MessageBox.Show("Não é possível adicionar produtos a uma venda já efetivada!");
                return;
            }

            var formulario = new FormBuscaDeProduto();
            formulario.ShowDialog();
            if (formulario.ProdutoSelecionado != null)
            {
                var itemDaVenda = new ItemDaVenda
                {
                    Venda = new Venda { Codigo = this.Codigo },
                    Produto = formulario.ProdutoSelecionado,
                    Quantidade = formulario.Quantidade,
                    Valor = formulario.ProdutoSelecionado.ValorDeVenda
                };

                repositorioItemDaVenda.Adicione(itemDaVenda);
                lstProdutos.DataContext = repositorioItemDaVenda.Liste(Codigo);
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var itemDaVenda = (ItemDaVenda)lstProdutos.SelectedItem;
            repositorioItemDaVenda.Excluir(itemDaVenda);
            lstProdutos.DataContext = repositorioItemDaVenda.Liste(Codigo);
        }
    }
}
