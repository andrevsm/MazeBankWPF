using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class EnderecoController {

        public void SalvarEndereco(Endereco endereco) {
            MyContext bancoDados = new MyContext();
            bancoDados.Enderecos.Add(endereco);
            bancoDados.SaveChanges();
        }

        public Endereco PesquisarPorId(int id) {
            MyContext bancoDados = new MyContext();
            return bancoDados.Enderecos.Find(id);
        }

        public void ExcluirEndereco(int id) {
            MyContext bancoDados = new MyContext();
            Endereco enderecoAtual = bancoDados.Enderecos.Find(id);

            bancoDados.Entry(enderecoAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();
        }

        public static List<Endereco> ListarTodosEnderecos() {
            MyContext bancoDados = new MyContext();
            return bancoDados.Enderecos.ToList();
        }
        public void EditarEndereco(Endereco novoEndereco) {
            MyContext bancoDados = new MyContext();
            Endereco enderecoAtual = bancoDados.Enderecos.Find(novoEndereco.EnderecoID);

            enderecoAtual.Cidade = novoEndereco.Cidade;
            enderecoAtual.Complemento = novoEndereco.Complemento;
            enderecoAtual.Rua = novoEndereco.Rua;
            enderecoAtual.Numero = novoEndereco.Numero;
            enderecoAtual.Estado = novoEndereco.Estado;

            bancoDados.Entry(enderecoAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();
        }
    }
}
