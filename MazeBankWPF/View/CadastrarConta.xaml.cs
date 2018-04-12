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
    /// Interaction logic for CadastrarConta.xaml
    /// </summary>
    public partial class CadastrarConta : Window
    {
        public CadastrarConta()
        {
            InitializeComponent();
        }
        private void SalvarConta() {
            Conta conta = new Conta();
            conta.Agencia = int.Parse(txt_Agencia.Text);
            conta.Senha = txt_Senha.Text;

            ContaController.SalvarConta(conta);
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e) {
            SalvarConta();
            Close();
            MessageBoxResult result = MessageBox.Show("CONTA REALIZADA COM SUCESSO!!!");
        }



    }
}
