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
    /// Interaction logic for AcessarConta.xaml
    /// </summary>
    public partial class AcessarConta : Window
    {
        public AcessarConta()
        {
            InitializeComponent();
        }

        private void btnAcessarConta_Click(object sender, RoutedEventArgs e)
        {
            Conta conta = new Conta();
            conta.ContaID = int.Parse(txt_Conta.Text);
            conta.Agencia = int.Parse(txt_Agencia.Text);
            conta.Senha = txt_Senha.Text;

            ContaController cc = new ContaController();
            Conta contaVerificada = cc.PesquisarConta(conta);

            if (contaVerificada != null)
            {
                ClienteController cli = new ClienteController();
                Cliente cliente = cli.PesquisarClientePorContaID(contaVerificada.ContaID);
                MinhaConta minhaConta = new MinhaConta(contaVerificada);
                minhaConta.Show();
                Close();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Dados incorretos!!");
            }

        }
    }
}