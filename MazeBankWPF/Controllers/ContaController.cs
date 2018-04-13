using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ContaController {

        static List<Conta> Contas = new List<Conta>();
        static int ultimoId = 0;

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

        public List<Conta> ListarContas() {
            return Contas;
        }

        public static List<Conta> ListarTodasContas() {
            MyContext bancoDados = new MyContext();
            return bancoDados.Contas.ToList();
        }

        public Conta VerificarLogin(Conta conta) {
            Conta contaVerificar = PesquisarPorId(conta.ContaId);
            if (contaVerificar == null || contaVerificar.Agencia != conta.Agencia || contaVerificar.Senha.Equals(conta.Senha)) {
                return null;
            } else {
                return contaVerificar;
            }
       }
    }
}
