using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ContaController {


        public void SalvarConta(Conta conta) {
            MyContext bancoDados = new MyContext();
            bancoDados.Contas.Add(conta);
            bancoDados.SaveChanges();
        }

        public Conta PesquisarPorId(int id) {
            MyContext bancoDados = new MyContext();
            return bancoDados.Contas.Find(id);
        }

        public void ExcluirConta(int id) {
            MyContext bancoDados = new MyContext();
            Conta contaAtual = bancoDados.Contas.Find(id);

            bancoDados.Entry(contaAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();
        }

        public static void EditarConta(Conta novaConta) {
            MyContext bancoDados = new MyContext();
            ContaController cc = new ContaController();
            Conta contaAtual = cc.PesquisarPorId(novaConta.ContaID);
            contaAtual = novaConta;

            bancoDados.Entry(contaAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();
        }

        public Conta PesquisarConta(Conta contaVerificar) {
            MyContext bancoDados = new MyContext();
            var conta = from x in bancoDados.Contas
                    where x.ContaID == contaVerificar.ContaID && 
                    x.Agencia == contaVerificar.Agencia && 
                    x.Senha.Equals(contaVerificar.Senha)
                    select x;
            if(conta != null)
            {
                return conta.FirstOrDefault();
            } else
            {
                return null;
            }
        }

        public Conta Transferir(Conta contaTransferir, Double saldo) {
            Conta contaAtual = PesquisarPorId(contaTransferir.ContaID);

            if (contaAtual == null) {
                return null;
            } else {
                contaAtual.Saldo += saldo;
                EditarConta(contaAtual);
                return contaAtual;
            }
        }
    }
}
