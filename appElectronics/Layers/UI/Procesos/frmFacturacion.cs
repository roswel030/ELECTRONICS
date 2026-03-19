using log4net;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.UI.Filtros;
using UTN.Winform.Electronics.Layers.UI.Reportes;
using static QuestPDF.Helpers.Colors;
using System.Xml.Linq;

namespace UTN.Winform.Electronics.Layers.UI.Procesos
{

    /*
     Tareas 
     1- Configurar el Web Service del Banco Central para mostrar el monto del dolar para calcular el precio en esa moneda    
     2- Borrar un producto del DataGridView  por medio de un MenuContext
     4- Enviar la factura por correo en formato PDF.
     
    */
    public partial class frmFacturacion : Form
    {
        private static readonly ILog _myLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Cliente _cliente = null;
        private FacturaEncabezado _facturaEncabezado = null;

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {

            IBLLFactura bllFactura = new BLLFactura();
            IBLLDolar bllDolar = new BLLDolar();
            try
            {
                // Mostar Numero de factura
                this.txtNumeroFactura.Text = bllFactura.GetCurrentNumeroFactura().ToString();
                toolStripStatusLblDolar.Text = "Venta Dolar " + bllDolar.GetVentaDolar().ToString();
                // Cargar las Tarjetas
                LoadCreditCards();

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadCreditCards()
        {
            IBLLTarjeta bllTarjeta = new BLLTarjeta();
            foreach (var oTarjeta in bllTarjeta.GetAll())
            {
                this.cmbTarjeta.Items.Add(oTarjeta);
            }
            cmbTarjeta.SelectedIndex = 1;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmFiltroCliente ofrmFiltroCliente = new frmFiltroCliente();
            IBLLCliente bllCliente = new BLLCliente();
            try
            {
                erpError.Clear();

                this.txtNombreCliente.Text ="";

                if (!string.IsNullOrEmpty(this.txtClienteId.Text))
                {
                    _cliente = bllCliente.GetById(this.txtClienteId.Text);
                }
                else
                {
                    // Mostrar ventan de filtro
                    ofrmFiltroCliente.ShowDialog();
                    if (ofrmFiltroCliente.DialogResult == DialogResult.OK)
                    {
                        _cliente = ofrmFiltroCliente.Cliente;
                    }
                }

                if (_cliente == null)
                {                    
                    MessageBox.Show("No existe el Cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (this.rdbCredito.Checked && string.IsNullOrEmpty(this.txtNumeroTarjeta.Text))
                {
                    txtNumeroTarjeta.Focus();
                    erpError.SetError(txtNumeroTarjeta, "El pago  por tarjeta debe indicar su número");
                    MessageBox.Show("El pago es por tarjeta debe indicar su número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                _facturaEncabezado = new FacturaEncabezado()
                {
                    EstadoFactura = true,
                    FechaFacturacion = DateTime.Now,
                    IdFactura = double.Parse(this.txtNumeroFactura.Text),
                    _Cliente = _cliente,
                    _Tarjeta = cmbTarjeta.SelectedItem as Tarjeta,
                    TipoPago = this.rdbContado.Checked ? 1 : 2,
                    TarjetaNumero = this.txtNumeroTarjeta.Text
                };



                this.txtNombreCliente.Text = _cliente.ToString();
                this.txtClienteId.Text = _cliente.IdCliente;
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
            IBLLFactura bllFactura = new BLLFactura();

            try
            {

                _cliente = null;
                this.txtClienteId.Text = "";
                this.txtImpuesto.Text = "";
                this.txtNumeroTarjeta.Text = "";
                this.txtSubtotal.Text = "";
                this.txtTotal.Text = "";
                this.txtPrecio.Text = "";
                this.cmbTarjeta.SelectedIndex = 0;
                this.mskCantidad.Text = "";
                this.mskCodigoProduto.Text = "";
                this.txtNombreCliente.Text = "-";
                this.txtExistencia.Text = "";
                this.txtDescripcionElectronico.Text = "";
                this.rdbCredito_CheckedChanged(null, null);
                this.txtNumeroTarjeta.Text = "";
                txtNumeroTarjeta.Focus();
                _facturaEncabezado = null;
                this.dgvDetalleFactura.Rows.Clear();
                // Mostar Numero de factura
                int numeroFactura = bllFactura.GetCurrentNumeroFactura();
                this.txtNumeroFactura.Text = numeroFactura.ToString();
            }
            catch (Exception er)
            {
                string msg = " ";
                

                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {
            IBLLFactura bllFactura = new BLLFactura();

            try
            {
                if (_cliente == null)
                {
                    MessageBox.Show("Debe Seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtClienteId.Focus();
                    return;
                }

                if (_facturaEncabezado == null)
                {
                    MessageBox.Show("No hay datos por facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_facturaEncabezado._ListaFacturaDetalle.Count == 0)
                {
                    MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                toolStripBtnFacturar.Enabled = false;
                _facturaEncabezado = bllFactura.Save(_facturaEncabezado);


                // Crear Reporte en PDF
                CreateReportPDF(_facturaEncabezado);

                if (_facturaEncabezado == null)
                    MessageBox.Show("Error al crear factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    toolStripBtnNuevo_Click(null, null);


            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

                toolStripBtnFacturar.Enabled = true;
            }
        }

        private void CreateReportPDF(FacturaEncabezado pFacturaEncabezado)
        {
            double granTotal = 0d, subTotal = 0, impuestoTotal = 0d, total = 0d;

            // Crear imagen quickresponse
            System.Drawing.Image qrImage = QuickResponse.QuickResponseGenerador(pFacturaEncabezado.IdFactura.ToString(), 53);
            // Convert Image into bytes array 
            MemoryStream ms = new MemoryStream();
            qrImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //qrImage.Save(@"c:\temp\qr.png", System.Drawing.Imaging.ImageFormat.Png);
            //col1.Item().AlignLeft().Image(ms.ToArray());


            // Logo
            Bitmap logoBitmap = new Bitmap(Properties.Resources.smalllogo, 200, 200);
            byte[] logoBytes;
            MemoryStream memory = new MemoryStream();
            logoBitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            logoBytes = memory.ToArray();


            // Obligatorio la licencia Community
            QuestPDF.Settings.License = LicenseType.Community;

            var pdfBytesArray = Document.Create(document =>
            {
                document.Page(page =>
                {

                    page.Size(PageSizes.Letter);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.Margin(30);

                    // Encabezado de página
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignLeft().Text("Electronics S.A.").Bold().FontSize(50).Bold().FontColor("#2058b3");
                            row.ConstantItem(100).AlignRight().Height(100).Image(logoBytes);
                            col.Item().AlignLeft().Text($"Fecha: {DateTime.Now} ").FontSize(9);
                            col.Item().LineHorizontal(1f);

                        });
                    });
                    // Página
                    page.Content().PaddingVertical(10).Column(col1 =>
                    {
                        // Titulo del reporte
                        col1.Item().AlignLeft().Text($"Factura No {pFacturaEncabezado.IdFactura}").FontSize(14).Bold();
                        col1.Item().AlignLeft().Text($"Fecha: {pFacturaEncabezado.FechaFacturacion} ").FontSize(10);
                        col1.Item().AlignLeft().Text($"Cliente: {pFacturaEncabezado._Cliente.IdCliente.Trim()} - {pFacturaEncabezado._Cliente.Nombre.Trim()} {pFacturaEncabezado._Cliente.Apellido1.Trim()}").FontSize(10);
                        col1.Item().AlignLeft().Text($"No Tarjeta: {pFacturaEncabezado.TarjetaNumero}").FontSize(10);

                        // Todo: Agregue el Numero de Tarjeta 

                        col1.Item().LineHorizontal(0.5f);
                        col1.Item().Text("");

                        col1.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                // Define cuantas columnas 
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                            });

                            // Define encabezado
                            tabla.Header(header =>
                            {
                                header.Cell().Background("#4666FF")
                                .Padding(2).AlignCenter().Text("Código").FontColor("#fff");

                                header.Cell().Background("#4666FF")
                                .Padding(2).AlignCenter().Text("Descripcion").FontColor("#fff");

                                header.Cell().Background("#4666FF")
                               .Padding(2).AlignCenter().Text("Cantidad").FontColor("#fff");

                                header.Cell().Background("#4666FF")
                               .Padding(2).AlignCenter().Text("Precio").FontColor("#fff");
                                header.Cell().Background("#4666FF")
                               .Padding(2).AlignCenter().Text("Impuesto").FontColor("#fff");

                                header.Cell().Background("#4666FF")
                               .Padding(2).AlignCenter().Text("Total").FontColor("#fff");
                            });


                            // recorrer la lista
                            foreach (var item in pFacturaEncabezado._ListaFacturaDetalle)
                            {
                                // Column 1 
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).Text(item.IdElectronico.ToString()).FontSize(10);

                                // Column 2
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).AlignLeft().Text(item.DescripcionElectronico.ToString());

                                // Column 3                                        
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).AlignRight().Text(item.Cantidad.ToString()).FontSize(10);

                                // Column 4                                        
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).AlignRight().Text(item.Precio.ToString("##,###,###.00")).FontSize(10);

                                // Column 5                                        
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).AlignRight().Text(item.Impuesto.ToString("##,###,###.00")).FontSize(10);


                                total = (item.Cantidad * item.Precio) + item.Impuesto;

                                // Column 6
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                .Padding(2).AlignRight().Text(total.ToString("##,###,###.00")).FontSize(10);

                                subTotal += (item.Cantidad * item.Precio);
                                granTotal += total;
                                impuestoTotal += item.Impuesto;
                            }

                        });

                        col1.Item().AlignRight().Text("SubTotal " + subTotal.ToString("###,###.00")).FontSize(10).Bold();
                        col1.Item().AlignRight().Text("Impuesto " + impuestoTotal.ToString("###,###.00")).FontSize(10).Bold();
                        col1.Item().AlignRight().Text("Total " + granTotal.ToString("###,###.00")).FontSize(10).Bold();

                        // Mostrar QR
                        col1.Item().Row(row1 =>
                        {
                            row1.ConstantItem(90).Image(ms.ToArray());
                        });

                    });


                    // Pie de página
                    page.Footer()
                    .AlignRight()
                    .Text(txt =>
                    {
                        txt.Span("Página ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();
            // .GeneratePdfAndShow()


            // Salvado en disco
            File.WriteAllBytes(@"c:\temp\pdfFactura.pdf", pdfBytesArray);
            
            // Rutina para enviar correo
            // IBLLCliente bllCliente = new BLLCliente();
            //Cliente oCliente = bllCliente.GetById(txtClienteId.Text);             
            // SendEmailInvoice(oCliente.Email);

             Process.Start(@"c:\temp\pdfFactura.pdf"); 
        }


        private void SendEmailInvoice(string email)
        {
            //MessageBox.Show("tiene q configurar el correo !!!! ");
            String cuentaCorreoElectronico = "";
            String contrasenaGeneradaXGmail = "";
            string correoDestinatario = email;  //;

            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Su factura Electronica ";
            mensaje.Body = "Adjunto su factura electronica ";
            mensaje.From = new MailAddress(cuentaCorreoElectronico);
            mensaje.To.Add(correoDestinatario); //Correo del destinatario
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(cuentaCorreoElectronico, contrasenaGeneradaXGmail);
            smtp.EnableSsl = true;
            // Adjuntar un archivo
            Attachment attachment = new Attachment(@"c:\temp\pdfFactura.pdf");
            mensaje.Attachments.Add(attachment);
            smtp.Send(mensaje);
            
            MessageBox.Show("La factura ha sido enviada al correo","Atención");

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IBLLImpuesto bllImpuesto = new BLLImpuesto();
            IBLLElectronico bllElectronico = new BLLElectronico();
            FacturaDetalle oFacturaDetalle = new FacturaDetalle();
            IBLLFactura bllFactura = new BLLFactura();
            double dolares = 0d;
            try
            {
                erpError.Clear();

                if (_facturaEncabezado == null)
                {
                    MessageBox.Show("Debe agregar los datos del encabezado de la factura para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que el Producto ya no se haya agregado
                if (_facturaEncabezado._ListaFacturaDetalle.Count > 0)
                {
                    // Si ya se agrego no permitir agregarlo nuevamente
                    if (_facturaEncabezado._ListaFacturaDetalle.FindAll(p => p.IdElectronico == double.Parse(mskCodigoProduto.Text)).Count > 0)
                    {
                        MessageBox.Show("El producto ya fue agregado previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (string.IsNullOrEmpty(this.mskCantidad.Text))
                {
                    mskCantidad.Focus();
                    erpError.SetError(mskCantidad, "Debe ingresar la cantidad de artículos");
                    return;
                }


                if (double.Parse(this.mskCantidad.Text) <= 0)
                {
                    mskCantidad.Focus();
                    erpError.SetError(mskCantidad, "La cantidad debe ser mayor a CERO");
                    return;
                }

                // Valida que exista disponibilidad en el Inventario
                Electronico oElectronico = bllElectronico.AvabilityStock(double.Parse(this.mskCodigoProduto.Text),
                                                                          double.Parse(this.mskCantidad.Text));
                // Vuelve a mostrar Existencia.
                this.txtExistencia.Text = oElectronico.Cantidad.ToString();

                oFacturaDetalle.IdElectronico = Convert.ToDouble(this.mskCodigoProduto.Text);
                oFacturaDetalle.Cantidad = Convert.ToInt32(this.mskCantidad.Text);
                oFacturaDetalle.Precio = Convert.ToDouble(this.txtPrecio.Text);
                oFacturaDetalle.IdFactura = _facturaEncabezado.IdFactura;
                // Calcular el Impuesto
                oFacturaDetalle.Impuesto = bllFactura.CalculateTax(oFacturaDetalle.Precio, oFacturaDetalle.Cantidad);
                // Enumerar la secuencia
                oFacturaDetalle.Secuencia = _facturaEncabezado._ListaFacturaDetalle.Count + 1;
                // Agregar
                _facturaEncabezado.AddDetalle(oFacturaDetalle);


                string[] lineaFactura = {oFacturaDetalle.Secuencia.ToString(),
                                         this.mskCantidad.Text,
                                         this.txtDescripcionElectronico.Text,
                                         oFacturaDetalle.Cantidad.ToString(),
                                         oFacturaDetalle.Precio.ToString("##,###.00"),
                                         (oFacturaDetalle.Cantidad * oFacturaDetalle.Precio).ToString("₡ ##,###.00")
                                         };

                this.dgvDetalleFactura.Rows.Add(lineaFactura);

                this.txtSubtotal.Text = _facturaEncabezado.GetSubTotal().ToString("##,###.00");
                this.txtImpuesto.Text = _facturaEncabezado.GetImpuesto().ToString("##,###.00");
                this.txtTotal.Text = (_facturaEncabezado.GetSubTotal() + _facturaEncabezado.GetImpuesto()).ToString("##,###.00");

                IBLLDolar bllDolar = new BLLDolar();
                // Configurar el webService para consumir el WebService del Banco Central
                //dolares = double.Parse(this.txtTotal.Text) / bllDolar.GetVentaDolar();

                // Formato en dólares
                txtDolares.Text = dolares.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

                this.mskCantidad.Text = "";
                this.txtDescripcionElectronico.Text = "";
                this.txtExistencia.Text = "";
                this.txtPrecio.Text = "";


                this.mskCodigoProduto.Text = "";
                mskCodigoProduto.Focus();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmFiltroElectronico ofrmFiltroElectronico = new frmFiltroElectronico();
            Electronico oElectronico = null;
            try
            {
                ofrmFiltroElectronico.ShowDialog();

                if (ofrmFiltroElectronico.DialogResult == DialogResult.OK)
                {
                    oElectronico = ofrmFiltroElectronico.Electronico;
                    txtDescripcionElectronico.Text = oElectronico.DescripcionElectronico;
                    this.mskCodigoProduto.Text = oElectronico.IdElectronico.ToString();
                    this.txtPrecio.Text = oElectronico.Precio.ToString();
                    this.txtExistencia.Text = oElectronico.Cantidad.ToString();
                    this.mskCantidad.Focus();
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {

          

        }

        private void txtNumeroTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Process.Start(@"C:\Windows\System32\osk.exe");
                // Process.Start(new ProcessStartInfo("osk.exe") { UseShellExecute = true });
            }
        }

        private void mskCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2)
                {
                    btnBuscarProducto_Click(null, null);
                }


                if (e.KeyCode == Keys.F3)
                {
                    Process.Start("osk.exe");
                }

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

         

        private void rdbContado_Click(object sender, EventArgs e)
        {
            this.txtNumeroTarjeta.Text = "";
            this.cmbTarjeta.Enabled = false;
            txtNumeroTarjeta.Enabled = false;
            this.txtClienteId.Focus();
            this.cmbTarjeta.SelectedItem = this.cmbTarjeta.Items[0];

        }

        private void rdbCredito_Click(object sender, EventArgs e)
        {
            this.txtNumeroTarjeta.Text = "";
            this.cmbTarjeta.Enabled = true;
            this.cmbTarjeta.SelectedItem = this.cmbTarjeta.Items[1];
            this.txtNumeroTarjeta.Enabled = true;
            this.txtNumeroTarjeta.Focus();

        }
    }
}
