using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContasPagas
    {
        public int ContasPagasID { get; set; }
        public int Boleto { get; set; }
        public double Valor { get; set; }
        public int ContaID { get; set; }
        public Conta _Conta { get; set; }
    }

}
