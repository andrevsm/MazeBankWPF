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
    /// Interaction logic for Depositos.xaml
    /// </summary>
    public partial class Depositos : Window {
        private static Conta conta;

        public Depositos(Conta minhaConta) {
            conta = minhaConta;
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, RoutedEventArgs e)
        {
            conta.Saldo = Double.Parse(txt_Valor.Text);
            ContaController cc = new ContaController();
            cc.EditarConta(conta);
            MessageBoxResult deposito = MessageBox.Show("Depósito realizado com sucesso!");
            Close();
        }
    }
}
