using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Layers.UI.Mantenimientos;
using UTN.Winform.Electronics.Layers.UI.Procesos;
using UTN.Winform.Electronics.Layers.UI.Reportes;
using UTN.Winform.Electronics.Layers.UI.Seguridad;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.UI
{
    /// <summary>
    /// UTN: Fines Educativos está incompleta para agregarle funcionalidades, validaciones, errores de programación entre otros.
    /// Desarrollado por Anthony Morera
    /// 2018: Primera versión
    /// 2020: Métodos Async
    /// 2023: QuestPDF para Reportes
    ///       Extention Methods para Exceptions
    /// 2024: Rename variables _IDAL, _IBLL por dalXxx bllYyyy      
    /// </summary>

    public partial class frmPrincipal : Form
    {
        private static readonly ILog _myLogControlEventos =
           log4net.LogManager.GetLogger("MyControlEventos");

        public frmPrincipal()
        {
            InitializeComponent();
        }
          
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            
            try
            {
                
                Utils.CultureInfo();
                this.Text = ConfigurationManager.AppSettings["NombreEmpresa"] + " " + Application.ProductName + " Versión:  " + Application.ProductVersion;

                toolStripStatusLblMensaje.Text = "Usuario Conectado: " + Settings.Default.Login + "/" + Settings.Default.Nombre;

                if (!Directory.Exists(@"C:\temp"))
                    Directory.CreateDirectory(@"C:\temp");

                _myLogControlEventos.InfoFormat("Conectado a Form Principal");

               

                // Activar Seguridad
                Seguridad();

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItemProductos_Click(object sender, EventArgs e)
        {
            frmMantenimientoElectronico oForm;
            try
            {
                oForm = new frmMantenimientoElectronico();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion oForm;
            try
            {
                oForm = new frmFacturacion();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItemAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercade oForm;
            try
            {
                oForm = new frmAcercade();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientesToolStripMenuItemCliente_Click(object sender, EventArgs e)
        {
            frmMantenimientoCliente oForm;

            try
            {
                oForm = new frmMantenimientoCliente();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anularFacturaToolStripMenuItemAnularFactura_Click(object sender, EventArgs e)

        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void clientesToolStripMenuItemClientes_Click(object sender, EventArgs e)
        {
            frmReporteCliente oForm;

            try
            {
                oForm = new frmReporteCliente();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void electronicoToolStripMenuItemElectronico_Click(object sender, EventArgs e)
        {
            frmReporteElectronico oForm;
            try
            {
                oForm = new frmReporteElectronico();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventaElectronicoToolStripMenuItemVentaElectronico_Click(object sender, EventArgs e)
        {
            frmGraficoVenta oForm;
            try
            {
                oForm = new frmGraficoVenta();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventaPorClienteToolStripMenuItemVentaXCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void facturaciónToolStripMenuItemfacturacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cierreToolStripMenuItemCierre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usuariosToolStripMenuItemUsuarios_Click(object sender, EventArgs e)
        {
            frmSeguridad oForm;
            try
            {
                oForm = new frmSeguridad();
                oForm.MdiParent = this;
                oForm.Show();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que habilita y deshabilita opciones del MENU
        /// </summary>
        private void Seguridad()
        {
            List<string> menus = new List<string>();

            // Se deshabilita TODO primero
            foreach (ToolStripItem opcionMenu in this.mspMenuPrincipal.Items) //para cada opción de la barra de menú
            {
                // deshabita todos !
                ((ToolStripItem)(opcionMenu)).Enabled = false;
            }

            // Tabla Rol
            // IdRol DescripcionRol
            // 1   Administrador
            // 2   Vendedor
            // 3   Reportes
            // Siempre permitir el MENU Acercade  
            menus.Add("toolStripMenuItemAcercaDe");

            // Admin
            if (Settings.Default.RolId.Equals("1"))
            {
                menus.Add("toolStripMenuItemMantenimientos");
                menus.Add("toolStripMenuItemProcesos");
                menus.Add("reportesToolStripMenuItemReportes");
                menus.Add("administracionToolStripMenuItem");
            }

            // Vendedor
            if (Settings.Default.RolId.Equals("2"))
            {
                menus.Add("toolStripMenuItemMantenimientos");
                menus.Add("toolStripMenuItemProcesos");
            }

            // Reportes
            if (Settings.Default.RolId.Equals("3"))
            {
                menus.Add("reportesToolStripMenuItemReportes");
            }


            foreach (ToolStripItem opcionMenu in this.mspMenuPrincipal.Items) //para cada opción de la barra de menú
            {
                if (opcionMenu is ToolStripDropDownButton)
                {
                    foreach (ToolStripMenuItem oToolStripMenuItem in ((ToolStripDropDownButton)opcionMenu).DropDownItems)
                    {
                        oToolStripMenuItem.Enabled = menus.Exists(p => p.Equals(oToolStripMenuItem.Name, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
                // Habilita solo las opciones que se encuentrna en la lista "menu"
                opcionMenu.Enabled = menus.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
            }

        }

        private void tarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _myLogControlEventos.InfoFormat("Salida del Sistema :{0}", Settings.Default.Login);
        }

        private void mspMenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ud debe desarrollarlo !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
