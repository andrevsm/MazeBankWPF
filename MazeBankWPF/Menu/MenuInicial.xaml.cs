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

namespace Menu
{
    /// <summary>
    /// Interaction logic for MenuInicial.xaml
    /// </summary>
    public partial class MenuInicial : Window
    {
        public MenuInicial()
        {
            InitializeComponent();
        }
        private void btnCadastrarConta_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cadCli = new CadastrarCliente();
            cadCli.Show();

        }

        private void btnAcessarConta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
