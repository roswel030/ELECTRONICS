namespace UTN.Winform.Electronics.Layers.UI.Mantenimientos
{
    partial class frmMantenimientoElectronico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoElectronico));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.sttInferior = new System.Windows.Forms.StatusStrip();
            this.spcContenedor = new System.Windows.Forms.SplitContainer();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cmsImagen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdSi = new System.Windows.Forms.RadioButton();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.pbDocumentacion = new System.Windows.Forms.PictureBox();
            this.cmsDocumento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).BeginInit();
            this.spcContenedor.Panel1.SuspendLayout();
            this.spcContenedor.Panel2.SuspendLayout();
            this.spcContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.cmsImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumentacion)).BeginInit();
            this.cmsDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnEditar,
            this.toolStripBtnBorrar,
            this.toolStripBtnSalir});
            this.tspPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.Size = new System.Drawing.Size(1360, 55);
            this.tspPrincipal.TabIndex = 0;
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = global::UTN.Winform.Electronics.Properties.Resources.document_new_4;
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(104, 52);
            this.toolStripBtnNuevo.Text = "&Nuevo";
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnEditar
            // 
            this.toolStripBtnEditar.Image = global::UTN.Winform.Electronics.Properties.Resources.document_edit;
            this.toolStripBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEditar.Name = "toolStripBtnEditar";
            this.toolStripBtnEditar.Size = new System.Drawing.Size(100, 52);
            this.toolStripBtnEditar.Text = "&Editar";
            this.toolStripBtnEditar.Click += new System.EventHandler(this.toolStripBtnEditar_Click);
            // 
            // toolStripBtnBorrar
            // 
            this.toolStripBtnBorrar.Image = global::UTN.Winform.Electronics.Properties.Resources.trash_empty_3;
            this.toolStripBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBorrar.Name = "toolStripBtnBorrar";
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(102, 52);
            this.toolStripBtnBorrar.Text = "&Borrar";
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalir.Text = "&Salir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // sttInferior
            // 
            this.sttInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttInferior.Location = new System.Drawing.Point(0, 636);
            this.sttInferior.Name = "sttInferior";
            this.sttInferior.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sttInferior.Size = new System.Drawing.Size(1360, 22);
            this.sttInferior.TabIndex = 1;
            this.sttInferior.Text = "statusStrip1";
            // 
            // spcContenedor
            // 
            this.spcContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContenedor.Location = new System.Drawing.Point(0, 55);
            this.spcContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spcContenedor.Name = "spcContenedor";
            // 
            // spcContenedor.Panel1
            // 
            this.spcContenedor.Panel1.Controls.Add(this.dgvDatos);
            // 
            // spcContenedor.Panel2
            // 
            this.spcContenedor.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.spcContenedor.Size = new System.Drawing.Size(1360, 581);
            this.spcContenedor.SplitterDistance = 885;
            this.spcContenedor.SplitterWidth = 5;
            this.spcContenedor.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(881, 577);
            this.dgvDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdElectronico";
            this.Column1.HeaderText = "IdElectronico";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DescripcionElectronico";
            this.Column2.HeaderText = "DescripcionElectronico";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Cantidad";
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Imagen";
            this.Column5.HeaderText = "Imagen";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Garantia";
            this.Column6.HeaderText = "Garantia";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DescripcionBodega";
            this.Column7.HeaderText = "DescripcionBodega";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "FechaInclusion";
            this.Column8.HeaderText = "FechaInclusion";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.13665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.86335F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.mskCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mskPrecio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mskCantidad, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.pbImagen, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.rdSi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbBodega, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbDocumentacion, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(210, 4);
            this.mskCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(207, 22);
            this.mskCodigo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(210, 34);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(210, 64);
            this.mskPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(207, 22);
            this.mskPrecio.TabIndex = 3;
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(210, 182);
            this.mskCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(207, 22);
            this.mskCantidad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Imagen";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Documentación";
            // 
            // pbImagen
            // 
            this.pbImagen.ContextMenuStrip = this.cmsImagen;
            this.pbImagen.Image = global::UTN.Winform.Electronics.Properties.Resources.camera_web_2;
            this.pbImagen.Location = new System.Drawing.Point(210, 212);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(208, 106);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 10;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // cmsImagen
            // 
            this.cmsImagen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsImagen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verImagenToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cmsImagen.Name = "cmsImagen";
            this.cmsImagen.Size = new System.Drawing.Size(154, 52);
            // 
            // verImagenToolStripMenuItem
            // 
            this.verImagenToolStripMenuItem.Name = "verImagenToolStripMenuItem";
            this.verImagenToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.verImagenToolStripMenuItem.Text = "Ver Imagen";
            this.verImagenToolStripMenuItem.Click += new System.EventHandler(this.verImagenToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Winform.Electronics.Properties.Resources.dialog_ok;
            this.btnAceptar.Location = new System.Drawing.Point(4, 430);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(198, 84);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UTN.Winform.Electronics.Properties.Resources.dialog_cancel_4;
            this.btnCancelar.Location = new System.Drawing.Point(210, 430);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 84);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdSi
            // 
            this.rdSi.AutoSize = true;
            this.rdSi.Location = new System.Drawing.Point(210, 154);
            this.rdSi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSi.Name = "rdSi";
            this.rdSi.Size = new System.Drawing.Size(40, 20);
            this.rdSi.TabIndex = 13;
            this.rdSi.Text = "Si";
            this.rdSi.UseVisualStyleBackColor = true;
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(210, 94);
            this.cmbBodega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(207, 24);
            this.cmbBodega.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "No Bodega";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Garantía";
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Checked = true;
            this.rdNo.Location = new System.Drawing.Point(210, 126);
            this.rdNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(46, 20);
            this.rdNo.TabIndex = 16;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "No";
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // pbDocumentacion
            // 
            this.pbDocumentacion.ContextMenuStrip = this.cmsDocumento;
            this.pbDocumentacion.Image = ((System.Drawing.Image)(resources.GetObject("pbDocumentacion.Image")));
            this.pbDocumentacion.Location = new System.Drawing.Point(210, 326);
            this.pbDocumentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDocumentacion.Name = "pbDocumentacion";
            this.pbDocumentacion.Size = new System.Drawing.Size(208, 96);
            this.pbDocumentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDocumentacion.TabIndex = 11;
            this.pbDocumentacion.TabStop = false;
            this.pbDocumentacion.Click += new System.EventHandler(this.pbDocumentacion_Click);
            // 
            // cmsDocumento
            // 
            this.cmsDocumento.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDocumento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDocumentoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.cmsDocumento.Name = "cmsDocumento";
            this.cmsDocumento.Size = new System.Drawing.Size(182, 52);
            // 
            // verDocumentoToolStripMenuItem
            // 
            this.verDocumentoToolStripMenuItem.Name = "verDocumentoToolStripMenuItem";
            this.verDocumentoToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.verDocumentoToolStripMenuItem.Text = "Ver Documento";
            this.verDocumentoToolStripMenuItem.Click += new System.EventHandler(this.verDocumentoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // frmMantenimientoElectronico
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1360, 658);
            this.Controls.Add(this.spcContenedor);
            this.Controls.Add(this.sttInferior);
            this.Controls.Add(this.tspPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoElectronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                 ";
            this.Load += new System.EventHandler(this.frmMantenimientoElectronico_Load);
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.spcContenedor.Panel1.ResumeLayout(false);
            this.spcContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).EndInit();
            this.spcContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.cmsImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumentacion)).EndInit();
            this.cmsDocumento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.StatusStrip sttInferior;
        private System.Windows.Forms.SplitContainer spcContenedor;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnEditar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbDocumentacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdSi;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.ContextMenuStrip cmsImagen;
        private System.Windows.Forms.ToolStripMenuItem verImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDocumento;
        private System.Windows.Forms.ToolStripMenuItem verDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}