using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.UI.Reportes
{
    public partial class frmGraficoVenta : Form
    {
        private static readonly ILog _myLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmGraficoVenta()
        {
            InitializeComponent();
        }
        private void frmGraficoVenta_Load(object sender, EventArgs e)
        {
            this.cmbTipoGrafico.Items.Add("Column");
            this.cmbTipoGrafico.Items.Add("Line");
            this.cmbTipoGrafico.Items.Add("Bar");
            this.cmbTipoGrafico.Items.Add("Pie");
            this.cmbTipoGrafico.Items.Add("Doughnut");
            this.cmbTipoGrafico.Items.Add("Area");
            this.cmbTipoGrafico.Items.Add("Spline");
            this.cmbTipoGrafico.SelectedIndex = 0;
        }


        private async void btnGrafico_Click(object sender, EventArgs e)
        {
            IBLLFactura bllFactura = new BLLFactura();
            try
            {
                 
                IEnumerable<VentasDTO> lista = await bllFactura.GetTotalVentasXFecha(dtpFechaInicial.Value, dtpFechaFinal.Value);
                            
               
                // Se asigna la lista al DataSource del Chart
                chartVentas.DataSource = lista ;

                // Anno y TotalVenta son properties de la clase  VentasDTO de esta forma se mapea 
                // en el Chart
                chartVentas.Series["Series1"].XValueMember = "Anno";
                chartVentas.Series["Series1"].YValueMembers = "TotalVenta";

                // Colocar el Titulo
                chartVentas.Titles.Clear();
                chartVentas.Titles.Add("Total Ventas");
                chartVentas.Titles[0].Font= new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));  

                //Mostrar Labels
                chartVentas.Series["Series1"].IsValueShownAsLabel = true;
                // Formato CultureInfo en los valores numéricos
                chartVentas.Series["Series1"].LabelFormat = "C2";

                // Se escoge el tipo de Gráfico
                if (cmbTipoGrafico.SelectedIndex == 0)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Column;

                if (cmbTipoGrafico.SelectedIndex == 1)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Line;
                if (cmbTipoGrafico.SelectedIndex == 2)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Bar;
                if (cmbTipoGrafico.SelectedIndex == 3)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Pie;
                if (cmbTipoGrafico.SelectedIndex == 4)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Doughnut;
                if (cmbTipoGrafico.SelectedIndex == 5)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Area;
                if (cmbTipoGrafico.SelectedIndex == 6)
                    chartVentas.Series["Series1"].ChartType = SeriesChartType.Spline;
                 


            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Seleccione el Directorio";
            dialog.FileName = "GraficoVentas.png";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                chartVentas.SaveImage(dialog.FileName, ChartImageFormat.Png);
            }         


        }
    }
}
