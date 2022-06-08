using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.controllers {
    class Conexion {

        private readonly string cadenaConexion = "Server=localhost;Port=3306;Database=bdtienda3;Uid=userDesarrollador;Pwd=alex123;";
        private static Conexion cnx = null;

        private Conexion() {
            
        }

        public MySqlConnection getConnection() {
            MySqlConnection connection = null;
            try {
                connection = new MySqlConnection(this.cadenaConexion);
            }
            catch (MySqlException ex) {
                Console.WriteLine(ex);
            }
            return connection;
        }

        public static Conexion getInstance() {
            if (cnx == null) {
                cnx = new Conexion();
            }
            return cnx;
        }
    
    }
}
