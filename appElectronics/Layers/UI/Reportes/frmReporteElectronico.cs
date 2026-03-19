using log4net;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.BLL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Properties;

/*
  TODO: Implementar ordenamiento de la lista por descripción del producto, por Monto, Cantidad  (radiobuttons)
*/
namespace UTN.Winform.Electronics.Layers.UI.Reportes
{

    public partial class frmReporteElectronico : Form
    {
        private static readonly ILog _myLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public frmReporteElectronico()
        {
            InitializeComponent();
        }

        private void frmReporteElectronico_Load(object sender, EventArgs e)
        {

        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = "";
            IBLLElectronico bllELectronico = new BLLElectronico();
            double total = 0d, granTotal = 0d;
            List<Electronico> lista = null;
            try
            {

                filtro = "%" + this.txtFiltro.Text + "%";

                lista = bllELectronico.GetByFilter(filtro);

                // Retorno elementos?
                if (!lista.Any())
                {
                    MessageBox.Show($"No existe productos con la descripción {txtFiltro.Text}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFiltro.Focus();
                    return;
                }


                // Obligatorio la licencia Community
                QuestPDF.Settings.License = LicenseType.Community;

                Document.Create(document =>
                {
                    document.Page(page =>
                    {

                        page.Size(PageSizes.Letter);
                        page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.Margin(30);

                        // Pie de página
                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().AlignLeft().Text("Electronics S.A. ").Bold().FontSize(14).Bold();
                                col.Item().AlignLeft().Text($"Fecha: {DateTime.Now} ").FontSize(9);
                                col.Item().LineHorizontal(1f);

                            });

                        });

                        // Página
                        page.Content().PaddingVertical(10).Column(col1 =>
                        {
                            // Titulo del reporte
                            col1.Item().AlignCenter().Text("Reporte de Productos").FontSize(14).Bold();
                            col1.Item().Text("");
                            col1.Item().LineHorizontal(0.5f);

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
                                    .Padding(2).AlignCenter().Text("Imagen").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Cantidad").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Precio").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Total").FontColor("#fff");
                                });



                                // recorrer la lista
                                foreach (var item in lista)
                                {
                                    tabla.Cell().ColumnSpan(4).Text("xxxxxxxxxxx");

                                    // Column 1 
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).Text(item.IdElectronico.ToString()).FontSize(10);

                                    // Column 2
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignLeft().Text(item.DescripcionElectronico);

                                    // Column 3
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                   .Padding(2).Image(item.Imagen);

                                    // Column 4                                        
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(item.Cantidad.ToString()).FontSize(10);

                                    // Column 5                                        
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(item.Precio.ToString("##,###,###.00")).FontSize(10);


                                    total = item.Cantidad * item.Precio;
                                    // Column 6
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(total.ToString("##,###,###.00")).FontSize(10);

                                    granTotal += total;
                                }

                            });

                            col1.Item().AlignRight().Text("Total " + granTotal.ToString("###,###.00")).FontSize(12).Bold();
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
                }).GeneratePdfAndShow();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 

        private void btnReporte_Click(object sender, EventArgs e)
        {


            string filtro = "";
            IBLLElectronico bllELectronico = new BLLElectronico();
            IBLLBodega bllBodega = new BLLBodega();
            double totalProducto = 0d;
           
            List<Electronico> lista = null;
            try
            {

                filtro = "%" + this.txtFiltro.Text + "%";

                lista = bllELectronico.GetByFilter(filtro);

                // Retorno elementos?
                if (!lista.Any())
                {
                    MessageBox.Show("No existe productos con la descripción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFiltro.Focus();
                    return;
                }

                // Ordenado
                lista = lista.OrderBy(x => x.IdBodega).ToList();

                // Logo
                Bitmap logoBitmap = new Bitmap(Properties.Resources.smalllogo,200,200 );
                byte[] logoBytes;
                MemoryStream memory = new MemoryStream();
                logoBitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                logoBytes = memory.ToArray();



                // Obligatorio la licencia Community
                QuestPDF.Settings.License = LicenseType.Community;

                var pdfFileBytes = Document.Create(document =>
                {
                    document.Page(page =>
                    {

                        page.Size(PageSizes.Letter);
                        page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);
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
                            col1.Item().AlignCenter().Text("Reporte de Productos").FontSize(14).Bold();
                            col1.Item().Text("");
                            col1.Item().LineHorizontal(0.5f);

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
                                    .Padding(2).AlignCenter().Text("Imagen").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Cantidad").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Precio").FontColor("#fff");

                                    header.Cell().Background("#4666FF")
                                   .Padding(2).AlignCenter().Text("Total").FontColor("#fff");
                                });

                                //Agregar espacio
                                //tabla.Cell().Text(" ");                                
                                //int bodega = lista[0].IdBodega;
                                //bool firstTime = true;
                                // recorrer la lista
                                foreach (var item in lista)
                                {
                                    // Agrupamiento
                                    //if (bodega != item.IdBodega || firstTime == true) {
                                    //   bodega = item.IdBodega;
                                    //  tabla.Cell().ColumnSpan(6).Text($"Bodega No {bodega.ToString()}").BackgroundColor("#4666FF").FontColor("#fff").Bold();
                                    //  firstTime = false;
                                    // }
                                    
                                    // Column 1 
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).Text(item.IdElectronico.ToString()).FontSize(10);

                                    // Column 2
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignLeft().Text(item.DescripcionElectronico);

                                    // Column 3
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                   .Padding(2).Image(item.Imagen);

                                    // Column 4                                        
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(item.Cantidad.ToString()).FontSize(10);

                                    // Column 5                                        
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(item.Precio.ToString("##,###,###.00")).FontSize(10);


                                    totalProducto = item.Cantidad * item.Precio;
                                    // Column 6
                                    tabla.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9")
                                    .Padding(2).AlignRight().Text(totalProducto.ToString("##,###,###.00")).FontSize(10);

                                }

                            });
                            

                            col1.Item().AlignRight().Text("Total " + lista.Sum(f => f.Cantidad * f.Precio).ToString("###,###.00")).FontSize(12).Bold();
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

                // Salvarlo en disco
                string file = @"c:\temp\rptElectronico.pdf";
                File.WriteAllBytes(file, pdfFileBytes);

                Process.Start(file);

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



    }
}
