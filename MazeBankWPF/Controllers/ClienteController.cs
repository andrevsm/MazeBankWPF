using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller {
    public class ClienteController {

        static List<Cliente> Clientes = new List<Cliente>();
        static int ultimoId = 0;

        public void SalvarCliente(Cliente cliente) {
            cliente.ClienteId = ultimoId + 1;
            Clientes.Add(cliente);
            ultimoId = cliente.ClienteId;
        }

        public Cliente PesquisarPorId(int id) {
            var c = from x in Clientes
                    where x.ClienteId == id
                    select x;

            if (c != null) {
                return c.FirstOrDefault();
            }
            else {
                return null;
            }

        }

        public void ExcluirCliente(Cliente c) {
            Clientes.Remove(c);
        }

        public List<Cliente> ListarClientes() {
            return Clientes;
        }

        public bool AlterarCliente(Cliente cliente, Cliente alterado) {
            cliente = alterado;
            return true;
        }
    }
}
