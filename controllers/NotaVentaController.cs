using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    public class NotaVentaController {

        private List<Producto> stockProductos;
        public List<Producto> StockProductos { get => this.stockProductos; }

        private NotaVenta nuevaNotaVenta;
        public NotaVenta NuevaNotaVenta { get => this.nuevaNotaVenta; }

        public NotaVentaController() {
            this.actualizarStockProductosFromDB();
            this.nuevaNotaVenta = new NotaVenta();
        }

        public List<Producto> getProductosPorDescripcion(string descripcion) {
            return this.stockProductos.FindAll(producto => producto.Descripcion.IndexOf(descripcion, StringComparison.CurrentCultureIgnoreCase) >= 0);
        }

        public bool agregarItemNuevaVenta(int idProducto, double cantidad) {
            Producto producto = this.stockProductos.Find(p => p.Id == idProducto);
            NotaVentaDetalle notaVentaDetalle = new NotaVentaDetalle(producto, cantidad, producto.PrecioVenta);
            bool ok = this.nuevaNotaVenta.agregarItem(notaVentaDetalle);
            return ok;
        }

        public void agregarClienteNotaVenta(Cliente cliente) {
            this.NuevaNotaVenta.Cliente = cliente;
        }

        public void quitarItemNuevaVenta(int idProducto) {
            this.nuevaNotaVenta.quitarItem(idProducto);
        }

        public int getNuevoIdNotaVenta() {
            return (int)MySqlCommandHelper.executeEscalar("fnGetIdNuevaNotaVenta");
        }

        public void grabarNuevaNotaVentaEnBD() {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@id", this.NuevaNotaVenta.Id),
                new MySqlParameter("@tipo", this.NuevaNotaVenta.NumeracionComprobante.TipoDocumento.Substring(0,1)),
                new MySqlParameter("@serie", this.NuevaNotaVenta.NumeracionComprobante.Serie),
                new MySqlParameter("@numero", this.NuevaNotaVenta.NumeracionComprobante.Numero),
                new MySqlParameter("@fecha", this.NuevaNotaVenta.Fecha.ToString("yyyy/MM/dd")),
                new MySqlParameter("@idCliente", this.NuevaNotaVenta.Cliente.Id)
            };
            MySqlCommandHelper.executeNonQuery("spGrabarNotaVenta", parameters);
            this.grabarDetalleNuevaNotaVentaEnDB();
            this.nuevaNotaVenta = new NotaVenta();
        }

        private void grabarDetalleNuevaNotaVentaEnDB() {
            foreach(NotaVentaDetalle nvd in this.NuevaNotaVenta.NotaVentaDetalle) {
                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@idNotaVenta", this.nuevaNotaVenta.Id),
                    new MySqlParameter("@numeroItem", nvd.NumeroItem),
                    new MySqlParameter("@idProducto", nvd.Producto.Id),
                    new MySqlParameter("@descripcionProducto", nvd.Producto.Descripcion),
                    new MySqlParameter("@unidadMedida", nvd.Producto.UnidadMedida),
                    new MySqlParameter("@cantidad", nvd.Cantidad),
                    new MySqlParameter("@precioUnitario", nvd.PrecioUnitario)
                };
                MySqlCommandHelper.executeNonQuery("spGrabarDetalleNotaVenta", parameters);
            }
        }

        public void actualizarStockProductosFromDB() {
            this.stockProductos = new ProductosController().getStockProductos("");
        }
    }
}
