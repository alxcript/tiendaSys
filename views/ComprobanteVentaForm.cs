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
    public partial class ComprobanteVentaForm : Form {

        private NotaVentaController notaVentaController;

        private ClienteController clienteController;

        public ComprobanteVentaForm(NotaVentaController notaVentaController, string tipoDocumento) {
            InitializeComponent();
            this.notaVentaController = notaVentaController;
            this.clienteController = new ClienteController();
            this.lblComprobante.Text = tipoDocumento;
            this.notaVentaController.NuevaNotaVenta.Id = this.notaVentaController.getNuevoIdNotaVenta();
            NumeracionComprobante numeracionComprobante = new NumeracionComprobanteController().getNumeracionSegunTipoDocumento(tipoDocumento.Substring(0,1));
            this.notaVentaController.NuevaNotaVenta.NumeracionComprobante = numeracionComprobante;
            this.txtSerie.Text = numeracionComprobante.Serie;
            this.lstNumeroComprobante.Items.Add(numeracionComprobante.Numero);
            this.totalesPanel.setTotal(this.notaVentaController.NuevaNotaVenta.Total);
        }

        private void seleccionarCliente() {
            List<Cliente> clientesCoincidentes = this.clienteController.getClientePorRucDni(this.txtRucDni.Text);
            if (clientesCoincidentes.Count == 0) {
                this.mensajeWarning("No existe un cliente con ese Dni o Ruc..", "Seleccionar Cliente");
            }
            else if (clientesCoincidentes.Count == 1) {
                this.notaVentaController.agregarClienteNotaVenta(clientesCoincidentes[0]);
                this.txtRucDni.Text = clientesCoincidentes[0].DniRuc;
                this.txtNombre.Text = clientesCoincidentes[0].Nombre;
                this.txtDireccion.Text = clientesCoincidentes[0].Direccion;
            }
            else {
                ClientesCoincidentesDialogForm clientesCoincidentesDialogForm = new ClientesCoincidentesDialogForm(this.notaVentaController, clientesCoincidentes);
                DialogResult result = clientesCoincidentesDialogForm.ShowDialog();
                if (result == DialogResult.OK) {
                    this.txtRucDni.Text = this.notaVentaController.NuevaNotaVenta.Cliente.DniRuc;
                    this.txtNombre.Text = this.notaVentaController.NuevaNotaVenta.Cliente.Nombre;
                    this.txtDireccion.Text = this.notaVentaController.NuevaNotaVenta.Cliente.Direccion;
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            this.seleccionarCliente();
        }

        private void mensajeWarning(string mensaje, string titulo) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtRucDni_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                this.seleccionarCliente();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.notaVentaController.NuevaNotaVenta.Cliente = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (this.notaVentaController.NuevaNotaVenta.IsValid) {
                this.notaVentaController.NuevaNotaVenta.Fecha = this.dtpFechaEmision.Value;
                this.notaVentaController.NuevaNotaVenta.setNumeroItems();
                this.notaVentaController.grabarNuevaNotaVentaEnBD();
                this.Close();
            }
            else{
                MessageBox.Show("Falta llenar algunos campos:\n" + this.notaVentaController.NuevaNotaVenta.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
