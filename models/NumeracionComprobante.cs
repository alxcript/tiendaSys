using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class NumeracionComprobante {

        public string TipoDocumento { get; set; }

        public string Serie { get; set; }

        public string Numero { get; set; }

        public NumeracionComprobante(string tipoDocumento, string serie, string numero) {
            this.TipoDocumento = tipoDocumento;
            this.Serie = serie;
            this.Numero = numero;
        }
    }
}
