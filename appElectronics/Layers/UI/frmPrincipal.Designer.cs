namespace UTN.Winform.Electronics.Layers.UI
{
    partial class frmPrincipal
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
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.mspMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItemFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.anularFacturaToolStripMenuItemAnularFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreToolStripMenuItemCierre = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.electronicoToolStripMenuItemElectronico = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItemfacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoToolStripMenuItemGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaElectronicoToolStripMenuItemVentaElectronico = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttBarraInferior.SuspendLayout();
            this.mspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblMensaje});
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 339);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Size = new System.Drawing.Size(666, 22);
            this.sttBarraInferior.TabIndex = 0;
            // 
            // toolStripStatusLblMensaje
            // 
            this.toolStripStatusLblMensaje.Name = "toolStripStatusLblMensaje";
            this.toolStripStatusLblMensaje.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLblMensaje.Text = "-";
            // 
            // mspMenuPrincipal
            // 
            this.mspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMantenimientos,
            this.toolStripMenuItemProcesos,
            this.reportesToolStripMenuItemReportes,
            this.administracionToolStripMenuItem,
            this.toolStripMenuItemAcercaDe});
            this.mspMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mspMenuPrincipal.Name = "mspMenuPrincipal";
            this.mspMenuPrincipal.Size = new System.Drawing.Size(666, 56);
            this.mspMenuPrincipal.TabIndex = 1;
            this.mspMenuPrincipal.Text = "menuStrip1";
            this.mspMenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mspMenuPrincipal_ItemClicked);
            // 
            // toolStripMenuItemMantenimientos
            // 
            this.toolStripMenuItemMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItemCliente,
            this.productosToolStripMenuItemProductos,
            this.tarjetasToolStripMenuItem,
            this.provinciasToolStripMenuItem,
            this.bodegasToolStripMenuItem});
            this.toolStripMenuItemMantenimientos.Image = global::UTN.Winform.Electronics.Properties.Resources.preferences_system;
            this.toolStripMenuItemMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemMantenimientos.Name = "toolStripMenuItemMantenimientos";
            this.toolStripMenuItemMantenimientos.Size = new System.Drawing.Size(154, 52);
            this.toolStripMenuItemMantenimientos.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItemCliente
            // 
            this.clientesToolStripMenuItemCliente.Image = global::UTN.Winform.Electronics.Properties.Resources.system_switch_user;
            this.clientesToolStripMenuItemCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItemCliente.Name = "clientesToolStripMenuItemCliente";
            this.clientesToolStripMenuItemCliente.Size = new System.Drawing.Size(162, 54);
            this.clientesToolStripMenuItemCliente.Text = "Clientes";
            this.clientesToolStripMenuItemCliente.Click += new System.EventHandler(this.clientesToolStripMenuItemCliente_Click);
            // 
            // productosToolStripMenuItemProductos
            // 
            this.productosToolStripMenuItemProductos.Image = global::UTN.Winform.Electronics.Properties.Resources.audio_card_3;
            this.productosToolStripMenuItemProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItemProductos.Name = "productosToolStripMenuItemProductos";
            this.productosToolStripMenuItemProductos.Size = new System.Drawing.Size(162, 54);
            this.productosToolStripMenuItemProductos.Text = "Productos";
            this.productosToolStripMenuItemProductos.Click += new System.EventHandler(this.productosToolStripMenuItemProductos_Click);
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.Image = global::UTN.Winform.Electronics.Properties.Resources.mastercard;
            this.tarjetasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            this.tarjetasToolStripMenuItem.Click += new System.EventHandler(this.tarjetasToolStripMenuItem_Click);
            // 
            // provinciasToolStripMenuItem
            // 
            this.provinciasToolStripMenuItem.Image = global::UTN.Winform.Electronics.Properties.Resources.map_compass;
            this.provinciasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
            this.provinciasToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.provinciasToolStripMenuItem.Text = "Provincias";
            this.provinciasToolStripMenuItem.Click += new System.EventHandler(this.provinciasToolStripMenuItem_Click);
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.Image = global::UTN.Winform.Electronics.Properties.Resources.d3lphin;
            this.bodegasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            this.bodegasToolStripMenuItem.Click += new System.EventHandler(this.bodegasToolStripMenuItem_Click);
            // 
            // toolStripMenuItemProcesos
            // 
            this.toolStripMenuItemProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItemFacturar,
            this.anularFacturaToolStripMenuItemAnularFactura,
            this.cierreToolStripMenuItemCierre});
            this.toolStripMenuItemProcesos.Image = global::UTN.Winform.Electronics.Properties.Resources.run_build_2;
            this.toolStripMenuItemProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemProcesos.Name = "toolStripMenuItemProcesos";
            this.toolStripMenuItemProcesos.Size = new System.Drawing.Size(114, 52);
            this.toolStripMenuItemProcesos.Text = "Procesos";
            // 
            // facturarToolStripMenuItemFacturar
            // 
            this.facturarToolStripMenuItemFacturar.Image = global::UTN.Winform.Electronics.Properties.Resources.accessories_calculator_3;
            this.facturarToolStripMenuItemFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturarToolStripMenuItemFacturar.Name = "facturarToolStripMenuItemFacturar";
            this.facturarToolStripMenuItemFacturar.Size = new System.Drawing.Size(183, 54);
            this.facturarToolStripMenuItemFacturar.Text = "Facturar";
            this.facturarToolStripMenuItemFacturar.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // anularFacturaToolStripMenuItemAnularFactura
            // 
            this.anularFacturaToolStripMenuItemAnularFactura.Image = global::UTN.Winform.Electronics.Properties.Resources.draw_eraser;
            this.anularFacturaToolStripMenuItemAnularFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anularFacturaToolStripMenuItemAnularFactura.Name = "anularFacturaToolStripMenuItemAnularFactura";
            this.anularFacturaToolStripMenuItemAnularFactura.Size = new System.Drawing.Size(183, 54);
            this.anularFacturaToolStripMenuItemAnularFactura.Text = "Anular Factura";
            this.anularFacturaToolStripMenuItemAnularFactura.Click += new System.EventHandler(this.anularFacturaToolStripMenuItemAnularFactura_Click);
            // 
            // cierreToolStripMenuItemCierre
            // 
            this.cierreToolStripMenuItemCierre.Image = global::UTN.Winform.Electronics.Properties.Resources.emblem_advertisement_dollar;
            this.cierreToolStripMenuItemCierre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cierreToolStripMenuItemCierre.Name = "cierreToolStripMenuItemCierre";
            this.cierreToolStripMenuItemCierre.Size = new System.Drawing.Size(183, 54);
            this.cierreToolStripMenuItemCierre.Text = "Cierre";
            this.cierreToolStripMenuItemCierre.Click += new System.EventHandler(this.cierreToolStripMenuItemCierre_Click);
            // 
            // reportesToolStripMenuItemReportes
            // 
            this.reportesToolStripMenuItemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electronicoToolStripMenuItemElectronico,
            this.clientesToolStripMenuItemClientes,
            this.facturaciónToolStripMenuItemfacturacion,
            this.gráficoToolStripMenuItemGraficos});
            this.reportesToolStripMenuItemReportes.Image = global::UTN.Winform.Electronics.Properties.Resources.document_print_2;
            this.reportesToolStripMenuItemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItemReportes.Name = "reportesToolStripMenuItemReportes";
            this.reportesToolStripMenuItemReportes.Size = new System.Drawing.Size(113, 52);
            this.reportesToolStripMenuItemReportes.Text = "Reportes";
            // 
            // electronicoToolStripMenuItemElectronico
            // 
            this.electronicoToolStripMenuItemElectronico.Image = global::UTN.Winform.Electronics.Properties.Resources.audio_card_3;
            this.electronicoToolStripMenuItemElectronico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.electronicoToolStripMenuItemElectronico.Name = "electronicoToolStripMenuItemElectronico";
            this.electronicoToolStripMenuItemElectronico.Size = new System.Drawing.Size(212, 54);
            this.electronicoToolStripMenuItemElectronico.Text = "Electronico";
            this.electronicoToolStripMenuItemElectronico.Click += new System.EventHandler(this.electronicoToolStripMenuItemElectronico_Click);
            // 
            // clientesToolStripMenuItemClientes
            // 
            this.clientesToolStripMenuItemClientes.Image = global::UTN.Winform.Electronics.Properties.Resources.system_switch_user;
            this.clientesToolStripMenuItemClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItemClientes.Name = "clientesToolStripMenuItemClientes";
            this.clientesToolStripMenuItemClientes.Size = new System.Drawing.Size(212, 54);
            this.clientesToolStripMenuItemClientes.Text = "Clientes";
            this.clientesToolStripMenuItemClientes.Click += new System.EventHandler(this.clientesToolStripMenuItemClientes_Click);
            // 
            // facturaciónToolStripMenuItemfacturacion
            // 
            this.facturaciónToolStripMenuItemfacturacion.Image = global::UTN.Winform.Electronics.Properties.Resources.accessories_calculator_3;
            this.facturaciónToolStripMenuItemfacturacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaciónToolStripMenuItemfacturacion.Name = "facturaciónToolStripMenuItemfacturacion";
            this.facturaciónToolStripMenuItemfacturacion.Size = new System.Drawing.Size(212, 54);
            this.facturaciónToolStripMenuItemfacturacion.Text = "Facturación";
            this.facturaciónToolStripMenuItemfacturacion.Click += new System.EventHandler(this.facturaciónToolStripMenuItemfacturacion_Click);
            // 
            // gráficoToolStripMenuItemGraficos
            // 
            this.gráficoToolStripMenuItemGraficos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaElectronicoToolStripMenuItemVentaElectronico,
            this.productosToolStripMenuItem});
            this.gráficoToolStripMenuItemGraficos.Image = global::UTN.Winform.Electronics.Properties.Resources.office_chart_pie;
            this.gráficoToolStripMenuItemGraficos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gráficoToolStripMenuItemGraficos.Name = "gráficoToolStripMenuItemGraficos";
            this.gráficoToolStripMenuItemGraficos.Size = new System.Drawing.Size(212, 54);
            this.gráficoToolStripMenuItemGraficos.Text = "Gráfico";
            // 
            // ventaElectronicoToolStripMenuItemVentaElectronico
            // 
            this.ventaElectronicoToolStripMenuItemVentaElectronico.Image = global::UTN.Winform.Electronics.Properties.Resources.x_office_spreadsheet;
            this.ventaElectronicoToolStripMenuItemVentaElectronico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventaElectronicoToolStripMenuItemVentaElectronico.Name = "ventaElectronicoToolStripMenuItemVentaElectronico";
            this.ventaElectronicoToolStripMenuItemVentaElectronico.Size = new System.Drawing.Size(212, 54);
            this.ventaElectronicoToolStripMenuItemVentaElectronico.Text = "Venta Electronico";
            this.ventaElectronicoToolStripMenuItemVentaElectronico.Click += new System.EventHandler(this.ventaElectronicoToolStripMenuItemVentaElectronico_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItemUsuarios});
            this.administracionToolStripMenuItem.Image = global::UTN.Winform.Electronics.Properties.Resources.system_settings;
            this.administracionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(148, 52);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItemUsuarios
            // 
            this.usuariosToolStripMenuItemUsuarios.Image = global::UTN.Winform.Electronics.Properties.Resources.user_group_properties;
            this.usuariosToolStripMenuItemUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItemUsuarios.Name = "usuariosToolStripMenuItemUsuarios";
            this.usuariosToolStripMenuItemUsuarios.Size = new System.Drawing.Size(151, 54);
            this.usuariosToolStripMenuItemUsuarios.Text = "Usuarios";
            this.usuariosToolStripMenuItemUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItemUsuarios_Click);
            // 
            // toolStripMenuItemAcercaDe
            // 
            this.toolStripMenuItemAcercaDe.Image = global::UTN.Winform.Electronics.Properties.Resources.emblem_question;
            this.toolStripMenuItemAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemAcercaDe.Name = "toolStripMenuItemAcercaDe";
            this.toolStripMenuItemAcercaDe.Size = new System.Drawing.Size(60, 52);
            this.toolStripMenuItemAcercaDe.Click += new System.EventHandler(this.toolStripMenuItemAcercaDe_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::UTN.Winform.Electronics.Properties.Resources.office_chart_area;
            this.productosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UTN.Winform.Electronics.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(666, 361);
            this.Controls.Add(this.sttBarraInferior);
            this.Controls.Add(this.mspMenuPrincipal);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMenuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sttBarraInferior.ResumeLayout(false);
            this.sttBarraInferior.PerformLayout();
            this.mspMenuPrincipal.ResumeLayout(false);
            this.mspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.MenuStrip mspMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItemCliente;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProcesos;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItemFacturar;
        private System.Windows.Forms.ToolStripMenuItem anularFacturaToolStripMenuItemAnularFactura;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItemReportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem cierreToolStripMenuItemCierre;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItemfacturacion;
        private System.Windows.Forms.ToolStripMenuItem gráficoToolStripMenuItemGraficos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem electronicoToolStripMenuItemElectronico;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ventaElectronicoToolStripMenuItemVentaElectronico;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblMensaje;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}