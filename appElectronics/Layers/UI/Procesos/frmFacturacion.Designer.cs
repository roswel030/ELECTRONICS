namespace UTN.Winform.Electronics.Layers.UI.Procesos
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblDolar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tlpAgrupamiento = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCodigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcionElectronico = new System.Windows.Forms.TextBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbPanelTotalPagar = new System.Windows.Forms.TableLayoutPanel();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grbFacturacion = new System.Windows.Forms.GroupBox();
            this.tlpProducto = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.sttBarraInferior.SuspendLayout();
            this.tspBarraSuperior.SuspendLayout();
            this.tlpAgrupamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.tlbPanelTotalPagar.SuspendLayout();
            this.grbFacturacion.SuspendLayout();
            this.tlpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.grbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblDolar});
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 611);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sttBarraInferior.Size = new System.Drawing.Size(1517, 34);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // toolStripStatusLblDolar
            // 
            this.toolStripStatusLblDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLblDolar.Name = "toolStripStatusLblDolar";
            this.toolStripStatusLblDolar.Size = new System.Drawing.Size(20, 28);
            this.toolStripStatusLblDolar.Text = "-";
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnFacturar,
            this.toolStripBtnSalir});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(1517, 55);
            this.tspBarraSuperior.TabIndex = 1;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = global::UTN.Winform.Electronics.Properties.Resources.document_new_4;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(104, 52);
            this.toolStripBtnNuevo.Text = "Nuevo";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnFacturar
            // 
            this.toolStripBtnFacturar.Image = global::UTN.Winform.Electronics.Properties.Resources.accessories_calculator_3;
            this.toolStripBtnFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFacturar.Name = "toolStripBtnFacturar";
            this.toolStripBtnFacturar.Size = new System.Drawing.Size(113, 52);
            this.toolStripBtnFacturar.Text = "Facturar";
            this.toolStripBtnFacturar.Click += new System.EventHandler(this.toolStripBtnFacturar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // tlpAgrupamiento
            // 
            this.tlpAgrupamiento.BackColor = System.Drawing.SystemColors.Control;
            this.tlpAgrupamiento.ColumnCount = 3;
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tlpAgrupamiento.Controls.Add(this.label3, 0, 4);
            this.tlpAgrupamiento.Controls.Add(this.label2, 0, 3);
            this.tlpAgrupamiento.Controls.Add(this.label4, 0, 2);
            this.tlpAgrupamiento.Controls.Add(this.txtNumeroTarjeta, 1, 3);
            this.tlpAgrupamiento.Controls.Add(this.txtClienteId, 1, 4);
            this.tlpAgrupamiento.Controls.Add(this.rdbContado, 1, 1);
            this.tlpAgrupamiento.Controls.Add(this.cmbTarjeta, 1, 2);
            this.tlpAgrupamiento.Controls.Add(this.btnBuscarCliente, 2, 3);
            this.tlpAgrupamiento.Controls.Add(this.label1, 0, 1);
            this.tlpAgrupamiento.Controls.Add(this.label11, 0, 0);
            this.tlpAgrupamiento.Controls.Add(this.txtNumeroFactura, 1, 0);
            this.tlpAgrupamiento.Controls.Add(this.txtNombreCliente, 1, 5);
            this.tlpAgrupamiento.Controls.Add(this.label12, 0, 5);
            this.tlpAgrupamiento.Controls.Add(this.rdbCredito, 2, 1);
            this.tlpAgrupamiento.Location = new System.Drawing.Point(21, 36);
            this.tlpAgrupamiento.Margin = new System.Windows.Forms.Padding(4);
            this.tlpAgrupamiento.Name = "tlpAgrupamiento";
            this.tlpAgrupamiento.RowCount = 6;
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAgrupamiento.Size = new System.Drawing.Size(612, 215);
            this.tlpAgrupamiento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Tarjeta";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarjeta";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(176, 95);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(239, 22);
            this.txtNumeroTarjeta.TabIndex = 2;
            this.txtNumeroTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroTarjeta_KeyDown);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(176, 125);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(239, 22);
            this.txtClienteId.TabIndex = 3;
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Location = new System.Drawing.Point(176, 34);
            this.rdbContado.Margin = new System.Windows.Forms.Padding(4);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(82, 21);
            this.rdbContado.TabIndex = 0;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            this.rdbContado.Click += new System.EventHandler(this.rdbContado_Click);
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(176, 63);
            this.cmbTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(239, 24);
            this.cmbTarjeta.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::UTN.Winform.Electronics.Properties.Resources.edit_find;
            this.btnBuscarCliente.Location = new System.Drawing.Point(453, 95);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.tlpAgrupamiento.SetRowSpan(this.btnBuscarCliente, 2);
            this.btnBuscarCliente.Size = new System.Drawing.Size(147, 69);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pago";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "No. Factura";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(176, 4);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(265, 22);
            this.txtNumeroFactura.TabIndex = 0;
            this.txtNumeroFactura.TabStop = false;
            // 
            // txtNombreCliente
            // 
            this.tlpAgrupamiento.SetColumnSpan(this.txtNombreCliente, 2);
            this.txtNombreCliente.Location = new System.Drawing.Point(176, 172);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(424, 22);
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre Cliente";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Checked = true;
            this.rdbCredito.Location = new System.Drawing.Point(453, 34);
            this.rdbCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCredito.Name = "rdbCredito";
            this.tlpAgrupamiento.SetRowSpan(this.rdbCredito, 2);
            this.rdbCredito.Size = new System.Drawing.Size(74, 21);
            this.rdbCredito.TabIndex = 0;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.Click += new System.EventHandler(this.rdbCredito_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código Producto";
            // 
            // mskCodigoProduto
            // 
            this.mskCodigoProduto.Location = new System.Drawing.Point(167, 4);
            this.mskCodigoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.mskCodigoProduto.Mask = "99999999999";
            this.mskCodigoProduto.Name = "mskCodigoProduto";
            this.mskCodigoProduto.Size = new System.Drawing.Size(241, 22);
            this.mskCodigoProduto.TabIndex = 5;
            this.mskCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigoProduto_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(4, 126);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(155, 17);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(167, 124);
            this.mskCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.mskCantidad.Mask = "999999999999";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(241, 22);
            this.mskCantidad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(167, 154);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(241, 22);
            this.txtPrecio.TabIndex = 0;
            this.txtPrecio.TabStop = false;
            // 
            // txtDescripcionElectronico
            // 
            this.txtDescripcionElectronico.Location = new System.Drawing.Point(167, 34);
            this.txtDescripcionElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionElectronico.Name = "txtDescripcionElectronico";
            this.txtDescripcionElectronico.ReadOnly = true;
            this.txtDescripcionElectronico.Size = new System.Drawing.Size(241, 22);
            this.txtDescripcionElectronico.TabIndex = 0;
            this.txtDescripcionElectronico.TabStop = false;
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDetalleFactura.Location = new System.Drawing.Point(692, 98);
            this.dgvDetalleFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(790, 341);
            this.dgvDetalleFactura.TabIndex = 0;
            this.dgvDetalleFactura.TabStop = false;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdElectronico";
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DescripcionElectronico";
            this.Column2.HeaderText = "Descripcion Electronico";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.ToolTipText = "0";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // tlbPanelTotalPagar
            // 
            this.tlbPanelTotalPagar.ColumnCount = 2;
            this.tlbPanelTotalPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68208F));
            this.tlbPanelTotalPagar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.31792F));
            this.tlbPanelTotalPagar.Controls.Add(this.txtDolares, 1, 3);
            this.tlbPanelTotalPagar.Controls.Add(this.label8, 0, 0);
            this.tlbPanelTotalPagar.Controls.Add(this.label9, 0, 1);
            this.tlbPanelTotalPagar.Controls.Add(this.label10, 0, 2);
            this.tlbPanelTotalPagar.Controls.Add(this.txtSubtotal, 1, 0);
            this.tlbPanelTotalPagar.Controls.Add(this.txtImpuesto, 1, 1);
            this.tlbPanelTotalPagar.Controls.Add(this.txtTotal, 1, 2);
            this.tlbPanelTotalPagar.Controls.Add(this.label14, 0, 3);
            this.tlbPanelTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbPanelTotalPagar.Location = new System.Drawing.Point(539, 378);
            this.tlbPanelTotalPagar.Margin = new System.Windows.Forms.Padding(4);
            this.tlbPanelTotalPagar.Name = "tlbPanelTotalPagar";
            this.tlbPanelTotalPagar.RowCount = 4;
            this.tlbPanelTotalPagar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbPanelTotalPagar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbPanelTotalPagar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbPanelTotalPagar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbPanelTotalPagar.Size = new System.Drawing.Size(273, 151);
            this.tlbPanelTotalPagar.TabIndex = 5;
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(98, 118);
            this.txtDolares.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.ReadOnly = true;
            this.txtDolares.Size = new System.Drawing.Size(165, 30);
            this.txtDolares.TabIndex = 4;
            this.txtDolares.TabStop = false;
            this.txtDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(98, 4);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(169, 30);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(98, 42);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(165, 30);
            this.txtImpuesto.TabIndex = 0;
            this.txtImpuesto.TabStop = false;
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(98, 80);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(165, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Dólares";
            // 
            // grbFacturacion
            // 
            this.grbFacturacion.Controls.Add(this.tlpAgrupamiento);
            this.grbFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFacturacion.Location = new System.Drawing.Point(9, 69);
            this.grbFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.grbFacturacion.Name = "grbFacturacion";
            this.grbFacturacion.Padding = new System.Windows.Forms.Padding(4);
            this.grbFacturacion.Size = new System.Drawing.Size(653, 490);
            this.grbFacturacion.TabIndex = 6;
            this.grbFacturacion.TabStop = false;
            this.grbFacturacion.Text = "Facturación";
            // 
            // tlpProducto
            // 
            this.tlpProducto.ColumnCount = 3;
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9822F));
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0178F));
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpProducto.Controls.Add(this.label7, 0, 4);
            this.tlpProducto.Controls.Add(this.lblCantidad, 0, 3);
            this.tlpProducto.Controls.Add(this.txtPrecio, 1, 4);
            this.tlpProducto.Controls.Add(this.btnBuscarProducto, 2, 0);
            this.tlpProducto.Controls.Add(this.mskCantidad, 1, 3);
            this.tlpProducto.Controls.Add(this.mskCodigoProduto, 1, 0);
            this.tlpProducto.Controls.Add(this.btnAgregar, 2, 3);
            this.tlpProducto.Controls.Add(this.label6, 0, 1);
            this.tlpProducto.Controls.Add(this.label5, 0, 0);
            this.tlpProducto.Controls.Add(this.txtDescripcionElectronico, 1, 1);
            this.tlpProducto.Controls.Add(this.label13, 0, 2);
            this.tlpProducto.Controls.Add(this.txtExistencia, 1, 2);
            this.tlpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProducto.Location = new System.Drawing.Point(31, 342);
            this.tlpProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tlpProducto.Name = "tlpProducto";
            this.tlpProducto.RowCount = 5;
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpProducto.Size = new System.Drawing.Size(611, 208);
            this.tlpProducto.TabIndex = 7;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::UTN.Winform.Electronics.Properties.Resources.edit_find;
            this.btnBuscarProducto.Location = new System.Drawing.Point(434, 4);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.tlpProducto.SetRowSpan(this.btnBuscarProducto, 2);
            this.btnBuscarProducto.Size = new System.Drawing.Size(147, 82);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::UTN.Winform.Electronics.Properties.Resources.db_add;
            this.btnAgregar.Location = new System.Drawing.Point(434, 124);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.tlpProducto.SetRowSpan(this.btnAgregar, 2);
            this.btnAgregar.Size = new System.Drawing.Size(147, 70);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(167, 94);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(241, 22);
            this.txtExistencia.TabIndex = 0;
            this.txtExistencia.TabStop = false;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.tlbPanelTotalPagar);
            this.grbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalle.Location = new System.Drawing.Point(670, 69);
            this.grbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.grbDetalle.Size = new System.Drawing.Size(834, 548);
            this.grbDetalle.TabIndex = 8;
            this.grbDetalle.TabStop = false;
            this.grbDetalle.Text = "Detalle";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 645);
            this.Controls.Add(this.tlpProducto);
            this.Controls.Add(this.grbFacturacion);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.sttBarraInferior);
            this.Controls.Add(this.grbDetalle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.sttBarraInferior.ResumeLayout(false);
            this.sttBarraInferior.PerformLayout();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.tlpAgrupamiento.ResumeLayout(false);
            this.tlpAgrupamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.tlbPanelTotalPagar.ResumeLayout(false);
            this.tlbPanelTotalPagar.PerformLayout();
            this.grbFacturacion.ResumeLayout(false);
            this.tlpProducto.ResumeLayout(false);
            this.tlpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.grbDetalle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnFacturar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.TableLayoutPanel tlpAgrupamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.MaskedTextBox mskCodigoProduto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.TableLayoutPanel tlbPanelTotalPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grbFacturacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcionElectronico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tlpProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblDolar;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}