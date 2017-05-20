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
    /// Interaction logic for FormCompras.xaml
    /// </summary>
    public partial class FormCompras : Window
    {

        RepositorioCompra repositorio;

        public FormCompras()
        {
            repositorio = new RepositorioCompra();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstCompras.DataContext = repositorio.Liste();
        }

        private void btnMarcas_Click(object sender, RoutedEventArgs e)
        {
            var formMarca = new FormMarcas();
            formMarca.Show();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroDeCompra = new FormCadastroDeCompra();
            formCadastroDeCompra.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (lstCompras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var pompra = (Compra)lstCompras.SelectedItem;
            var formCadastroDeCompra = new FormCadastroDeCompra(pompra);
            formCadastroDeCompra.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstCompras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var pompra = (Compra)lstCompras.SelectedItem;
            repositorio.Excluir(pompra);
            CarregueElemtosDoBancoDeDados();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            // 1 Listar itens da compra para enviar ao fornecedor
            if (lstCompras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }
            var compra = (Compra)lstCompras.SelectedItem;

            if (compra.Status != eStatusDaCompra.NOVA)
            {
                MessageBox.Show("Essam compra já foi efetivada!");
                return;
            }

            if (compra.ItensDaCompra.Count == 0)
            {
                MessageBox.Show("Nenhum item a ser comprado nessa solititação de compra");
                return;
            }

            var itensDaCompra = ObtenhaListaDeItensDaCompra(compra);

            string listaString = "";

            foreach (var item in itensDaCompra)
            {
                listaString += $"{item.Quantidade} - {item.Produto.Nome} {item.Produto.Marca.Nome} \n";
            }

            // 2 Enviar e-mail ao fornecedor col a lista de compra

            // Todo Enviar e-mail

            // 3 Atualizar o banco de dados informando que a compra foi realizada
            compra.Status = eStatusDaCompra.EFETIVADA;
            compra.DataDaEfetivacao = DateTime.Now;
            repositorio.Atualize(compra);
            CarregueElemtosDoBancoDeDados();
        }

        private static List<ItemDaCompra> ObtenhaListaDeItensDaCompra(Compra compra)
        {
            var repositorioItemDaCompra = new RepositorioItemDaCompra();
            var itensDaCompra = repositorioItemDaCompra.Liste(compra.Codigo);
            return itensDaCompra;
        }

        private void btnCompraRecebida_Click(object sender, RoutedEventArgs e)
        {
            if (lstCompras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var compra = (Compra)lstCompras.SelectedItem;

            if (compra.Status != eStatusDaCompra.EFETIVADA)
            {
                MessageBox.Show("Essam compra deve estar efetivada!");
                return;
            }

            // Adicionar no estoque
            var itensDaCompra = ObtenhaListaDeItensDaCompra(compra);
            var repositorioDeProduto = new RepositorioProduto();

            foreach (var item in itensDaCompra)
            {
                var produtoDaCompra = item.Produto;
                var produtoDoBanco = repositorioDeProduto.Buscar(produtoDaCompra.Codigo);
                produtoDoBanco.QuantidadeEmEstoque += item.Quantidade;
                repositorioDeProduto.Atualize(produtoDoBanco);
            }

            // Atulizar o banco de dados
            compra.Status = eStatusDaCompra.RECEBIDA;
            compra.DataDoRecebimento = DateTime.Now;
            repositorio.Atualize(compra);
            CarregueElemtosDoBancoDeDados();
        }
    }
}
