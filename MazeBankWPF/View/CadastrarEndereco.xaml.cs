using Controller;
using Models;
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
    /// Interaction logic for CadastrarEndereco.xaml
    /// </summary>
    public partial class CadastrarEndereco : Window
    {
        public CadastrarEndereco()
        {
            InitializeComponent();
        }

        private void SalvarEndereco() {
            Endereco end = new Endereco();
            end.Rua = txt_Rua.Text;
            end.Numero = int.Parse(txt_Numero.Text);
            end.Complemento = txt_Complemento.Text;
            end.Cidade = txt_Cidade.Text;
            end.Estado = txt_Estado.Text;

            EnderecoController.SalvarEndereco(end);
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e) {
            SalvarEndereco();
            CadastrarConta cadConta = new CadastrarConta();
            cadConta.Show();
            Close();
        }
    }
}
