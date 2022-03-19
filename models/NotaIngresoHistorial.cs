using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class NotaIngresoHistorial : EntityValidator {

        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} debe ser mayor a cero")]
        public int Id { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        public string Serie { get; set; }
        
        [Required]
        public string Numero { get; set; }

        [Required]
        public DateTime FechaDocumento { get; set; }
        
        [Required]
        public Proveedor Proveedor { get; set; }

        public List<NotaIngresoDetalleHistorial> DetalleHistorial { get; set; }

        public int NumeroDeItems {
            get => this.DetalleHistorial.Count;
        }


        public NotaIngresoHistorial() {
            this.DetalleHistorial = new List<NotaIngresoDetalleHistorial>();
        }

        public void agregarDetalle(NotaIngresoDetalleHistorial detalleHistorial) {
            this.DetalleHistorial.Add(detalleHistorial);
        }

        public double Total {
            get => this.DetalleHistorial.Sum(detalle => detalle.Total);
        }

        public string numeroSiguienteItem() {
            if(this.DetalleHistorial.Count == 0) {
                return "1";
            }
            else {
                return (Convert.ToInt32(this.DetalleHistorial.Last().NumeroItem) + 1).ToString();
            }
        }

        public override string ToString() {
            return this.Id + " | " +this.FechaDocumento + " | " + this.Numero + " | " + this.NumeroDeItems;
        }
    }
}
