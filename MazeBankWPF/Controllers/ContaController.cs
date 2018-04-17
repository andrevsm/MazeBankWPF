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

        public static List<Conta> ListarTodasContas() {
            MyContext bancoDados = new MyContext();
            return bancoDados.Contas.ToList();
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
    }
}
