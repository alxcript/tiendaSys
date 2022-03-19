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
    public partial class InformacionProductoPanel : UserControl {
        public InformacionProductoPanel() {
            InitializeComponent();
        }

        public Producto nuevoProducto() {
            int id = new ProductosController().getIdProductoNuevo();
            this.productoBindingSource.DataSource = new Producto(id);
            this.gbxInformacionProducto.Enabled = true;
            this.descripcionTextBox.Focus();
            return this.productoBindingSource.DataSource as Producto;
        }

        public bool grabarProducto() {
            bool ok = false;
            this.productoBindingSource.EndEdit();
            Producto producto = this.productoBindingSource.Current as Producto;
            if (!producto.IsValid) {
                MessageBox.Show("Revise los campos:\n" + producto.Error, "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                new ProductosController().grabarProductoEnBD(producto);
                MessageBox.Show("Producto " + producto.Descripcion + " registrado correctamente..", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gbxInformacionProducto.Enabled = false;
                ok = true;
            }
            return ok;
        }

        public void editarProducto(Producto producto) {
            this.productoBindingSource.DataSource = producto;
            this.gbxInformacionProducto.Enabled = true;
            this.descripcionTextBox.Focus();
        }

        public bool actualizarProducto() {
            bool ok = false;
            this.productoBindingSource.EndEdit();
            Producto producto = this.productoBindingSource.Current as Producto;
            if (!producto.IsValid) {
                MessageBox.Show("Revise los campos:\n" + producto.Error, "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                DialogResult result = MessageBox.Show("Está seguro que desea modificar el producto " + producto.Descripcion + "?", "Actualizar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes) {
                    MessageBox.Show("Producto actualizado correctamente..", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new ProductosController().actualizarProductoEnBD(producto);
                    this.gbxInformacionProducto.Enabled = false;
                    ok = true;
                }
            }
            return ok;
        }


        public void setProducto(Producto producto) {
            if(producto != null) {
                this.productoBindingSource.DataSource = producto;
            }
        }

        public void cancelarEdicion() {
            this.gbxInformacionProducto.Enabled = false;
            this.productoBindingSource.DataSource = typeof(Producto);
        }

        private void InformacionProductoPanel_Load(object sender, EventArgs e) {
            List<Producto> productos = new ProductosController().getProductosPorDescripcion("");

            string[] categorias = productos.Select(producto => producto.Categoria)
                .Distinct()
                .OrderBy(categoria => categoria)
                .ToArray();
            this.categoriaComboBox.Items.AddRange(categorias);

            string[] marcas = productos.Select(producto => producto.Marca)
                .Distinct()
                .OrderBy(marca => marca)
                .ToArray();
            this.marcaComboBox.Items.AddRange(marcas);

            string[] unidades = productos.Select(producto => producto.UnidadMedida)
                .Distinct()
                .OrderBy(unidadMedida => unidadMedida)
                .ToArray();
            this.unidadMedidaComboBox.Items.AddRange(unidades);
        }
    }
}
