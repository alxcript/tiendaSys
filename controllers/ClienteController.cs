using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    public class ClienteController {

        private List<Cliente> clientes;

        public ClienteController() {
            this.clientes = new List<Cliente>();
            this.loadClientesFromDB("");
        }

        public List<Cliente> getClientePorRucDni(string rucDni) {
            return this.clientes.FindAll(cliente => cliente.DniRuc.StartsWith(rucDni));
        }

        private void loadClientesFromDB(string rucDni) {
            using(MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetClientePorRucDni", new MySqlParameter("@rucDni", rucDni))) {
                while (reader.Read()) {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32("id");
                    cliente.DniRuc = reader.GetString("rucDni");
                    cliente.Nombre = reader.GetString("nombre");
                    cliente.Direccion = reader.GetString("direccion");
                    this.clientes.Add(cliente);
                }
            }
        }
    }
}
