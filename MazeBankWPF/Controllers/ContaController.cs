using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ContaController {

        static List<Conta> Contas = new List<Conta>();
        static int ultimoId = 0;

        public void SalvarConta(Conta conta) {
            conta.ContaId = ultimoId + 1;
            Contas.Add(conta);
            ultimoId = conta.ContaId;
        }

        public Conta PesquisarPorId(int id) {
            var c = from x in Contas
                    where x.ContaId == id
                    select x;

            if (c != null) {
                return c.FirstOrDefault();
            }
            else {
                return null;
            }

        }

        public void ExcluirConta(Conta c) {
            Contas.Remove(c);
        }

        public List<Conta> ListarContas() {
            return Contas;
        }

        public bool AlterarConta(Conta conta, Conta alterada) {
            conta = alterada;
            return true;
        }
    }
}
