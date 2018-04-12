using Models;
using Controller;
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

namespace View
{
    /// <summary>
    /// Interaction logic for CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }   
        private void SalvarCliente()
        {
            Cliente cli = new Cliente();
            cli.Nome = txt_NomeCliente.Text;
            cli.Cpf = txt_CPF.Text;
            cli.Nascimento = txt_DataNascimento.Text;

            ClienteController.SalvarCliente(cli);
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            SalvarCliente();
            CadastrarEndereco cadEndereco = new CadastrarEndereco();
            cadEndereco.Show();
            Close();
        }
    }
}
