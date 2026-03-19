namespace UTN.Winform.Electronics.Layers.UI.Seguridad
{
    partial class frmSeguridad
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
            this.sttBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tspBarraPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalvarUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.spcContenedor = new System.Windows.Forms.SplitContainer();
            this.tplPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.trvUsuarios = new System.Windows.Forms.TreeView();
            this.cmdMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListaTreeView = new System.Windows.Forms.ImageList(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ntfMensaje = new System.Windows.Forms.NotifyIcon(this.components);
            this.tspBarraPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).BeginInit();
            this.spcContenedor.Panel1.SuspendLayout();
            this.spcContenedor.Panel2.SuspendLayout();
            this.spcContenedor.SuspendLayout();
            this.tplPanel.SuspendLayout();
            this.cmdMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // sttBarraInferior
            // 
            this.sttBarraInferior.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttBarraInferior.Location = new System.Drawing.Point(0, 408);
            this.sttBarraInferior.Name = "sttBarraInferior";
            this.sttBarraInferior.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sttBarraInferior.Size = new System.Drawing.Size(900, 22);
            this.sttBarraInferior.TabIndex = 0;
            this.sttBarraInferior.Text = "statusStrip1";
            // 
            // tspBarraPrincipal
            // 
            this.tspBarraPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspBarraPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnSalvarUsuario,
            this.toolStripBtnSalir});
            this.tspBarraPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tspBarraPrincipal.Name = "tspBarraPrincipal";
            this.tspBarraPrincipal.Size = new System.Drawing.Size(900, 55);
            this.tspBarraPrincipal.TabIndex = 1;
            this.tspBarraPrincipal.Text = "toolStrip1";
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
            // toolStripBtnSalvarUsuario
            // 
            this.toolStripBtnSalvarUsuario.Image = global::UTN.Winform.Electronics.Properties.Resources.user_new_3;
            this.toolStripBtnSalvarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalvarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalvarUsuario.Name = "toolStripBtnSalvarUsuario";
            this.toolStripBtnSalvarUsuario.Size = new System.Drawing.Size(101, 52);
            this.toolStripBtnSalvarUsuario.Text = "&Salvar";
            this.toolStripBtnSalvarUsuario.Click += new System.EventHandler(this.toolStripBtnSalvarUsuario_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(90, 52);
            this.toolStripBtnSalir.Text = "Sa&lir";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // spcContenedor
            // 
            this.spcContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContenedor.Location = new System.Drawing.Point(0, 55);
            this.spcContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.spcContenedor.Name = "spcContenedor";
            // 
            // spcContenedor.Panel1
            // 
            this.spcContenedor.Panel1.Controls.Add(this.tplPanel);
            // 
            // spcContenedor.Panel2
            // 
            this.spcContenedor.Panel2.Controls.Add(this.trvUsuarios);
            this.spcContenedor.Size = new System.Drawing.Size(900, 353);
            this.spcContenedor.SplitterDistance = 376;
            this.spcContenedor.SplitterWidth = 5;
            this.spcContenedor.TabIndex = 2;
            // 
            // tplPanel
            // 
            this.tplPanel.ColumnCount = 2;
            this.tplPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tplPanel.Controls.Add(this.lblLogin, 0, 0);
            this.tplPanel.Controls.Add(this.txtLogin, 1, 0);
            this.tplPanel.Controls.Add(this.txtNombre, 1, 1);
            this.tplPanel.Controls.Add(this.lblNombre, 0, 1);
            this.tplPanel.Controls.Add(this.lblContrasena, 0, 2);
            this.tplPanel.Controls.Add(this.txtPassword, 1, 2);
            this.tplPanel.Controls.Add(this.lblRol, 0, 3);
            this.tplPanel.Controls.Add(this.cmbRol, 1, 3);
            this.tplPanel.Location = new System.Drawing.Point(13, 30);
            this.tplPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tplPanel.Name = "tplPanel";
            this.tplPanel.RowCount = 4;
            this.tplPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplPanel.Size = new System.Drawing.Size(345, 158);
            this.tplPanel.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(4, 6);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(81, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(93, 4);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(253, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(93, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 36);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 17);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(4, 66);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 17);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contrasena";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(93, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(253, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(4, 115);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(81, 17);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            this.cmbRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(93, 111);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(253, 24);
            this.cmbRol.TabIndex = 4;
            // 
            // trvUsuarios
            // 
            this.trvUsuarios.ContextMenuStrip = this.cmdMenu;
            this.trvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvUsuarios.ImageIndex = 0;
            this.trvUsuarios.ImageList = this.imgListaTreeView;
            this.trvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.trvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.trvUsuarios.Name = "trvUsuarios";
            this.trvUsuarios.SelectedImageIndex = 0;
            this.trvUsuarios.Size = new System.Drawing.Size(515, 349);
            this.trvUsuarios.TabIndex = 5;
            this.trvUsuarios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvUsuarios_AfterSelect);
            // 
            // cmdMenu
            // 
            this.cmdMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmdMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.Size = new System.Drawing.Size(120, 52);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // imgListaTreeView
            // 
            this.imgListaTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListaTreeView.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListaTreeView.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.spcContenedor);
            this.Controls.Add(this.tspBarraPrincipal);
            this.Controls.Add(this.sttBarraInferior);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.Load += new System.EventHandler(this.frmSeguridad_Load);
            this.tspBarraPrincipal.ResumeLayout(false);
            this.tspBarraPrincipal.PerformLayout();
            this.spcContenedor.Panel1.ResumeLayout(false);
            this.spcContenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContenedor)).EndInit();
            this.spcContenedor.ResumeLayout(false);
            this.tplPanel.ResumeLayout(false);
            this.tplPanel.PerformLayout();
            this.cmdMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttBarraInferior;
        private System.Windows.Forms.ToolStrip tspBarraPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalvarUsuario;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer spcContenedor;
        private System.Windows.Forms.TableLayoutPanel tplPanel;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TreeView trvUsuarios;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ImageList imgListaTreeView;
        private System.Windows.Forms.NotifyIcon ntfMensaje;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip cmdMenu;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}