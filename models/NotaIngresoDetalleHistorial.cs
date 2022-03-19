using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class NotaIngresoDetalleHistorial {
        public string NumeroItem { get; set; }
        public int IdProducto { get; set; }
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string DescripcionProducto { get; set; }
        public double CostoUnitario { get; set; }
        public double CantidadDisponible { get; set; }

        public NotaIngresoDetalleHistorial(string numeroItem, int idProducto, double cantidad, string unidadMedida, string descripcionProducto, double costoUnitario, double cantidadDisponible) {
            NumeroItem = numeroItem;
            IdProducto = idProducto;
            Cantidad = cantidad;
            UnidadMedida = unidadMedida;
            DescripcionProducto = descripcionProducto;
            CostoUnitario = costoUnitario;
            CantidadDisponible = cantidadDisponible;
        }

        public double Total {
            get => Cantidad * CostoUnitario;
        }
    }
}
