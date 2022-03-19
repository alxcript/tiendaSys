using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiendaSystem.controllers;
using tiendaSystem.models;

namespace tiendaSystem.views {
    public partial class SeleccionarProductoForm : Form {

        private NotaIngresoController notaIngresoController;

        private BindingSource bindingSource;

        private BindingList<Producto> bindingList;

        private List<Producto> productos;

        public SeleccionarProductoForm(NotaIngresoController notaIngresoController) {
            InitializeComponent();
            this.notaIngresoController = notaIngresoController;
            this.productos = new ProductosController().getProductosPorDescripcion("");
            this.bindingSource = new BindingSource();
            this.bindingList = new BindingList<Producto>(this.productos);
            this.bindingSource.DataSource = this.bindingList;
            this.cmbDescripcion.DataSource = this.bindingSource;
            this.cmbDescripcion.DisplayMember = "Descripcion";
            this.cmbDescripcion.ValueMember = "Id";
            this.llenarTextBox();
        }

        private void llenarTextBox() {
            Producto producto = (Producto)this.cmbDescripcion.SelectedItem;
            this.txtId.Text = producto.Id.ToString();
            this.txtMarca.Text = producto.Marca;
            this.txtCategoria.Text = producto.Categoria;
            this.txtUnidadMedida.Text = producto.UnidadMedida;
            this.nupPrecioVenta.Value = Convert.ToDecimal(producto.PrecioVenta);
            this.nupCostoCompra.Value = Convert.ToDecimal(producto.CostoCompra);
            this.nupPrecioVentaMinimo.Value = Convert.ToDecimal(producto.PrecioVentaMinimo);
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Producto producto = (Producto)this.cmbDescripcion.SelectedItem;
            double cantidad = Convert.ToDouble(this.nupCantidad.Value);
            double costoUnitario = Convert.ToDouble(this.nupCostoUnitario.Value);
            double cantidadDisponible = cantidad;
            string numeroItem = this.notaIngresoController.NotaIngresoActual.numeroSiguienteItem();
            Console.WriteLine("NumeroItem: " + numeroItem);
            NotaIngresoDetalleHistorial notaIngresoDetalleHistorial = new NotaIngresoDetalleHistorial(numeroItem, producto.Id, cantidad, producto.UnidadMedida, producto.Descripcion, costoUnitario, cantidadDisponible);
            if(this.notaIngresoController.NotaIngresoActual.NumeroDeItems == 0) {
                this.notaIngresoController.grabarCabeceraNotaIngreso();
            }
            this.notaIngresoController.grabarDetalle(notaIngresoDetalleHistorial);
            this.notaIngresoController.NotaIngresoActual.agregarDetalle(notaIngresoDetalleHistorial);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbDescripcion_SelectedIndexChanged(object sender, EventArgs e) {
            this.llenarTextBox();
        }

        private void nupCostoUnitario_ValueChanged(object sender, EventArgs e) {
            this.nupCostoTotal.Value = this.nupCostoUnitario.Value * this.nupCantidad.Value;
        }

        private void nupCostoTotal_ValueChanged(object sender, EventArgs e) {
            if(this.nupCantidad.Value == 0) {
                this.nupCantidad.Value = 1;
            }
            this.nupCostoUnitario.Value = this.nupCostoTotal.Value / this.nupCantidad.Value;
        }

        private void nupCantidad_ValueChanged(object sender, EventArgs e) {
            this.nupCostoTotal.Value = this.nupCostoUnitario.Value * this.nupCantidad.Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            NuevoProductoForm nuevoProductoForm = new NuevoProductoForm(this.bindingList);
            DialogResult result = nuevoProductoForm.ShowDialog();
            if(result == DialogResult.OK) {
                this.bindingSource.MoveLast();
            }
        }
    }
}
