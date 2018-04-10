using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ClienteController {

        static List<Cliente> Clientes = new List<Cliente>();
        static int ultimoId = 0;

        public static void SalvarCliente(Cliente cliente) {
            MyContext bancoDados = new MyContext();
            bancoDados.Clientes.Add(cliente);
            bancoDados.SaveChanges();
        }

        public static Cliente PesquisarPorId(int id) {
            MyContext bancoDados = new MyContext();
            return bancoDados.Clientes.Find(id);
        

        }

        public void ExcluirCliente(int id) {
            MyContext bancoDados = new MyContext();
            Cliente clienteAtual = bancoDados.Clientes.Find(id);

         

            bancoDados.Entry(clienteAtual).State = System.Data.Entity.EntityState.Deleted;

            bancoDados.SaveChanges();
        }

        public List<Cliente> ListarClientes() {
            return Clientes;
        }

        public static List<Cliente> ListarTodosClientes()
        {
            MyContext bancoDados = new MyContext();
            return bancoDados.Clientes.ToList();
        }
        public static void EditarCliente(int id, Cliente novoCliente)
        {   
            MyContext bancoDados = new MyContext();
            Cliente clienteAtual = bancoDados.Clientes.Find(id);

            clienteAtual.Nome = novoCliente.Nome;
            clienteAtual.Cpf = clienteAtual.Cpf;
            clienteAtual.Nascimento = clienteAtual.Nascimento;

            bancoDados.Entry(clienteAtual).State = System.Data.Entity.EntityState.Modified;

            bancoDados.SaveChanges();
        }
    }
}
