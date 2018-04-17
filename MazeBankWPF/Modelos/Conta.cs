using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Conta
    {
        public int ContaID { get; set; }
        public int Agencia { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }
    }

}
