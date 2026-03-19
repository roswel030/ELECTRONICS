namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    partial class frmGraficoVenta
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentas.Legends.Add(legend1);
            this.chartVentas.Location = new System.Drawing.Point(16, 32);
            this.chartVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVentas.Series.Add(series1);
            this.chartVentas.Size = new System.Drawing.Size(1083, 446);
            this.chartVentas.TabIndex = 0;
            this.chartVentas.Text = "Ventas";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Winform.Electronics.Properties.Resources.window_close_2;
            this.btnSalir.Location = new System.Drawing.Point(971, 485);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 85);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Image = global::UTN.Winform.Electronics.Properties.Resources.office_chart_area;
            this.btnGrafico.Location = new System.Drawing.Point(697, 485);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(128, 85);
            this.btnGrafico.TabIndex = 3;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Location = new System.Drawing.Point(20, 535);
            this.cmbTipoGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(188, 24);
            this.cmbTipoGrafico.TabIndex = 5;
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Location = new System.Drawing.Point(16, 506);
            this.lblTipoGrafico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(81, 16);
            this.lblTipoGrafico.TabIndex = 6;
            this.lblTipoGrafico.Text = "Tipo Grafico";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::UTN.Winform.Electronics.Properties.Resources.document_save_all;
            this.btnSalvar.Location = new System.Drawing.Point(833, 485);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 85);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Exportar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(392, 496);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaInicial.TabIndex = 8;
            this.dtpFechaInicial.Value = new System.DateTime(2000, 6, 23, 11, 31, 0, 0);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(389, 538);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFinal.TabIndex = 9;
            this.dtpFechaFinal.Value = new System.DateTime(2035, 6, 23, 11, 31, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Final";
            // 
            // frmGraficoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.cmbTipoGrafico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.chartVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGraficoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico Ventas";
            this.Load += new System.EventHandler(this.frmGraficoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
        private System.Windows.Forms.Label lblTipoGrafico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}