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
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.UI.Filtros
{
    public partial class frmFiltroElectronico : Form
    {
        private static readonly ILog _myLogControlEventos =
         log4net.LogManager.GetLogger("MyControlEventos");

        public Electronico Electronico { get; private set; } = null;

        public frmFiltroElectronico()
        {
            InitializeComponent();
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.txtFiltro.Clear();
            this.dgvDatos.DataSource = null;
            txtFiltro.Focus();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            IBLLElectronico bllElectronico = new BLLElectronico();
            string filtro = string.Empty;
            
            try
            {
                filtro = this.txtFiltro.Text;
                filtro = filtro.Replace(' ', '%');
                filtro = "%" + filtro + "%";
                this.dgvDatos.AutoGenerateColumns = false;
                this.dgvDatos.DataSource = bllElectronico.GetByFilter(filtro);

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmFiltroElectronico_Load(object sender, EventArgs e)
        {
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.RowTemplate.Height = 60;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount > 0 && dgvDatos.SelectedRows.Count > 0)
                {
                    if (dgvDatos.CurrentCell.Selected)
                    {
                        Electronico = dgvDatos.SelectedRows[0].DataBoundItem as Electronico;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }
    }
}
