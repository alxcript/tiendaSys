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
    public partial class ProveedoresCoincidentesDialogForm : Form {

        private NotaIngresoHistorial notaIngresoActual;

        public ProveedoresCoincidentesDialogForm(DataTable proveedoresCoincidentes, NotaIngresoHistorial notaIngresoActual) {
            InitializeComponent();
            this.dgvProveedores.DataSource = proveedoresCoincidentes;
            this.notaIngresoActual = notaIngresoActual;
            this.btnSeleccionar.DialogResult = DialogResult.OK;
        }

        

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            int id = (int)this.dgvProveedores.CurrentRow.Cells["id"].Value;
            string ruc = this.dgvProveedores.CurrentRow.Cells["ruc"].Value.ToString();
            string razonSocial = this.dgvProveedores.CurrentRow.Cells["businessName"].Value.ToString();
            string direccion = this.dgvProveedores.CurrentRow.Cells["fiscalAddress"].Value.ToString();
            this.notaIngresoActual.Proveedor = new Proveedor(id, ruc, razonSocial, direccion);
            this.Close();
        }
    }
}
