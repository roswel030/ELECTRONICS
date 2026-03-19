using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.UI.Mantenimientos
{
    public partial class frmMantenimientoCliente : Form
    {

        private static readonly ILog _myLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoCliente()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void frmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
         

        /// <summary>
        /// Cambia el estado del proceso
        /// </summary>
        /// <param name="estado">Enum del proceso</param>
        private void ChangeState(EstadoMantenimiento estado)
        {
            erp.Clear();
            this.txtIdCliente.Clear();
            this.txtNombre.Clear();
            this.txtApellido1.Clear();
            this.txtApellido2.Clear();
            this.txtEmail.Clear();
            this.txtIdCliente.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtEmail.Enabled = false;

            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnBuscarCliente.Enabled = false; 
            this.cmbProvincia.Enabled = false;

            // Coloca el primer item por defecto
            if (cmbProvincia.Items.Count > 0)
                this.cmbProvincia.SelectedIndex = 0;

            switch (estado)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtIdCliente.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtEmail.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.btnBuscarCliente.Enabled = true;
                    txtIdCliente.Focus();
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtIdCliente.Enabled = false;
                    this.txtNombre.Enabled = true;
                    this.txtApellido1.Enabled = true;
                    this.txtApellido2.Enabled = true;
                    this.txtEmail.Enabled = true;
                    this.cmbProvincia.Enabled = true;
                    this.btnAceptar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    txtNombre.Focus();
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

        private async void LoadData()
        {
            IBLLCliente bllCliente = new BLLCliente();
            IBLLProvincia bllProvincia = new BLLProvincia();
            List<Provincia> lista = null;
            try
            {             
              
                // Cambiar el estado
                this.ChangeState(EstadoMantenimiento.Ninguno);

                // Configuracion del DataGridView para que se vea bien la imagen.
                dgvDatos.AutoGenerateColumns = false;
                // dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                // Delay forzado
                await Task.Delay(500);

                // Cargar el DataGridView
                this.dgvDatos.DataSource = await bllCliente.GetAll();

                // Cargar el combo
                this.cmbProvincia.Items.Clear();
                lista = bllProvincia.GetAll();
                foreach (Provincia oProvincia in lista)
                {
                    this.cmbProvincia.Items.Add(oProvincia);
                }
                // Colocar el primero como default
                this.cmbProvincia.SelectedIndex = 0; 
            }            
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            this.ChangeState(EstadoMantenimiento.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ChangeState(EstadoMantenimiento.Ninguno);
        }


        ErrorProvider erp = new ErrorProvider();
        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLCliente bllCliente = new BLLCliente();
            erp = new ErrorProvider();
            try
            {
                erp.Clear();
                Cliente oCliente = new Cliente();

                if (string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    erp.SetError(txtIdCliente, "Id Requerido");
                    txtIdCliente.Focus();
                    return;
                }

                oCliente.IdCliente = this.txtIdCliente.Text;
                oCliente.Nombre = this.txtNombre.Text;
                oCliente.Apellido1 = this.txtApellido1.Text;
                oCliente.Apellido2 = this.txtApellido2.Text;
                oCliente.Email= this.txtEmail.Text;
                oCliente.FechaNacimiento = dtpFechaNacimiento.Value;
                oCliente.IdProvincia = (cmbProvincia.SelectedItem as Provincia).IdProvincia;
                oCliente.Sexo = rdbFemenino.Checked ? 2 : 1;

                oCliente = await bllCliente.Save(oCliente);

                if (oCliente != null)
                    this.LoadData();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            IBLLCliente bllCliente = new BLLCliente();
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.ChangeState(EstadoMantenimiento.Borrar);

                    Cliente oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oCliente.IdCliente.Trim()} {oCliente.Nombre.Trim()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await bllCliente.Delete(oCliente.IdCliente);
                        this.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripBtnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = null;
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // Cambiar de estado
                    this.ChangeState(EstadoMantenimiento.Editar);
                    oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                    this.txtIdCliente.Text = oCliente.IdCliente;
                    this.txtApellido1.Text = oCliente.Apellido1;
                    this.txtApellido2.Text = oCliente.Apellido2;
                    this.txtEmail.Text = oCliente.Email;
                    this.txtNombre.Text = oCliente.Nombre;
                    this.rdbFemenino.Checked = oCliente.Sexo == 2 ? true : false;
                    this.rdbMasculino.Checked = oCliente.Sexo == 1 ? true : false;
                    this.dtpFechaNacimiento.Value = oCliente.FechaNacimiento;
                    cmbProvincia.SelectedIndex = cmbProvincia.FindString(oCliente.IdProvincia.ToString());

                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tspPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
      
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            IBLLPadron bllPadron = new BLLPadron();
            try
            {
                erp.Clear();

                if (string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    erp.SetError(txtIdCliente, "Id Requerido");
                    txtIdCliente.Focus();
                    return;
                }

                if (txtIdCliente.Text.Trim().Length != 9)
                {
                    erp.SetError(txtIdCliente, "Largo de la Cédula 9 digitos");
                    txtIdCliente.Focus();
                    return;
                }

                
                // ToDo: Cree La validación que solo permita números en la cédula 

                PadronDTO oPadronDTO = bllPadron.GetById(txtIdCliente.Text.Trim());


                string[] array = oPadronDTO.nombre.Split(' ');

                // 1 nombres y dos apellidos
                if (array.Length == 3)
                {
                    txtNombre.Text = array[0];
                    txtApellido1.Text = array[1];
                    txtApellido2.Text = array[2];
                }

                // 2 nombres y dos apellidos
                if (array.Length == 4)
                {
                    txtNombre.Text = array[0] + " " + array[1];
                    txtApellido1.Text = array[2];
                    txtApellido2.Text = array[3];
                }

                // Ejemplo con varios nombres. 203960070 - ANTONIO MARIA DE LA TRINIDAD RODRIGUEZ CHAVES 
                // 2 nombres y dos apellidos
                // Nota: No se valida apellidos compuestos por ejemplo Maria de la O
                if (array.Length > 4)
                {
                    txtNombre.Text = array[0] + " " + array[1];
                    txtApellido1.Text = array[array.Length-2];
                    txtApellido2.Text = array[array.Length-1];
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
