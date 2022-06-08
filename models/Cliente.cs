using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class Cliente {

        public int Id { get; set; }

        public string DniRuc { get; set; }

        private string _nombre;
        public string Nombre { get => this._nombre; 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El nombre ingresado es inválido");
                }
                this._nombre = value;
            }
        }

        public string Direccion { get; set; }


    }
}
