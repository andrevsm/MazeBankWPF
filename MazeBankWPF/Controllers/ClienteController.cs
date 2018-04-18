using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ClienteController {

        public static void SalvarCliente(Cliente cliente, Conta contaCadastrada, Endereco enderecoCadastrado) {
            cliente.ContaID = contaCadastrada.ContaID;
            cliente.EnderecoID = enderecoCadastrado.EnderecoID;
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

        public static List<Cliente> ListarTodosClientes() {
            MyContext bancoDados = new MyContext();
            return bancoDados.Clientes.ToList();
        }

        public static void EditarCliente(int id, Cliente novoCliente) {
            MyContext bancoDados = new MyContext();
            Cliente clienteAtual = bancoDados.Clientes.Find(id);

            clienteAtual = novoCliente;

            bancoDados.Entry(clienteAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();
        }
        public Cliente PesquisarClientePorContaID(int idConta)
        {
            MyContext bancoDados = new MyContext();
            var cliente = from x in bancoDados.Clientes
                        where x.ContaID == idConta 
                        select x;
            if (cliente != null)
            {
                return cliente.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }
    }

}
