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
    public partial class ExcluirConta : Window {

        public ExcluirConta() {
            InitializeComponent();
        }

        public bool ExcluirAConta() {
            Conta conta = new Conta();
            conta.ContaID = int.Parse(txt_Conta.Text);
            conta.Agencia = int.Parse(txt_Agencia.Text);
            conta.Senha = txt_Senha.Text;

            ContaController cc = new ContaController();
            Conta contaVerificada = cc.PesquisarConta(conta);

            if (contaVerificada != null) {
                EnderecoController ec = new EnderecoController();
                ClienteController cli = new ClienteController();
                Cliente cliente = cli.PesquisarClientePorContaID(contaVerificada.ContaID);
                cc.ExcluirConta(contaVerificada.ContaID);
                ec.ExcluirEndereco(cliente.EnderecoID);
                cli.ExcluirCliente(cliente.ClienteID);
                return true;
            } else {
                return false;
            }      
        }

        private void btnExcluirConta_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Deseja realmente exluir a conta?", "Excluir conta", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) {
                bool excluiu = ExcluirAConta();
                if(excluiu) {
                    MessageBoxResult res = MessageBox.Show("Conta excluída com sucesso!");
                    Close();
                } else {
                    MessageBoxResult res = MessageBox.Show("Conta não encontrada!");
                }
            }

        }
    }
}
