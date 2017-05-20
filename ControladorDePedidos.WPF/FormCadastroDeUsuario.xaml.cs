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
    /// Interaction logic for FormCadastroDeUsuario.xaml
    /// </summary>
    public partial class FormCadastroDeUsuario : Window
    {
        RepositorioUsuario repositorio;

        public FormCadastroDeUsuario()
        {            
            repositorio = new RepositorioUsuario();
            InitializeComponent();
            this.DataContext = new Usuario();

        }

        public FormCadastroDeUsuario(Usuario usuario)
        {            
            repositorio = new RepositorioUsuario();
            InitializeComponent();
            this.DataContext = usuario;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var usuarios = repositorio.Liste();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var usuario = (Usuario)this.DataContext;

            if (usuario.Codigo == 0)
            {
                repositorio.Adicione(usuario);
            }
            else
            {
                repositorio.Atualize(usuario);
            }
            this.Close();
        }
    }
}