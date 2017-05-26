using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Windows;

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

            usuario.Senha = string.IsNullOrWhiteSpace(senha.Password) ? usuario.Senha :  senha.Password;

            if (usuario.Codigo == 0)
            {
                if (senha.Password != confirmarSenha.Password)
                {
                    MessageBox.Show("Senhas diferentes!");
                    return;
                }
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