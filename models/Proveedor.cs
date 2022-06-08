using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaSystem.models {
    public class Proveedor {

        private int id;
        public int Id {
            get => this.id;
        }
        private String ruc;
        private String razonSocial;
        private String direccion;


        public Proveedor()
        {

        }

        public Proveedor(int id, string ruc, string razonSocial, string direccion) {
            this.id = id;
            this.Ruc = ruc;
            this.RazonSocial = razonSocial;
            this.direccion = direccion;
        }

        public string Ruc
        {
            get => ruc;
            set
            {
                if(value.Length != 11)
                {
                    throw new ArgumentOutOfRangeException("El ruc debe tener 11 caracteres");
                }
                this.ruc = value;
            }
        }
        public string RazonSocial { get => razonSocial;
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("La Razon Social no puede ser vacía");
                }
                this.razonSocial = value;
            }
        }
    }
}
