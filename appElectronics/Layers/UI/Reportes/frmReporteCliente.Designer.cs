namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    partial class frmReporteCliente
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rdbOrdenadoCedula = new System.Windows.Forms.RadioButton();
            this.rdbOrdenadoNombre = new System.Windows.Forms.RadioButton();
            this.grbOrdenamiento = new System.Windows.Forms.GroupBox();
            this.grbMostrar = new System.Windows.Forms.GroupBox();
            this.rdbPantalla = new System.Windows.Forms.RadioButton();
            this.rdbCorreo = new System.Windows.Forms.RadioButton();
            this.grbOrdenamiento.SuspendLayout();
            this.grbMostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.btnSalir.Location = new System.Drawing.Point(559, 106);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 95);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::UTN.Winform.Electronics.Properties.Resources.pdf_icon;
            this.btnReporte.Location = new System.Drawing.Point(419, 106);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(132, 95);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(28, 49);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(103, 16);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro por Cliente";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(210, 49);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(481, 22);
            this.txtFiltro.TabIndex = 6;
            // 
            // rdbOrdenadoCedula
            // 
            this.rdbOrdenadoCedula.AutoSize = true;
            this.rdbOrdenadoCedula.Checked = true;
            this.rdbOrdenadoCedula.Location = new System.Drawing.Point(19, 34);
            this.rdbOrdenadoCedula.Name = "rdbOrdenadoCedula";
            this.rdbOrdenadoCedula.Size = new System.Drawing.Size(158, 20);
            this.rdbOrdenadoCedula.TabIndex = 7;
            this.rdbOrdenadoCedula.TabStop = true;
            this.rdbOrdenadoCedula.Text = "Ordenado por Cédula";
            this.rdbOrdenadoCedula.UseVisualStyleBackColor = true;
            // 
            // rdbOrdenadoNombre
            // 
            this.rdbOrdenadoNombre.AutoSize = true;
            this.rdbOrdenadoNombre.Location = new System.Drawing.Point(19, 60);
            this.rdbOrdenadoNombre.Name = "rdbOrdenadoNombre";
            this.rdbOrdenadoNombre.Size = new System.Drawing.Size(164, 20);
            this.rdbOrdenadoNombre.TabIndex = 8;
            this.rdbOrdenadoNombre.TabStop = true;
            this.rdbOrdenadoNombre.Text = "Ordenado por Nombre";
            this.rdbOrdenadoNombre.UseVisualStyleBackColor = true;
            // 
            // grbOrdenamiento
            // 
            this.grbOrdenamiento.Controls.Add(this.rdbOrdenadoCedula);
            this.grbOrdenamiento.Controls.Add(this.rdbOrdenadoNombre);
            this.grbOrdenamiento.Location = new System.Drawing.Point(12, 106);
            this.grbOrdenamiento.Name = "grbOrdenamiento";
            this.grbOrdenamiento.Size = new System.Drawing.Size(200, 100);
            this.grbOrdenamiento.TabIndex = 9;
            this.grbOrdenamiento.TabStop = false;
            this.grbOrdenamiento.Text = "Ordenamiento";
            // 
            // grbMostrar
            // 
            this.grbMostrar.Controls.Add(this.rdbCorreo);
            this.grbMostrar.Controls.Add(this.rdbPantalla);
            this.grbMostrar.Location = new System.Drawing.Point(218, 106);
            this.grbMostrar.Name = "grbMostrar";
            this.grbMostrar.Size = new System.Drawing.Size(183, 100);
            this.grbMostrar.TabIndex = 10;
            this.grbMostrar.TabStop = false;
            this.grbMostrar.Text = "Mostrar";
            // 
            // rdbPantalla
            // 
            this.rdbPantalla.AutoSize = true;
            this.rdbPantalla.Checked = true;
            this.rdbPantalla.Location = new System.Drawing.Point(20, 32);
            this.rdbPantalla.Name = "rdbPantalla";
            this.rdbPantalla.Size = new System.Drawing.Size(77, 20);
            this.rdbPantalla.TabIndex = 0;
            this.rdbPantalla.TabStop = true;
            this.rdbPantalla.Text = "Pantalla";
            this.rdbPantalla.UseVisualStyleBackColor = true;
            // 
            // rdbCorreo
            // 
            this.rdbCorreo.AutoSize = true;
            this.rdbCorreo.Location = new System.Drawing.Point(20, 59);
            this.rdbCorreo.Name = "rdbCorreo";
            this.rdbCorreo.Size = new System.Drawing.Size(69, 20);
            this.rdbCorreo.TabIndex = 1;
            this.rdbCorreo.TabStop = true;
            this.rdbCorreo.Text = "Correo";
            this.rdbCorreo.UseVisualStyleBackColor = true;
            // 
            // frmReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 224);
            this.Controls.Add(this.grbMostrar);
            this.Controls.Add(this.grbOrdenamiento);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Name = "frmReporteCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cliente";
            this.grbOrdenamiento.ResumeLayout(false);
            this.grbOrdenamiento.PerformLayout();
            this.grbMostrar.ResumeLayout(false);
            this.grbMostrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rdbOrdenadoCedula;
        private System.Windows.Forms.RadioButton rdbOrdenadoNombre;
        private System.Windows.Forms.GroupBox grbOrdenamiento;
        private System.Windows.Forms.GroupBox grbMostrar;
        private System.Windows.Forms.RadioButton rdbCorreo;
        private System.Windows.Forms.RadioButton rdbPantalla;
    }
}