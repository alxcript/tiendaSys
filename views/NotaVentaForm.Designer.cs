
namespace tiendaSystem.views {
    partial class NotaVentaForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.descripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAgregando = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaVenta = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.totalesPanel = new tiendaSystem.views.TotalesPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenta)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(798, 248);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(238, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(555, 238);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvProductos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(5, 64);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(545, 169);
            this.panel5.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionCol,
            this.marcaCol,
            this.precioCol,
            this.unidadMedidaCol,
            this.idProductoCol,
            this.stockCol});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(5, 5);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 26;
            this.dgvProductos.Size = new System.Drawing.Size(535, 159);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // descripcionCol
            // 
            this.descripcionCol.HeaderText = "Producto";
            this.descripcionCol.Name = "descripcionCol";
            this.descripcionCol.ReadOnly = true;
            this.descripcionCol.Width = 250;
            // 
            // marcaCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marcaCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.marcaCol.HeaderText = "Marca";
            this.marcaCol.Name = "marcaCol";
            this.marcaCol.ReadOnly = true;
            // 
            // precioCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.precioCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioCol.HeaderText = "Precio";
            this.precioCol.Name = "precioCol";
            this.precioCol.ReadOnly = true;
            this.precioCol.Width = 60;
            // 
            // unidadMedidaCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unidadMedidaCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.unidadMedidaCol.HeaderText = "U.M.";
            this.unidadMedidaCol.Name = "unidadMedidaCol";
            this.unidadMedidaCol.ReadOnly = true;
            this.unidadMedidaCol.Width = 60;
            // 
            // idProductoCol
            // 
            this.idProductoCol.HeaderText = "Id Producto";
            this.idProductoCol.Name = "idProductoCol";
            this.idProductoCol.ReadOnly = true;
            this.idProductoCol.Visible = false;
            // 
            // stockCol
            // 
            this.stockCol.HeaderText = "Stock";
            this.stockCol.Name = "stockCol";
            this.stockCol.ReadOnly = true;
            this.stockCol.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(545, 59);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdProducto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStock, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtIdProducto.Location = new System.Drawing.Point(51, 1);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(1);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(57, 20);
            this.txtIdProducto.TabIndex = 2;
            this.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtStock.Location = new System.Drawing.Point(51, 26);
            this.txtStock.Margin = new System.Windows.Forms.Padding(1);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(57, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDescripcion.Location = new System.Drawing.Point(110, 1);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(1);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Size = new System.Drawing.Size(424, 48);
            this.txtDescripcion.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAgregando);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(233, 238);
            this.panel2.TabIndex = 1;
            // 
            // lblAgregando
            // 
            this.lblAgregando.AutoSize = true;
            this.lblAgregando.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregando.ForeColor = System.Drawing.Color.Green;
            this.lblAgregando.Location = new System.Drawing.Point(208, 106);
            this.lblAgregando.Name = "lblAgregando";
            this.lblAgregando.Size = new System.Drawing.Size(0, 19);
            this.lblAgregando.TabIndex = 3;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(150, 165);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(40, 40);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "-";
            this.toolTip.SetToolTip(this.btnQuitar, "Quitar producto de la lista..");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(101, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "+";
            this.toolTip.SetToolTip(this.btnAgregar, "Agregar producto a la lista..");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.nudCantidad, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCantidad.Location = new System.Drawing.Point(120, 35);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(72, 30);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudCantidad_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.SetColumnSpan(this.txtBuscar, 2);
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(61, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 26);
            this.txtBuscar.TabIndex = 1;
            this.toolTip.SetToolTip(this.txtBuscar, "Escriba el nombre y presione Enter para buscar..");
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad:";
            // 
            // dgvListaVenta
            // 
            this.dgvListaVenta.AllowUserToAddRows = false;
            this.dgvListaVenta.AllowUserToDeleteRows = false;
            this.dgvListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.cantidadCol,
            this.umCol,
            this.descripcionProductoCol,
            this.precioUnitarioCol,
            this.precioTotalCol});
            this.dgvListaVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaVenta.Location = new System.Drawing.Point(5, 5);
            this.dgvListaVenta.Name = "dgvListaVenta";
            this.dgvListaVenta.RowHeadersWidth = 26;
            this.dgvListaVenta.Size = new System.Drawing.Size(778, 149);
            this.dgvListaVenta.TabIndex = 1;
            this.dgvListaVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVenta_CellValueChanged);
            // 
            // idCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 30;
            // 
            // cantidadCol
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidadCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidadCol.HeaderText = "Cantidad";
            this.cantidadCol.Name = "cantidadCol";
            this.cantidadCol.ReadOnly = true;
            this.cantidadCol.Width = 60;
            // 
            // umCol
            // 
            this.umCol.HeaderText = "U.M.";
            this.umCol.Name = "umCol";
            this.umCol.ReadOnly = true;
            this.umCol.Width = 50;
            // 
            // descripcionProductoCol
            // 
            this.descripcionProductoCol.HeaderText = "Descripción";
            this.descripcionProductoCol.Name = "descripcionProductoCol";
            this.descripcionProductoCol.ReadOnly = true;
            this.descripcionProductoCol.Width = 250;
            // 
            // precioUnitarioCol
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.precioUnitarioCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.precioUnitarioCol.HeaderText = "Precio Unitario";
            this.precioUnitarioCol.Name = "precioUnitarioCol";
            // 
            // precioTotalCol
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.precioTotalCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.precioTotalCol.HeaderText = "Precio Total";
            this.precioTotalCol.Name = "precioTotalCol";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 248);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(798, 259);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 164);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(788, 90);
            this.panel8.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.totalesPanel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(521, 5);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(262, 80);
            this.panel10.TabIndex = 5;
            // 
            // totalesPanel
            // 
            this.totalesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalesPanel.Location = new System.Drawing.Point(104, 5);
            this.totalesPanel.Name = "totalesPanel";
            this.totalesPanel.Size = new System.Drawing.Size(153, 70);
            this.totalesPanel.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnFactura);
            this.panel9.Controls.Add(this.btnBoleta);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(516, 80);
            this.panel9.TabIndex = 4;
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(109, 8);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(95, 63);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Factura >>";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnBoleta
            // 
            this.btnBoleta.Location = new System.Drawing.Point(8, 8);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(95, 63);
            this.btnBoleta.TabIndex = 0;
            this.btnBoleta.Text = "Boleta >>";
            this.btnBoleta.UseVisualStyleBackColor = true;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvListaVenta);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(788, 159);
            this.panel7.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // NotaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "NotaVentaForm";
            this.Text = "NotaVentaForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotaVentaForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenta)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCol;
        private System.Windows.Forms.DataGridView dgvListaVenta;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private TotalesPanel totalesPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn umCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalCol;
        private System.Windows.Forms.Label lblAgregando;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnFactura;
    }
}