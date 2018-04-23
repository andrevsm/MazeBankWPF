using Models;
using Controller;
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
    /// Interaction logic for CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        private static Conta contaCadastrada;
        private static Endereco enderecoCadastrado;

        public CadastrarCliente(Conta contaCad, Endereco enderecoCad)
        {
            contaCadastrada = contaCad;
            enderecoCadastrado = enderecoCad;
            InitializeComponent();
        }   
        private void SalvarCliente()
        {
            Cliente cli = new Cliente();
            cli.Nome = txt_NomeCliente.Text;
            cli.Cpf = txt_CPF.Text;
            cli.Nascimento = txt_DataNascimento.Text;

            ClienteController.SalvarCliente(cli, contaCadastrada, enderecoCadastrado);
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            SalvarCliente();
            MessageBoxResult result = MessageBox.Show("Cadastro realizado com sucesso!" + "\nNúmero da Conta: " + contaCadastrada.ContaID + "\nAgência: " + contaCadastrada.Agencia + "\nSenha: " + contaCadastrada.Senha, "MazeBank!");
            Close();
        }
    }
}
