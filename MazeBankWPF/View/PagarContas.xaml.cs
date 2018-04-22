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
    /// Interaction logic for PagarContas.xaml
    /// </summary>
    public partial class PagarContas : Window {
        private static Conta minhaConta;
        private static double saldo;

        public PagarContas(Conta conta) {
            minhaConta = conta;
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, RoutedEventArgs e) {
            bool pagar = Pagar();
            if (pagar == false) {
                MessageBoxResult result = MessageBox.Show("Saldo indisponível!");
            }
            else {
                ContaController cc = new ContaController();
                minhaConta.Saldo -= saldo;
                cc.EditarConta(minhaConta);
                MessageBoxResult result = MessageBox.Show("Pagamento realizado com sucesso!");
                Close();
            }
        }

        private bool Pagar() {
            ContasPagas contaPagar = new ContasPagas();
            contaPagar.Boleto = int.Parse(txt_Boleto.Text);
            contaPagar.ContaID = minhaConta.ContaID;
            saldo = double.Parse(txt_Valor.Text);
            contaPagar.Valor = saldo;

            if (saldo > minhaConta.Saldo) {
                return false;
            }
            else {
                ContasPagasController cp = new ContasPagasController();
                cp.SalvarContaPaga(contaPagar);
                return true;
            }
        }
    }
}
