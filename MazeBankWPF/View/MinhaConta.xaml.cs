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

namespace View {
    /// <summary>
    /// Interaction logic for MinhaConta.xaml
    /// </summary>
    public partial class MinhaConta : Window {

        private static Conta minhaConta;
        private static Cliente meuCliente;

        public MinhaConta(Conta contaCliente, Cliente cliente) {
            minhaConta = contaCliente;
            meuCliente = cliente;
            InitializeComponent();
        }



        private void btn_Saldo(object sender, RoutedEventArgs e) {
            MessageBoxResult saldo = MessageBox.Show("Saldo: R$" + minhaConta.Saldo);
        }

        private void btn_Deposito(object sender, RoutedEventArgs e) {
            Depositos depositos = new Depositos(minhaConta);
            depositos.Show();
        }

        private void btn_Pagamentos(object sender, RoutedEventArgs e) {

        }

        private void btn_Transferencias(object sender, RoutedEventArgs e) {
            Transferencias transferencias = new Transferencias(minhaConta);
            transferencias.Show();
        }

        private void btn_EditConta(object sender, RoutedEventArgs e) {

        }

        private void btn_Excluir(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Deseja realmente exluir a conta?","Excluir conta", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                MessageBoxResult res = MessageBox.Show("APERTOU YES");
            } else
            {

            }
            //ContaController cc = new ContaController();
            //cc.ExcluirConta(minhaConta.ContaID);
            //EnderecoController ec = new EnderecoController();
            //ec.ExcluirEndereco(meuCliente.EnderecoID);
            //ClienteController cli = new ClienteController();
            //cli.ExcluirCliente(meuCliente.ClienteID);
        }
    }
}
