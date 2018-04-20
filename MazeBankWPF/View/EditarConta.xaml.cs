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
        private static Endereco endereco;

        public EditarConta(Conta minhaConta, Endereco meuEndereco)
        {
            conta = minhaConta;
            endereco = meuEndereco;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            endereco.Rua = (txt_Endereco.Text);
            conta.Senha = (txt_Senha.Text);
            endereco.Numero = int.Parse(txt_Numero.Text);
            endereco.Complemento = (txt_Complemento.Text);

            ContaController cc = new ContaController();
            cc.EditarConta(conta);
            MessageBoxResult edicao = MessageBox.Show("Edição dos dados realizada com sucesso!");
            Close();
        }
    }
}
