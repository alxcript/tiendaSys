using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace tiendaSystem.models {
    public class Producto : EntityValidator, ICloneable {

        //[Required]
        public int Id { get; set; }
        
        //[Required, MaxLength(150)]
        public string Descripcion { get; set; }

        private string marca;
        //[Required]
        public string Marca { 
            get => this.marca;
            set => this.marca = value.ToUpper(); }

        //[Required]
        public double CostoCompra { get; set; }

        //[Range(typeof(double), "0", "99999", ErrorMessage = "El valor para {0} debe estar entre {1} and {2}")]
        public double PrecioVenta { get; set; }
        
        //[Required]
        public string UnidadMedida { get; set; }

        //[Required]
        public double PrecioVentaMinimo { get; set; }
        
        //[Required]
        public string Categoria { get; set; }

        public double Stock { get; set; }

        public Producto() {

        }

        public Producto(int id) {
            this.Id = id;
        }

        public Producto(int id, string descripcion, string marca, double costoCompra, double precioVenta, string unidadMedida, string categoria, double precioVentaMinimo) {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.CostoCompra = costoCompra;
            this.PrecioVenta = precioVenta;
            this.UnidadMedida = unidadMedida;
            this.Categoria = categoria;
            this.PrecioVentaMinimo = precioVentaMinimo;
        }

        public object Clone() {
            return this.MemberwiseClone();

        }
    }
}
