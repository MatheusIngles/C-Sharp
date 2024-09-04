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

namespace Exercicio_2
{
    /// <summary>
    /// Lógica interna para BomDia.xaml
    /// </summary>
    public partial class BomDia : Window
    {
        public BomDia()
        {
            InitializeComponent();
        }

        private void Botao_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
