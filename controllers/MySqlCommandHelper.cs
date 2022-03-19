using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace tiendaSystem.controllers {
    class MySqlCommandHelper {

        public static int executeNonQuery(string nameStoreProcedure, params MySqlParameter[] parameters) {
            using (MySqlConnection connection = Conexion.getInstance().getConnection()) {
                using (MySqlCommand command = new MySqlCommand(nameStoreProcedure, connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static MySqlDataReader executeReader(string nameStoreProcedure, params MySqlParameter[] parameters) {
            MySqlConnection connection = Conexion.getInstance().getConnection();
            using (MySqlCommand command = new MySqlCommand(nameStoreProcedure, connection)) {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static object executeEscalar(string nameFunction) {
            using (MySqlConnection connection = Conexion.getInstance().getConnection()) {
                using (MySqlCommand command = new MySqlCommand("select " + nameFunction + "()", connection)) {
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}
