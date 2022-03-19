using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiendaSystem.models;

namespace tiendaSystem.views {
    public partial class NuevoProductoForm : Form {

        private BindingList<Producto> productos;
        private Producto productoNuevo;

        public NuevoProductoForm(BindingList<Producto> productos) {
            InitializeComponent();
            this.productos = productos;
            this.productoNuevo = this.informacionProductoPanel.nuevoProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            bool ok = this.informacionProductoPanel.grabarProducto();
            if (ok) {
                this.productos.Add(this.productoNuevo);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
