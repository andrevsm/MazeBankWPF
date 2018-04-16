using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ContaController {

        public static void SalvarConta(Conta conta) {
            MyContext bancoDados = new MyContext();
            bancoDados.Contas.Add(conta);
            bancoDados.SaveChanges();
        }

        public static Conta PesquisarPorId(int id) {
            MyContext bancoDados = new MyContext();
            return bancoDados.Contas.Find(id);
        }

        public void ExcluirConta(int id) {
            MyContext bancoDados = new MyContext();
            Conta contaAtual = bancoDados.Contas.Find(id);

            bancoDados.Entry(contaAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();
        }

        public static List<Conta> ListarTodasContas() {
            MyContext bancoDados = new MyContext();
            return bancoDados.Contas.ToList();
        }

        public static Conta PesquisarConta(Conta contaVerificar) {
            MyContext bancoDados = new MyContext();
            Conta contaAtual = bancoDados.Contas.Find(contaVerificar);
            if(contaAtual != null) {
                return contaAtual;
            } else {
                return null;
            }
        }

        public Conta VerificarLogin(Conta conta) {
            Conta contaVerificada = PesquisarConta(conta);
            if (contaVerificada != null) {
                return contaVerificada; 
            } else {
                return null;
            }
       }
    }
}
