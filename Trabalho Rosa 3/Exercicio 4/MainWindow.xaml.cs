using System.ComponentModel;
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

namespace Exercicio_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BindingList<ResultadoConsulta> ListUsers = [];
        List<int> ids = [];
        Bosta b = new Bosta();

        public MainWindow()
        {
            InitializeComponent();
            Datadados.ItemsSource = ListUsers;
            Nome.ItemsSource = ids;
            add();
        }

        public void add()
        {
            for (int i = 0; i < 100; i++) { 
                ResultadoConsulta consulta = new ResultadoConsulta();
                consulta.Nome = $"Consulta:{i}";
                consulta.ID = i;
                ListUsers.Add(consulta);
                ids.Add(i);
            }
        }

        private void Nome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ListUsers) { 
                if(Nome.Items.Contains(item.ID)|| Conteudo.Text == item.Nome)
                {
                    b.Show();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button_Click_1(sender, e);
        }
    }
}