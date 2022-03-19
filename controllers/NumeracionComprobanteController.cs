using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    public class NumeracionComprobanteController {

        public NumeracionComprobante getNumeracionSegunTipoDocumento(string tipoDocumento) {
            using(MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetNumeracionSegunTipoDocumento", new MySqlParameter("@tipoDocumento", tipoDocumento))) {
                reader.Read();
                return new NumeracionComprobante(reader.GetString("tipoDocumento"), reader.GetString("serie"), reader.GetString("numero"));
            }
        }
    }
}
