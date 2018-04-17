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
    /// Interaction logic for Transferencias.xaml
    /// </summary>
    public partial class Transferencias : Window {
        private static Conta minhaConta;

        public Transferencias(Conta conta) {
            minhaConta = conta;
            InitializeComponent();
        }

        private void btnTransferir_Click(object sender, RoutedEventArgs e)
        {
            bool transferencia = Transferir();
            if(transferencia == false) {
                MessageBoxResult result = MessageBox.Show("Dados incorretos!");
            } else {
                MessageBoxResult result = MessageBox.Show("Transferência realizada com sucesso!");
                Close();
            }
        }

        private bool Transferir() {
            Conta contaTransferir = new Conta();
            contaTransferir.Agencia = int.Parse(txt_Agencia.Text);
            contaTransferir.ContaID = int.Parse(txt_Conta.Text);
            double saldo = double.Parse(txt_Valor.Text);

            ContaController cc = new ContaController();
            Conta contaTransferida = cc.Transferir(contaTransferir, saldo);

            if(contaTransferida == null) {
                return false;
            } else {
                return true;
            }
        }
    }
}
