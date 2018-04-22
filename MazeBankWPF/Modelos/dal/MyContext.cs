using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL { 
    public class MyContext : DbContext {
        public MyContext() : base("strConn") {
                   
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<ContasPagas> ContasPagas { get; set; }
    }
}
