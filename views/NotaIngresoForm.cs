using System;
using System.Data;
using System.Windows.Forms;
using tiendaSystem.controllers;
using tiendaSystem.models;

namespace tiendaSystem.views {
    public partial class NotaIngresoForm : Form {

        private NotaIngresoController notaIngresoController;

        public NotaIngresoForm() {
            InitializeComponent();
            this.notaIngresoController = new NotaIngresoController();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            this.limpiarNotaIngreso();
            this.notaIngresoController.crearNuevoNotaIngreso();
            this.txtId.Text = this.notaIngresoController.NotaIngresoActual.Id.ToString();
            this.txtSerie.Focus();
            this.btnCancelar.Visible = true;
        }

        private void dtpBuscarNotaPorMes_ValueChanged(object sender, EventArgs e) {
            string fecha = this.dtpBuscarNotaPorMes.Value.ToString("yyyy/MM/dd");
            this.buscarNotasPorMes(fecha);
        }

        private void buscarNotasPorMes(string fecha) {
            this.dgvNotaIngresoNumeros.Rows.Clear();
            foreach (NotaIngresoHistorial notaIngreso in this.notaIngresoController.getNotaIngresoDetalleHistorialPorMes(fecha)) {
                this.dgvNotaIngresoNumeros.Rows.Add(notaIngreso.Id, notaIngreso.Serie, notaIngreso.Numero, notaIngreso.Id);
            }
            if (this.dgvNotaIngresoNumeros.Rows.Count == 0) {
                this.limpiarNotaIngreso();
            }
        }

        private void limpiarNotaIngreso() {
            this.txtId.Clear();
            this.txtSerie.Clear();
            this.txtNumero.Clear();
            this.txtRuc.Clear();
            this.txtRazonSocial.Clear();
            this.dgvDetalleNotaIngreso.Rows.Clear();
            this.dtpFecha.Value = DateTime.Now;
            this.totalesPanel.clear();
        }

        private void dgvNotaIngresoNumeros_SelectionChanged(object sender, EventArgs e) {
            int id = (int)this.dgvNotaIngresoNumeros.CurrentRow.Cells["idCol"].Value;
            NotaIngresoHistorial notaIngresoHistorial = this.notaIngresoController.getNotaIngresHistorialPorId(id);
            this.notaIngresoController.NotaIngresoActual = notaIngresoHistorial;
            this.llenarDgvNotaIngresoDetalle(notaIngresoHistorial);
        }

        private void llenarDgvNotaIngresoDetalle(NotaIngresoHistorial notaIngresoHistorial) {
            this.txtId.Text = notaIngresoHistorial.Id.ToString();
            this.txtSerie.Text = notaIngresoHistorial.Serie;
            this.txtNumero.Text = notaIngresoHistorial.Numero;
            this.dtpFecha.Value = notaIngresoHistorial.FechaDocumento;
            this.txtRuc.Text = notaIngresoHistorial.Proveedor.Ruc;
            this.txtRazonSocial.Text = notaIngresoHistorial.Proveedor.RazonSocial;
            this.cmbTipoDocumento.SelectedItem = notaIngresoHistorial.TipoDocumento;
            this.dgvDetalleNotaIngreso.Rows.Clear();
            foreach (NotaIngresoDetalleHistorial detalle in notaIngresoHistorial.DetalleHistorial) {
                this.dgvDetalleNotaIngreso.Rows.Add(detalle.NumeroItem, detalle.Cantidad, detalle.UnidadMedida, detalle.DescripcionProducto, detalle.CostoUnitario, detalle.Total, detalle.IdProducto, detalle.CantidadDisponible);
            }
            this.totalesPanel.setTotal(notaIngresoHistorial.Total);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            int idActual = this.notaIngresoController.NotaIngresoActual.Id;
            this.notaIngresoController.NotaIngresoActual.TipoDocumento = this.cmbTipoDocumento.Text;
            this.notaIngresoController.NotaIngresoActual.Serie = this.txtSerie.Text;
            this.notaIngresoController.NotaIngresoActual.Numero = this.txtNumero.Text;
            this.notaIngresoController.NotaIngresoActual.FechaDocumento = this.dtpFecha.Value;
            if (!this.notaIngresoController.NotaIngresoActual.IsValid) {
                MessageBox.Show("[" + this.notaIngresoController.NotaIngresoActual.Error + "]");
            }
            else {
                SeleccionarProductoForm seleccionarProductoForm = new SeleccionarProductoForm(this.notaIngresoController);
                DialogResult result = seleccionarProductoForm.ShowDialog();
                if(result == DialogResult.OK) {
                    string fecha = this.dtpFecha.Value.ToString("yyyy/MM/dd");
                    this.buscarNotasPorMes(fecha);
                    int row = 0;
                    for(int i = 0; i < this.dgvNotaIngresoNumeros.Rows.Count; i++) {
                        if((int)this.dgvNotaIngresoNumeros.Rows[i].Cells["idCol"].Value == idActual) {
                            Console.WriteLine("IdCol: " + this.dgvNotaIngresoNumeros.Rows[i].Cells["idCol"].Value);
                            row = i;
                            break;
                        }
                    }
                    this.dgvNotaIngresoNumeros.CurrentCell = this.dgvNotaIngresoNumeros[0, row];
                    this.llenarDgvNotaIngresoDetalle(this.notaIngresoController.NotaIngresoActual);
                }
            }
        }


        private void btnBuscarProveedor_Click(object sender, EventArgs e) {
            DataTable proveedoresCoincidentes = new ProveedorController().getProveedoresPorRuc(this.txtRuc.Text);
            if (proveedoresCoincidentes.Rows.Count == 0) {
                MessageBox.Show("No existen proveedores con el ruc " + this.txtRuc.Text + "!!");
            }
            else if (proveedoresCoincidentes.Rows.Count == 1) {
                int id = proveedoresCoincidentes.Rows[0].Field<int>("id");
                string ruc = proveedoresCoincidentes.Rows[0].Field<string>("ruc");
                string razonSocial = proveedoresCoincidentes.Rows[0].Field<string>("businessName");
                string direccion = proveedoresCoincidentes.Rows[0].Field<string>("fiscalAddress");
                this.notaIngresoController.NotaIngresoActual.Proveedor = new Proveedor(id, ruc, razonSocial, direccion);
                this.txtRuc.Text = this.notaIngresoController.NotaIngresoActual.Proveedor.Ruc;
                this.txtRazonSocial.Text = this.notaIngresoController.NotaIngresoActual.Proveedor.RazonSocial;
            }
            else {
                ProveedoresCoincidentesDialogForm proveedoresCoincidentesDialogForm = new ProveedoresCoincidentesDialogForm(proveedoresCoincidentes, this.notaIngresoController.NotaIngresoActual);
                DialogResult result = proveedoresCoincidentesDialogForm.ShowDialog();
                if (result == DialogResult.OK) {
                    this.txtRuc.Text = this.notaIngresoController.NotaIngresoActual.Proveedor.Ruc;
                    this.txtRazonSocial.Text = this.notaIngresoController.NotaIngresoActual.Proveedor.RazonSocial;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if(this.dgvDetalleNotaIngreso.Rows.Count > 0) {
                double cantidad = (double)this.dgvDetalleNotaIngreso.CurrentRow.Cells["cantidadCol"].Value;
                double cantidadDisponible = (double)this.dgvDetalleNotaIngreso.CurrentRow.Cells["cantidadDisponibleCol"].Value;
                if(cantidad == cantidadDisponible) {
                    string producto = this.dgvDetalleNotaIngreso.CurrentRow.Cells["descripcionCol"].Value.ToString();
                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el producto " + producto + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes) {
                        string numeroItem = this.dgvDetalleNotaIngreso.CurrentRow.Cells["itemCol"].Value.ToString();
                        this.notaIngresoController.eliminarDetalleNotaIngreso(this.notaIngresoController.NotaIngresoActual.Id, numeroItem);

                        int idActual = this.notaIngresoController.NotaIngresoActual.Id;
                        string fecha = this.dtpFecha.Value.ToString("yyyy/MM/dd");
                        this.buscarNotasPorMes(fecha);
                        int row = 0;
                        for (int i = 0; i < this.dgvNotaIngresoNumeros.Rows.Count; i++) {
                            if ((int)this.dgvNotaIngresoNumeros.Rows[i].Cells["idCol"].Value == idActual) {
                                Console.WriteLine("IdCol: " + this.dgvNotaIngresoNumeros.Rows[i].Cells["idCol"].Value);
                                row = i;
                                break;
                            }
                        }
                        this.dgvNotaIngresoNumeros.CurrentCell = this.dgvNotaIngresoNumeros[0, row];
                        this.llenarDgvNotaIngresoDetalle(this.notaIngresoController.NotaIngresoActual);
                    }
                }
                else {
                    MessageBox.Show("El producto ya tiene movimientos en su stock.. No se puede eliminar..");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.btnCancelar.Visible = false;
            this.dtpBuscarNotaPorMes_ValueChanged(sender, e);
        }

        private void txtRuc_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.btnBuscarProveedor_Click(sender, e);
            }
        }
    }
}
