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
    /// Interaction logic for FormCadastroDeCompra.xaml
    /// </summary>
    public partial class FormCadastroDeCompra : Window
    {
        RepositorioCompra repositorio;
        RepositorioItemDaCompra repositorioItemDaCompra;
        RepositorioProduto repositorioProduto;


        public int Codigo { get; set; }
        public Compra Compra { get; set; }

        private void InicializeOperacoes()
        {
            repositorio = new RepositorioCompra();
            repositorioItemDaCompra = new RepositorioItemDaCompra();
            repositorioProduto = new RepositorioProduto();
        }

        public FormCadastroDeCompra()
        {
            InitializeComponent();
            InicializeOperacoes();

            var compra = new Compra
            {
                DataDeCadastro = DateTime.Now,
                Status = eStatusDaCompra.NOVA
            };

            repositorio.Adicione(compra);
            Codigo = compra.Codigo;
            Compra = compra;

            lstProdutos.DataContext = compra.ItensDaCompra;
        }

        public FormCadastroDeCompra(Compra compra)
        {
            InitializeComponent();
            InicializeOperacoes();

            lstProdutos.DataContext = compra.ItensDaCompra;
            Codigo = compra.Codigo;
            Compra = compra;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void btnObterRecomendacao_Click(object sender, RoutedEventArgs e)
        {
            if (Compra.Status != eStatusDaCompra.NOVA)
            {
                MessageBox.Show("Não é possível adicionar produtos a uma compra já efetivada!");
                return;
            }

            var listaEstoqueBaixo = repositorioProduto.ObtenhaProdutosComEstoqueBaixo();

            foreach (var produto in listaEstoqueBaixo)
            {
                var itemDaCompra = new ItemDaCompra
                {
                    Compra = new Compra { Codigo = this.Codigo },
                    Produto = produto,
                    Quantidade = produto.QuantidadeDesejavelEmEstoque - produto.QuantidadeEmEstoque,
                    Valor = produto.ValorDeCompra
                };

                repositorioItemDaCompra.Adicione(itemDaCompra);
            }

            lstProdutos.DataContext = repositorioItemDaCompra.Liste(Codigo);
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            if (Compra.Status != eStatusDaCompra.NOVA)
            {
                MessageBox.Show("Não é possível adicionar produtos a uma compra já efetivada!");
                return;
            }

            var formulario = new FormBuscaDeProduto();
            formulario.ShowDialog();
            if (formulario.ProdutoSelecionado != null)
            {
                var itemDaCompra = new ItemDaCompra
                {
                    Compra = new Compra { Codigo = this.Codigo },
                    Produto = formulario.ProdutoSelecionado,
                    Quantidade = formulario.Quantidade,
                    Valor = formulario.ProdutoSelecionado.ValorDeCompra
                };

                repositorioItemDaCompra.Adicione(itemDaCompra);
                lstProdutos.DataContext = repositorioItemDaCompra.Liste(Codigo);
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

            var itemDaCompra = (ItemDaCompra)lstProdutos.SelectedItem;
            repositorioItemDaCompra.Excluir(itemDaCompra);
            lstProdutos.DataContext = repositorioItemDaCompra.Liste(Codigo);
        }
    }
}