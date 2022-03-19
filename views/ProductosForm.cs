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
    public partial class ProductosForm : Form {

        private List<Producto> productos;

        public ProductosForm() {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e) {
            this.productoBindingSource.DataSource = this.informacionProductoPanel.nuevoProducto();
            this.btnNuevo.Visible = false;
            this.btnCancelar.Visible = true;
            this.btnGrabar.Enabled = true;
            this.btnEditar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e) {
            bool ok = this.informacionProductoPanel.grabarProducto();
            if (ok) {
                this.productos = new ProductosController().getProductosPorDescripcion("");
                this.limpiarVentana();
            }
        }

        private void limpiarVentana() {
            this.productoBindingSource.DataSource = this.productos;
            this.btnNuevo.Visible = true;
            this.btnCancelar.Visible = false;
            this.btnGrabar.Enabled = false;
            this.btnActualizar.Enabled = false;
            this.btnEditar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.informacionProductoPanel.cancelarEdicion();
            this.limpiarVentana();
        }

        private void Productos2Form_Load(object sender, EventArgs e) {
            this.productos = new ProductosController().getProductosPorDescripcion("");
            this.productoBindingSource.DataSource = this.productos;
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (Producto producto in this.productoBindingSource.DataSource as List<Producto>) {
                ac.Add(producto.Descripcion);
            }
            this.txtBuscar.AutoCompleteCustomSource = ac;
        }

        private void productoDataGridView_SelectionChanged(object sender, EventArgs e) {
            this.informacionProductoPanel.setProducto(this.productoBindingSource.Current as Producto);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.productoBindingSource.DataSource = new ProductosController().getProductosPorDescripcion(this.txtBuscar.Text);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            Producto producto = this.productoBindingSource.Current as Producto;
            if(producto != null) {
                this.informacionProductoPanel.editarProducto((Producto)producto.Clone());
                this.productoBindingSource.DataSource = typeof(Producto);
                this.btnNuevo.Visible = false;
                this.btnCancelar.Visible = true;
                this.btnGrabar.Enabled = false;
                this.btnActualizar.Enabled = true;
                this.btnEditar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            bool ok = this.informacionProductoPanel.actualizarProducto();
            if(ok) {
                this.productoBindingSource.DataSource = new ProductosController().getProductosPorDescripcion("");
                this.btnNuevo.Visible = true;
                this.btnCancelar.Visible = false;
                this.btnGrabar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnActualizar.Enabled = false;
            }
            
        }

        private void txtBuscar_Enter(object sender, EventArgs e) {
            if(this.txtBuscar.Text == "Buscar..") {
                this.txtBuscar.Text = "";
                this.txtBuscar.Font = new Font(this.txtBuscar.Font, FontStyle.Regular);
                this.txtBuscar.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(this.txtBuscar.Text)) {
                this.txtBuscar.Text = "Buscar..";
                this.txtBuscar.Font = new Font(this.txtBuscar.Font, FontStyle.Italic);
                this.txtBuscar.ForeColor = Color.Gray;
            }
        }
    }
}
