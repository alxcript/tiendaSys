using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystem.controllers {
    class ProductosController {
        
        public List<Producto> getProductosPorDescripcion(string descripcionBuscada) {
            List<Producto> productosEncontrados = new List<Producto>();
            using(MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetProductosPorDescripcion", new MySqlParameter("@descripcion", descripcionBuscada))) {
                while(reader.Read()) {
                    int id = reader.GetInt32("id");
                    string descripcion = reader.GetString("description");
                    string marca = reader.GetString("brand");
                    double costoCompra = reader.GetDouble("purchaseCost");
                    double precioVenta = reader.GetDouble("salePrice");
                    string unidadMedida = reader.GetString("unitOfMeasurement");
                    string categoria = reader.GetString("category");
                    double precioVentaMinimo = reader.GetDouble("minimumSalePrice");
                    productosEncontrados.Add(new Producto(id, descripcion, marca, costoCompra, precioVenta, unidadMedida, categoria, precioVentaMinimo));
                }
            }
            return productosEncontrados;
        }

        public List<Producto> getStockProductos(string descripcion) {
            List<Producto> stockProductos = new List<Producto>();
            try {
                using (MySqlDataReader reader = MySqlCommandHelper.executeReader("spGetStockProductosPorDescripcion", new MySqlParameter("@descripcion", descripcion))) {
                    while (reader.Read()) {
                        Producto producto = new Producto();
                        producto.Id = reader.GetInt32("id");
                        producto.Descripcion = reader.GetString("description");
                        producto.Marca = reader.GetString("brand");
                        producto.CostoCompra = reader.GetDouble("purchaseCost");
                        producto.PrecioVenta = reader.GetDouble("salePrice");
                        producto.UnidadMedida = reader.GetString("unitOfMeasurement");
                        producto.Categoria = reader.GetString("category");
                        producto.PrecioVentaMinimo = reader.GetDouble("minimumSalePrice");
                        producto.Stock = reader.GetDouble("stock");
                        stockProductos.Add(producto);
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            return stockProductos;
        }

        public int getIdProductoNuevo() {
            return (int)MySqlCommandHelper.executeEscalar("fnGetIdNuevoProducto");
        }

        public void grabarProductoEnBD(Producto producto) {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@descripcion", producto.Descripcion),
                new MySqlParameter("@marca", producto.Marca),
                new MySqlParameter("@costoCompra", producto.CostoCompra),
                new MySqlParameter("@precioVenta", producto.PrecioVenta),
                new MySqlParameter("@unidadMedida", producto.UnidadMedida),
                new MySqlParameter("@categoria", producto.Categoria),
                new MySqlParameter("@precioVentaMinimo", producto.PrecioVentaMinimo)
            };
            MySqlCommandHelper.executeNonQuery("spInsertarProducto", parameters);
        }

        public void actualizarProductoEnBD(Producto producto) {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@id", producto.Id),
                new MySqlParameter("@descripcion", producto.Descripcion),
                new MySqlParameter("@marca", producto.Marca),
                new MySqlParameter("@costoCompra", producto.CostoCompra),
                new MySqlParameter("@precioVenta", producto.PrecioVenta),
                new MySqlParameter("@unidadMedida", producto.UnidadMedida),
                new MySqlParameter("@categoria", producto.Categoria),
                new MySqlParameter("@precioVentaMinimo", producto.PrecioVentaMinimo)
            };
            MySqlCommandHelper.executeNonQuery("spActualizarProducto", parameters);
        }
    }
}
