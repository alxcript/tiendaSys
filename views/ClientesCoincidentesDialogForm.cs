using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tiendaSystem.controllers;
using tiendaSystem.models;

namespace tiendaSystem.views {
    public partial class ClientesCoincidentesDialogForm : Form {

        private NotaVentaController notaVentaController;

        private List<Cliente> clientesCoincidentes;

        public ClientesCoincidentesDialogForm(NotaVentaController notaVentaController, List<Cliente> clientesCoincidentes) {
            InitializeComponent();
            this.notaVentaController = notaVentaController;
            this.clientesCoincidentes = clientesCoincidentes;
            foreach(Cliente cliente in this.clientesCoincidentes) {
                this.dgvClientes.Rows.Add(cliente.Id, cliente.DniRuc, cliente.Nombre);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            int idCliente = (int)this.dgvClientes.CurrentRow.Cells["idClienteCol"].Value;
            Cliente cliente = this.clientesCoincidentes.Find(c => c.Id == idCliente);
            this.notaVentaController.agregarClienteNotaVenta(cliente);
            this.Close();
        }
    }
}
