using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public int ContaId { get; set; }
        public int EnderecoId { get; set; }
    }

}
