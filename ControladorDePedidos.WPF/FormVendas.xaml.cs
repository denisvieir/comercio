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
    /// Interaction logic for FormVendas.xaml
    /// </summary>
    public partial class FormVendas : Window
    {
        RepositorioVenda repositorio;

        public FormVendas()
        {
            repositorio = new RepositorioVenda();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void CarregueElemtosDoBancoDeDados()
        {
            lstVendas.DataContext = repositorio.Liste();
        }

        private void btnMarcas_Click(object sender, RoutedEventArgs e)
        {
            var formMarca = new FormMarcas();
            formMarca.Show();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var formCadastroDeVenda = new FormCadastroDeVenda();
            formCadastroDeVenda.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (lstVendas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var pompra = (Venda)lstVendas.SelectedItem;
            var formCadastroDeVenda = new FormCadastroDeVenda(pompra);
            formCadastroDeVenda.ShowDialog();
            CarregueElemtosDoBancoDeDados();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregueElemtosDoBancoDeDados();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (lstVendas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }

            var venda = (Venda)lstVendas.SelectedItem;
            repositorio.Excluir(venda);
            CarregueElemtosDoBancoDeDados();
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            // 1 Listar itens da venda para enviar ao fornecedor
            if (lstVendas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item");
                return;
            }
            var venda = (Venda)lstVendas.SelectedItem;

            if (venda.Status != eStatusDaVenda.NOVA)
            {
                MessageBox.Show("Essam venda já foi efetivada!");
                return;
            }

            if (venda.ItensDaVenda.Count == 0)
            {
                MessageBox.Show("Nenhum item a ser vendado nessa solititação de venda");
                return;
            }

            var itensDaVenda = ObtenhaListaDeItensDaVenda(venda);

            // 2 Atualizar o banco de dados informando que a venda foi realizada
            venda.Status = eStatusDaVenda.EFETIVADA;
            venda.DataDaEfetivacao = DateTime.Now;
            repositorio.Atualize(venda);
            CarregueElemtosDoBancoDeDados();
        }

        private static List<ItemDaVenda> ObtenhaListaDeItensDaVenda(Venda venda)
        {
            var repositorioItemDaVenda = new RepositorioItemDaVenda();
            var itensDaVenda = repositorioItemDaVenda.Liste(venda.Codigo);
            return itensDaVenda;
        }
    }
}
