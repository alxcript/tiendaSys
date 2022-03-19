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
    public partial class NotaVentaForm : Form {

        private NotaVentaController notaVentaController;

        public NotaVentaForm() {
            InitializeComponent();
            this.notaVentaController = new NotaVentaController();
            this.llenarDgvProducto(this.notaVentaController.getProductosPorDescripcion(""));
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                List<Producto> productosCoincidentes = this.notaVentaController.getProductosPorDescripcion(this.txtBuscar.Text);
                this.llenarDgvProducto(productosCoincidentes);
            }
            if(e.KeyCode == Keys.Down) {
                this.dgvProductos.Focus();
            }
        }

        private void llenarDgvProducto(List<Producto> productos) {
            this.dgvProductos.Rows.Clear();
            foreach (Producto producto in productos) {
                this.dgvProductos.Rows.Add(producto.Descripcion, producto.Marca, producto.PrecioVenta, producto.UnidadMedida, producto.Id, producto.Stock);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e) {
            if(this.dgvProductos.Rows.Count > 0) {
                this.txtIdProducto.Text = this.dgvProductos.CurrentRow.Cells["idProductoCol"].Value.ToString();
                this.txtStock.Text = this.dgvProductos.CurrentRow.Cells["stockCol"].Value.ToString();
                this.txtDescripcion.Text = this.dgvProductos.CurrentRow.Cells["descripcionCol"].Value.ToString();
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if(this.dgvProductos.Rows.Count > 0) {
                int idProducto = Convert.ToInt32(this.txtIdProducto.Text);
                double cantidad = Convert.ToDouble(this.nudCantidad.Value);
                bool ok = this.notaVentaController.agregarItemNuevaVenta(idProducto, cantidad);
                if (!ok) {
                    MessageBox.Show("No existe el stock suficiente para vender el producto..", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    this.actualizarDgvNotaVenta();
                }
                this.lblAgregando.Text = "";
            }
        }

        private void actualizarDgvNotaVenta() {
            this.dgvListaVenta.Rows.Clear();
            foreach(NotaVentaDetalle nvd in this.notaVentaController.NuevaNotaVenta.NotaVentaDetalle) {
                this.dgvListaVenta.Rows.Add(nvd.Producto.Id, nvd.Cantidad, nvd.Producto.UnidadMedida, nvd.Producto.Descripcion, nvd.PrecioUnitario, nvd.Total);
            }
            this.totalesPanel.setTotal(this.notaVentaController.NuevaNotaVenta.Total);
            this.nudCantidad.Value = 1;
            this.txtBuscar.Focus();
            this.txtBuscar.SelectAll();
        }

        private void btnQuitar_Click(object sender, EventArgs e) {
            if(this.dgvListaVenta.Rows.Count > 0) {
                int idProducto = (int)this.dgvListaVenta.CurrentRow.Cells["idCol"].Value;
                this.notaVentaController.quitarItemNuevaVenta(idProducto);
                this.actualizarDgvNotaVenta();
            }
        }

        private void dgvListaVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if(this.dgvListaVenta.Rows.Count > 0) {
                int idProducto = (int)this.dgvListaVenta.Rows[e.RowIndex].Cells[0].Value;
                if(e.ColumnIndex == 4) {
                    double precioVenta;
                    if (Double.TryParse(this.dgvListaVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out precioVenta)) {
                        this.notaVentaController.NuevaNotaVenta.cambiarPrecioVentaUnitario(idProducto, precioVenta);
                    }
                    else {
                        this.mostrarMensageWarning("Escriba un precio valido por favor..", "Cambiando Precio Unitario");
                    }
                }
                else if(e.ColumnIndex == 5) {
                    double total;
                    if (Double.TryParse(this.dgvListaVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out total)) {
                        this.notaVentaController.NuevaNotaVenta.cambiarPrecioVentaTotal(idProducto, total);
                    }
                    else {
                        this.mostrarMensageWarning("Escriba un precio valido por favor..", "Cambiando Total");
                    }
                }
                
                this.actualizarDgvNotaVenta();
            }
            
        }

        private void NotaVentaForm_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Add) {
                this.nudCantidad.Focus();
                this.nudCantidad.Select(0, this.nudCantidad.Text.Length);
                this.lblAgregando.Text = "+";
            }
        }

        private void nudCantidad_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                this.btnAgregar_Click(sender, e);
            }
        }

        private void btnBoleta_Click(object sender, EventArgs e) {
            this.presentarComprobante("BOLETA");
        }

        private void btnFactura_Click(object sender, EventArgs e) {
            this.presentarComprobante("FACTURA");
        }

        private void presentarComprobante(string tipoDocumento) {
            if (this.dgvListaVenta.RowCount > 0) {
                ComprobanteVentaForm comprobanteVentaForm = new ComprobanteVentaForm(this.notaVentaController, tipoDocumento);
                DialogResult result = comprobanteVentaForm.ShowDialog();
                if (result == DialogResult.OK) {
                    this.notaVentaController.actualizarStockProductosFromDB();
                    this.limpiarNotaVenta();
                }
            }
            else {
                this.mostrarMensageWarning("Debe haber al menos un producto en la lista..", tipoDocumento);
                this.txtBuscar.Focus();
            }
        }

        private void limpiarNotaVenta() {
            this.llenarDgvProducto(this.notaVentaController.getProductosPorDescripcion(""));
            this.dgvListaVenta.Rows.Clear();
            this.totalesPanel.setTotal(0);
            this.txtBuscar.Focus();
        }

        private void mostrarMensageWarning(string mensaje, string titulo) {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
    }
}
