using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiendaSystem.controllers;
using tiendaSystem.models;

namespace tiendaSystem.views {
    public partial class ComprobanteVentaAbstractoPanel : UserControl {

        public NotaVentaController NotaVentaController { get; set; }

        private ClienteController clienteController;

        public ComprobanteVentaAbstractoPanel() {
            InitializeComponent();
        }

        private void txtRucDni_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                this.seleccionarCliente();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            this.seleccionarCliente();
        }

        private void seleccionarCliente() {
            List<Cliente> clientesCoincidentes = this.clienteController.getClientePorRucDni(this.txtRucDni.Text);
            if(clientesCoincidentes.Count == 0) {
                this.mensajeWarning("No existe un cliente con ese Dni o Ruc..", "Seleccionar Cliente");
            }
            else if(clientesCoincidentes.Count == 1) {
                this.NotaVentaController.agregarClienteNotaVenta(clientesCoincidentes[0]);
                this.txtRucDni.Text = clientesCoincidentes[0].DniRuc;
                this.txtNombre.Text = clientesCoincidentes[0].Nombre;
                this.txtDireccion.Text = clientesCoincidentes[0].Direccion;
            }
            else {
                ClientesCoincidentesDialogForm clientesCoincidentesDialogForm = new ClientesCoincidentesDialogForm(this.NotaVentaController, clientesCoincidentes);
                DialogResult result = clientesCoincidentesDialogForm.ShowDialog();
                if(result == DialogResult.OK) {
                    this.txtRucDni.Text = this.NotaVentaController.NuevaNotaVenta.Cliente.DniRuc;
                    this.txtNombre.Text = this.NotaVentaController.NuevaNotaVenta.Cliente.Nombre;
                    this.txtDireccion.Text = this.NotaVentaController.NuevaNotaVenta.Cliente.Direccion;
                }
            }
        }

        private void mensajeWarning(string mensaje, string titulo) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ComprobanteVentaAbstractoPanel_Load(object sender, EventArgs e) {
            
        }
    }
}
