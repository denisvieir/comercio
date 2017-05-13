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
    /// Interaction logic for FormProdutos.xaml
    /// </summary>
    public partial class FormProdutos : Window
    {
        RepositorioProduto repositorioProduto;
        public FormProdutos()
        {
            repositorioProduto = new RepositorioProduto();
            InitializeComponent();
        }


        private void btnMarcas_Click(object sender, RoutedEventArgs e)
        {
            var formMarca = new FormMarcas();
            formMarca.Show();
        }

        private void CarregueElementosDoBancoDeDados()
        {
            lstProdutos.DataContext = repositorioProduto.Liste();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroDeProduto = new FormCadastroDeProduto();
            formCadastroDeProduto.ShowDialog();
            CarregueElementosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if(lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var produto = (Produto)lstProdutos.SelectedItem;

            var formCadastroDeProduto = new FormCadastroDeProduto(produto);
            formCadastroDeProduto.ShowDialog();
            CarregueElementosDoBancoDeDados();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElementosDoBancoDeDados();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElementosDoBancoDeDados();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var produto = (Produto)lstProdutos.SelectedItem;
            repositorioProduto.Excluir(produto);
            CarregueElementosDoBancoDeDados();
        }
    }
}
