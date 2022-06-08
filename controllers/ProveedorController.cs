using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    public class ProveedorController {

        public DataTable getProveedoresPorRuc(string rucBuscado) {
            DataTable proveedoresCoincidentes = new DataTable();
            using (MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetProveedorPorRuc", new MySqlParameter("@ruc", rucBuscado))) {
                proveedoresCoincidentes.Load(reader);
            }
            return proveedoresCoincidentes;
        }

        public Proveedor getProveedoresPorId(int idProveedor) {
            Proveedor proveedor = null;
            using(MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetProveedorPorId", new MySqlParameter("@id", idProveedor))) {
                reader.Read();
                int id = reader.GetInt32("id");
                string ruc = reader.GetString("ruc");
                string razonSocial = reader.GetString("businessName");
                string direccion = reader.GetString("fiscalAddress");
                proveedor = new Proveedor(id, ruc, razonSocial, direccion);
            }
            return proveedor;
        }
    }
}
