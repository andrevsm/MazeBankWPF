using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public string Cpf { get; set; }
        public int ContaID { get; set; }
        public Conta _Conta { get; set; }
        public int EnderecoID { get; set; }
        public Endereco _Endereco { get; set; }
    }

}
