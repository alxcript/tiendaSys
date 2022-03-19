using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class NotaVentaDetalle {

        public string NumeroItem { get; set; }

        public Producto Producto { get; set; }

        public double Cantidad { get; set; }

        private double precioUnitario;
        public double PrecioUnitario { get => this.precioUnitario; set => this.precioUnitario = Math.Round(value, 4); }

        //private double total;
        public double Total { get => this.Cantidad * this.PrecioUnitario;
            set {
                this.PrecioUnitario = value / this.Cantidad;
            }
        }

        public NotaVentaDetalle(Producto producto, double cantidad, double precioUnitario) {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
    }
}
