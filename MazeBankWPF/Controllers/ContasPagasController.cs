using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ContasPagasController {

        public void SalvarContaPaga(ContasPagas contaPaga) {
            MyContext bancoDados = new MyContext();
            bancoDados.ContasPagas.Add(contaPaga);
            bancoDados.SaveChanges();
        }

        
        public ContasPagas PesquisarContasPagasPorContaID(int idConta) {
            MyContext bancoDados = new MyContext();
            var contaPaga = from x in bancoDados.ContasPagas
                          where x.ContaID == idConta
                          select x;
            if (contaPaga != null) {
                return contaPaga.FirstOrDefault();
            }
            else {
                return null;
            }
        }

    } 
}
