using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class EnderecoController {

        static List<Endereco> Enderecos = new List<Endereco>();
        static int ultimoId = 0;

        public void SalvarEndereco(Endereco endereco) {
            endereco.EnderecoId = ultimoId + 1;
            Enderecos.Add(endereco);
            ultimoId = endereco.EnderecoId;
        }

        public Endereco PesquisarPorId(int id) {
            var c = from x in Enderecos
                    where x.EnderecoId == id
                    select x;

            if (c != null) {
                return c.FirstOrDefault();
            }
            else {
                return null;
            }

        }

        public void ExcluirEndereco(Endereco e) {
            Enderecos.Remove(e);
        }

        public List<Endereco> ListarEnderecos() {
            return Enderecos;
        }

        public bool AlterarEndereco(Endereco endereco, Endereco alterado) {
            endereco = alterado;
            return true;
        }
    }
}