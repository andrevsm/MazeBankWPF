using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public Cliente() {
            _Endereco = new Endereco();
            _Conta = new Conta();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Cpf { get; set; }
        public int ContaId { get; set; }
        public Conta _Conta { get; set; }
        public int EnderecoId { get; set; }
        public Endereco _Endereco { get; set; }
    }

}
