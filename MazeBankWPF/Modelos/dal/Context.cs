using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL { 
    public class Context : DbContext {
        public Context() : base("strConn") {
                   
        }

        public DbSet<Cliente> tblClientes { get; set; }
        public DbSet<Conta> tblContas { get; set; }
        public DbSet<Endereco> tblEndereco { get; set; }
    }
}
