using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicio_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Amigos> ListaDeAmigos = [];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            Amigos a = new Amigos();
            a.Telefone = int.Parse(Telefon.Text);
            a.Apelido = Apelido.Text;
            a.Email = Email.Text;
            ListaDeAmigos.Add(a);
            Listar_Click(sender, e);
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            foreach (var amigos in ListaDeAmigos)
            {
                if (Apelido.Text == amigos.Apelido || int.Parse(Telefon.Text) == amigos.Telefone || amigos.Email == Email.Text)
                {
                    Resposta.Text = $"Sim encontrado:\n- Apelido:{amigos.Apelido}; telefone:{amigos.Telefone}; email:{amigos.Email}";
                }
            }
        }

        private void Remover_Click(object sender, RoutedEventArgs e)
        {
            Amigos a = new();
            foreach (var amigos in ListaDeAmigos) {
                if (Apelido.Text == amigos.Apelido && int.Parse(Telefon.Text) == amigos.Telefone && amigos.Email == Email.Text) { 
                    a = amigos;
                }
            }
            ListaDeAmigos.Remove(a);
            Listar_Click(sender, e);
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            string x = "";
            foreach (var amigos in ListaDeAmigos) {
                x += $"- Apelido:{amigos.Apelido}; telefone:{amigos.Telefone}; email:{amigos.Email}\n";
            }
            Resposta.Text = x;
        }
    }
}