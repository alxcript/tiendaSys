using MySql.Data.MySqlClient;
using System.Collections.Generic;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    public class NotaIngresoController {

        private List<NotaIngresoHistorial> notaIngresoMensual;

        private NotaIngresoHistorial notaIngresoActual;

        public NotaIngresoHistorial NotaIngresoActual {
            get => this.notaIngresoActual;
            set => this.notaIngresoActual = value;
        }

        public void crearNuevoNotaIngreso() {
            this.notaIngresoActual = new NotaIngresoHistorial();
            this.notaIngresoActual.Id = this.getIdNuevaNotaIngreso();
        }

        public List<NotaIngresoHistorial> NotaIngresoMensual {
            get => this.notaIngresoMensual;
        }

        public NotaIngresoController() {
            this.notaIngresoMensual = new List<NotaIngresoHistorial>();
            this.crearNuevoNotaIngreso();
        }

        public int getIdNuevaNotaIngreso() {
            return (int)MySqlCommandHelper.executeEscalar("fnGetIdNuevaNotaIngreso");
        }

        public void grabarCabeceraNotaIngreso() {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@tipoDocumento", notaIngresoActual.TipoDocumento),
                new MySqlParameter("@serie", notaIngresoActual.Serie),
                new MySqlParameter("@numero", notaIngresoActual.Numero),
                new MySqlParameter("@fechaDocumento", notaIngresoActual.FechaDocumento.ToString("yyyy/MM/dd")),
                new MySqlParameter("@idProveedor", notaIngresoActual.Proveedor.Id)
            };
            MySqlCommandHelper.executeNonQuery("spInsertarNotaIngreso", parameters);
        }

        public void grabarDetalle(NotaIngresoDetalleHistorial notaIngresoDetalle) {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@idNotaIngreso", this.notaIngresoActual.Id),
                new MySqlParameter("@numeroItem", notaIngresoDetalle.NumeroItem),
                new MySqlParameter("@idProducto", notaIngresoDetalle.IdProducto),
                new MySqlParameter("@cantidad", notaIngresoDetalle.Cantidad),
                new MySqlParameter("@unidadItem", notaIngresoDetalle.UnidadMedida),
                new MySqlParameter("@descripcionProducto", notaIngresoDetalle.DescripcionProducto),
                new MySqlParameter("@costoUnitario", notaIngresoDetalle.CostoUnitario)
            };
            MySqlCommandHelper.executeNonQuery("spInsertarNotaIngresoDetalle", parameters);
        }

        public List<NotaIngresoDetalleHistorial> getDetallePorId(int id) {
            return this.notaIngresoMensual.Find(notaIngreso => notaIngreso.Id == id).DetalleHistorial;
        }

        public NotaIngresoHistorial getNotaIngresHistorialPorId(int id) {
            return this.notaIngresoMensual.Find(notaIngreso => notaIngreso.Id == id);
        }


        public List<NotaIngresoHistorial> getNotaIngresoDetalleHistorialPorMes(string fecha) {
            this.notaIngresoMensual.Clear();
            using (MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetNotasIngresoCabeceraPorMes", new MySqlParameter("@fecha", fecha))) {
                while (reader.Read()) {
                    NotaIngresoHistorial notaIngresoHistorial = new NotaIngresoHistorial();
                    notaIngresoHistorial.Id = reader.GetInt32("id");
                    notaIngresoHistorial.FechaDocumento = reader.GetDateTime("fechaDocumento");
                    notaIngresoHistorial.TipoDocumento = reader.GetString("tipoDocumento");
                    notaIngresoHistorial.Serie = reader.GetString("serie");
                    notaIngresoHistorial.Numero = reader.GetString("numero");
                    int idProveedor = reader.GetInt32("idProveedor");
                    notaIngresoHistorial.Proveedor = new ProveedorController().getProveedoresPorId(idProveedor);
                    this.setDetalleHistorialFromDB(notaIngresoHistorial);
                    this.notaIngresoMensual.Add(notaIngresoHistorial);
                }
            }
            return this.notaIngresoMensual;
        }

        private void setDetalleHistorialFromDB(NotaIngresoHistorial notaIngresoHistorial) {
            using (MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetNotasIngresoDetallePorId", new MySqlParameter("@id", notaIngresoHistorial.Id))) {
                while (reader.Read()) {
                    string numeroItem = reader.GetString("numeroItem");
                    int idProducto = reader.GetInt32("idProducto");
                    double cantidad = reader.GetDouble("cantidad");
                    string unidadMedida = reader.GetString("unidadItem");
                    string descripcion = reader.GetString("descripcionProducto");
                    double costoUnitario = reader.GetDouble("costoUnitario");
                    double cantidadDisponible = reader.GetDouble("cantidadDisponible");
                    notaIngresoHistorial.agregarDetalle(new NotaIngresoDetalleHistorial(numeroItem, idProducto, cantidad, unidadMedida, descripcion, costoUnitario, cantidadDisponible));
                }
            }
        }

        public void eliminarDetalleNotaIngreso(int idNotaIngreso, string numeroItem) {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@idNotaIngreso", idNotaIngreso),
                new MySqlParameter("@numeroItem", numeroItem)
            };
            MySqlCommandHelper.executeNonQuery("spEliminarItemDetalleNotaIngreso", parameters);
        }
    }
}
