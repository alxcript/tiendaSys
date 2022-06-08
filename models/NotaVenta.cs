using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace tiendaSystem.models {
    public class NotaVenta : EntityValidator {

        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a cero")]
        public int Id { get; set; }
        
        [Required]
        public NumeracionComprobante NumeracionComprobante { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        public Cliente Cliente { get; set; }

        public List<NotaVentaDetalle> NotaVentaDetalle { get; set; }

        public double Total { get => this.NotaVentaDetalle.Sum(detalle => detalle.Total); }

        public NotaVenta() {
            this.NotaVentaDetalle = new List<NotaVentaDetalle>();
        }

        public bool agregarItem(NotaVentaDetalle notaVentaDetalle) {
            bool ok = true;
            NotaVentaDetalle nvd = this.NotaVentaDetalle.Find(detalle => detalle.Producto.Id == notaVentaDetalle.Producto.Id);
            if(nvd != null) {
                if(nvd.Cantidad + notaVentaDetalle.Cantidad <= nvd.Producto.Stock) {
                    nvd.Cantidad += notaVentaDetalle.Cantidad;
                }
                else {
                    ok = false;
                }
            }
            else {
                if(notaVentaDetalle.Cantidad <= notaVentaDetalle.Producto.Stock) {
                    this.NotaVentaDetalle.Add(notaVentaDetalle);
                }
                else {
                    ok = false;
                }
            }
            return ok;
        }

        public void quitarItem(int idProducto) {
            NotaVentaDetalle nvd = this.NotaVentaDetalle.Find(detalle => detalle.Producto.Id == idProducto);
            this.NotaVentaDetalle.Remove(nvd);
        }

        public bool existsOnList(int id)
        {
            return this.NotaVentaDetalle.Find((detalle) => detalle.Producto.Id == id) != null;
        }

        public void cambiarPrecioVentaUnitario(int idProducto, double precioVenta) {
            NotaVentaDetalle nvd = this.NotaVentaDetalle.Find(detalle => detalle.Producto.Id == idProducto);
            nvd.PrecioUnitario = precioVenta;
        }

        public void cambiarPrecioVentaTotal(int idProducto, double total) {
            NotaVentaDetalle nvd = this.NotaVentaDetalle.Find(detalle => detalle.Producto.Id == idProducto);
            nvd.Total = total;
        }

        internal void setNumeroItems() {
            int i = 1;
            foreach(NotaVentaDetalle nvd in this.NotaVentaDetalle) {
                nvd.NumeroItem = i.ToString();
                i++;
            }
        }
    }
}
