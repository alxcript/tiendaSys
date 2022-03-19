
namespace tiendaSystem.views {
    partial class NotaIngresoForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNotaIngresoNumeros = new System.Windows.Forms.DataGridView();
            this.tipoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpBuscarNotaPorMes = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.totalesPanel = new tiendaSystem.views.TotalesPanel();
            this.dgvDetalleNotaIngreso = new System.Windows.Forms.DataGridView();
            this.itemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDisponibleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaIngresoNumeros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(200, 563);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNotaIngresoNumeros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 206);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(190, 352);
            this.panel3.TabIndex = 2;
            // 
            // dgvNotaIngresoNumeros
            // 
            this.dgvNotaIngresoNumeros.AllowUserToAddRows = false;
            this.dgvNotaIngresoNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaIngresoNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoCol,
            this.serieCol,
            this.numeroCol,
            this.idCol});
            this.dgvNotaIngresoNumeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotaIngresoNumeros.Location = new System.Drawing.Point(5, 5);
            this.dgvNotaIngresoNumeros.Name = "dgvNotaIngresoNumeros";
            this.dgvNotaIngresoNumeros.ReadOnly = true;
            this.dgvNotaIngresoNumeros.RowHeadersWidth = 26;
            this.dgvNotaIngresoNumeros.Size = new System.Drawing.Size(180, 342);
            this.dgvNotaIngresoNumeros.TabIndex = 0;
            this.dgvNotaIngresoNumeros.SelectionChanged += new System.EventHandler(this.dgvNotaIngresoNumeros_SelectionChanged);
            // 
            // tipoCol
            // 
            this.tipoCol.HeaderText = "Tipo";
            this.tipoCol.Name = "tipoCol";
            this.tipoCol.ReadOnly = true;
            this.tipoCol.Width = 30;
            // 
            // serieCol
            // 
            this.serieCol.HeaderText = "Serie";
            this.serieCol.Name = "serieCol";
            this.serieCol.ReadOnly = true;
            this.serieCol.Width = 40;
            // 
            // numeroCol
            // 
            this.numeroCol.HeaderText = "Numero";
            this.numeroCol.Name = "numeroCol";
            this.numeroCol.ReadOnly = true;
            this.numeroCol.Width = 60;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpBuscarNotaPorMes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(190, 201);
            this.panel2.TabIndex = 1;
            // 
            // dtpBuscarNotaPorMes
            // 
            this.dtpBuscarNotaPorMes.CustomFormat = "  MM / yyyy";
            this.dtpBuscarNotaPorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarNotaPorMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBuscarNotaPorMes.Location = new System.Drawing.Point(5, 173);
            this.dtpBuscarNotaPorMes.Name = "dtpBuscarNotaPorMes";
            this.dtpBuscarNotaPorMes.ShowUpDown = true;
            this.dtpBuscarNotaPorMes.Size = new System.Drawing.Size(98, 23);
            this.dtpBuscarNotaPorMes.TabIndex = 0;
            this.dtpBuscarNotaPorMes.ValueChanged += new System.EventHandler(this.dtpBuscarNotaPorMes_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(205, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(717, 206);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(609, 196);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAgregar);
            this.panel8.Controls.Add(this.btnEliminar);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 147);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(599, 44);
            this.panel8.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.Location = new System.Drawing.Point(446, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 44);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.Location = new System.Drawing.Point(524, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(599, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Nota de Ingreso";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoDocumento, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRuc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSerie, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumero, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBuscarProveedor, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRazonSocial, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.6875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.3125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Doc:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Location = new System.Drawing.Point(44, 7);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(30, 20);
            this.txtId.TabIndex = 1;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "F",
            "O"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(146, 6);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(36, 21);
            this.cmbTipoDocumento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "RUC:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRuc
            // 
            this.txtRuc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtRuc, 2);
            this.txtRuc.Location = new System.Drawing.Point(44, 38);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(96, 20);
            this.txtRuc.TabIndex = 5;
            this.txtRuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRuc_KeyDown);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(188, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Serie:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSerie.Location = new System.Drawing.Point(235, 7);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(33, 20);
            this.txtSerie.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(274, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Número:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumero.Location = new System.Drawing.Point(330, 7);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(74, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // label4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(188, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razón Social:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(146, 37);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(36, 23);
            this.btnBuscarProveedor.TabIndex = 6;
            this.btnBuscarProveedor.Text = "..";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(416, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(464, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtRazonSocial, 4);
            this.txtRazonSocial.Location = new System.Drawing.Point(274, 38);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(276, 20);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCancelar);
            this.panel6.Controls.Add(this.btnEliminarNota);
            this.panel6.Controls.Add(this.btnNuevo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(619, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(93, 196);
            this.panel6.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(8, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(8, 43);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarNota.TabIndex = 1;
            this.btnEliminarNota.Text = "Eliminar";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(8, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 29);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.dgvDetalleNotaIngreso);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(205, 211);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(717, 357);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.totalesPanel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(5, 267);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(707, 85);
            this.panel9.TabIndex = 1;
            // 
            // totalesPanel
            // 
            this.totalesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalesPanel.Location = new System.Drawing.Point(496, 5);
            this.totalesPanel.Name = "totalesPanel";
            this.totalesPanel.Size = new System.Drawing.Size(206, 75);
            this.totalesPanel.TabIndex = 0;
            // 
            // dgvDetalleNotaIngreso
            // 
            this.dgvDetalleNotaIngreso.AllowUserToAddRows = false;
            this.dgvDetalleNotaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDetalleNotaIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleNotaIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCol,
            this.cantidadCol,
            this.unidadMedidaCol,
            this.descripcionCol,
            this.costoUnitarioCol,
            this.totalCol,
            this.idProducto,
            this.cantidadDisponibleCol});
            this.dgvDetalleNotaIngreso.Location = new System.Drawing.Point(5, 8);
            this.dgvDetalleNotaIngreso.Name = "dgvDetalleNotaIngreso";
            this.dgvDetalleNotaIngreso.RowHeadersWidth = 26;
            this.dgvDetalleNotaIngreso.Size = new System.Drawing.Size(700, 253);
            this.dgvDetalleNotaIngreso.TabIndex = 0;
            // 
            // itemCol
            // 
            this.itemCol.HeaderText = "Item";
            this.itemCol.Name = "itemCol";
            this.itemCol.Width = 40;
            // 
            // cantidadCol
            // 
            this.cantidadCol.HeaderText = "Cantidad";
            this.cantidadCol.Name = "cantidadCol";
            this.cantidadCol.Width = 50;
            // 
            // unidadMedidaCol
            // 
            this.unidadMedidaCol.HeaderText = "U.M.";
            this.unidadMedidaCol.Name = "unidadMedidaCol";
            this.unidadMedidaCol.Width = 40;
            // 
            // descripcionCol
            // 
            this.descripcionCol.HeaderText = "Descripción";
            this.descripcionCol.Name = "descripcionCol";
            this.descripcionCol.Width = 200;
            // 
            // costoUnitarioCol
            // 
            this.costoUnitarioCol.HeaderText = "Costo Unitario";
            this.costoUnitarioCol.Name = "costoUnitarioCol";
            this.costoUnitarioCol.Width = 80;
            // 
            // totalCol
            // 
            this.totalCol.HeaderText = "Total";
            this.totalCol.Name = "totalCol";
            this.totalCol.Width = 80;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Id Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 50;
            // 
            // cantidadDisponibleCol
            // 
            this.cantidadDisponibleCol.HeaderText = "Cantidad Disponible";
            this.cantidadDisponibleCol.Name = "cantidadDisponibleCol";
            // 
            // NotaIngresoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 573);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "NotaIngresoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "NotaIngreso2Form";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaIngresoNumeros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleNotaIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpBuscarNotaPorMes;
        private System.Windows.Forms.DataGridView dgvNotaIngresoNumeros;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDetalleNotaIngreso;
        private System.Windows.Forms.Panel panel9;
        private TotalesPanel totalesPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDisponibleCol;
        private System.Windows.Forms.Button btnCancelar;
    }
}