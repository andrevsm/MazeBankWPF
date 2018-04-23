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
    /// Interaction logic for Depositos.xaml
    /// </summary>
    public partial class EditarConta : Window
    {
        private static Conta conta;

        public EditarConta(Conta minhaConta)
        {
            conta = minhaConta;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            EnderecoController ec = new EnderecoController();
            ClienteController cc = new ClienteController();
            ContaController contaC = new ContaController();
            Cliente cliente = cc.PesquisarClientePorContaID(conta.ContaID);

            Endereco endereco = ec.PesquisarPorId(cliente.EnderecoID);
            endereco.Rua = (txt_Endereco.Text);
            endereco.Numero = int.Parse(txt_Numero.Text);
            endereco.Complemento = (txt_Complemento.Text);
            endereco.Cidade = (txt_Cidade.Text);
            endereco.Estado = (txt_Estado.Text);

            conta.Senha = (txt_Senha.Text);
            contaC.EditarConta(conta);
            ec.EditarEndereco(endereco);

            MessageBoxResult edicao = MessageBox.Show("Edição dos dados realizada com sucesso!");
            Close();
        }
    }
}
