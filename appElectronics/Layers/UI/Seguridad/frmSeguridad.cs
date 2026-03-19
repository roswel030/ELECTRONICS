using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.UI.Seguridad
{
    public partial class frmSeguridad : Form
    {
        private static readonly ILog _myLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmSeguridad()
        {
            InitializeComponent();
        }


        private void toolStripBtnSalvarUsuario_Click(object sender, EventArgs e)
        {

            IBLLUsuario bllUsuario = new BLLUsuario();
            try
            {
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    epError.SetError(txtLogin, "Usuario  Requerido");
                    txtLogin.Focus();
                    return;
                }

                // Validar datos requeridos 
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    epError.SetError(txtPassword, "Contrasena Requerida");
                    txtPassword.Focus();
                    return;
                }

                Usuario oUsuario = new Usuario();
                oUsuario.Login = txtLogin.Text;
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.Password = txtPassword.Text;
                oUsuario.IdRol = (cmbRol.SelectedItem as Rol).IdRol;
                //Salvar
                oUsuario = bllUsuario.Save(oUsuario);

                // Crear hilo y enviar el Method que se ejecuta procesos paralelos.
                Thread thread = new Thread(Paralelo);
                thread.Start();

                this.txtPassword.Clear();
                this.txtLogin.Clear();
                this.txtNombre.Clear();
                cmbRol.SelectedIndex = 0;
                txtLogin.Focus();

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Paralelo()
        {
            try
            {
                Parallel.Invoke(
                                () => TaskBarMensaje(), 
                                () => LlenarUsuarios()   
                                );                      
            }             
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void TaskBarMensaje()
        {
            ntfMensaje.Visible = true;
            ntfMensaje.BalloonTipIcon = ToolTipIcon.Info;
            ntfMensaje.BalloonTipText = "Usuario creado correctamente";
            ntfMensaje.BalloonTipTitle = "Atención";
            ntfMensaje.Icon = Properties.Resources.icono;
            ntfMensaje.Text = "";
            ntfMensaje.ShowBalloonTip(3000);
            ntfMensaje.Visible = false;
        }

        private void LlenarUsuarios()
        {
            IBLLUsuario bllUsuario = new BLLUsuario();
            IEnumerable<Usuario> lista;
            TreeNode raiz;
            try
            {
                this.trvUsuarios.Invoke((MethodInvoker)delegate
                {
                    trvUsuarios.Nodes.Clear();
                    lista = bllUsuario.GetAll();
                    raiz = trvUsuarios.Nodes.Add("Usuarios", "Usuarios", 0, 0);
                    foreach (var item in lista)
                    {
                        TreeNode nodo = new TreeNode(item.ToString(), 1, 1);
                        nodo.Tag = item;
                        trvUsuarios.Nodes[0].Nodes.Add(nodo);
                    }
                    trvUsuarios.ExpandAll();
                });

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
             
            this.txtPassword.Clear();
            this.txtLogin.Clear();
            this.txtNombre.Clear();
            cmbRol.SelectedIndex = 0;
            txtLogin.Focus();
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {

            IBLLRol bllRol;
            List<Rol> listaRol;
            try
            {

                bllRol = new BLLRol();

                listaRol = bllRol.GetAll();
                foreach (var item in listaRol)
                {
                    this.cmbRol.Items.Add(item);
                }
                if (cmbRol.Items.Count > 0)
                    this.cmbRol.SelectedIndex = 0;

                LlenarUsuarios();

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IBLLUsuario bllUsuario = new BLLUsuario();
            try
            {
                TreeNode nodo = trvUsuarios.SelectedNode;
                // Validar que no borre el nodo raiz
                if (nodo.Text.Equals("usuarios", StringComparison.CurrentCultureIgnoreCase))
                    return;

                if (nodo.IsSelected)
                {
                    DialogResult result = MessageBox.Show($"Desea borrar el usuario {nodo.Text}", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (bllUsuario.Delete((nodo.Tag as Usuario).Login))
                        {
                            nodo.Remove();
                            toolStripBtnNuevo_Click(null, null);
                        }
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


        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trvUsuarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Usuario oUsuario = null;
            try
            {
                if (e.Action == TreeViewAction.ByMouse)
                {
                    // no hay nada seleccionado
                    if (e.Node == null || e.Node.Tag == null)
                        return;
                    //Extrae el Objeto que se encuentra en el Tag
                    oUsuario = e.Node.Tag as Usuario;

                    txtLogin.Text = oUsuario.Login;
                    txtNombre.Text = oUsuario.Nombre;
                    txtPassword.Text = Cryptography.DecrypthAES(oUsuario.Password);
                    cmbRol.SelectedIndex = cmbRol.FindString(oUsuario.IdRol.ToString());
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
