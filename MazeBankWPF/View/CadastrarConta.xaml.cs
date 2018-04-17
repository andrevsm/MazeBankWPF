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
        public Conta SalvarConta() {
            Conta conta = new Conta();
            conta.Agencia = int.Parse(txt_Agencia.Text);
            conta.Senha = txt_Senha.Text;

            ContaController cc = new ContaController();

            cc.SalvarConta(conta);
            Conta contaCad = cc.PesquisarPorId(conta.ContaID);
            return contaCad;
        }
        private void btnSalvar_Click(object sender, RoutedEventArgs e) {
            Conta contaCadastrada = SalvarConta();
            CadastrarEndereco cadEndereco = new CadastrarEndereco(contaCadastrada);
            cadEndereco.Show();
            Close();
        }



    }
}
