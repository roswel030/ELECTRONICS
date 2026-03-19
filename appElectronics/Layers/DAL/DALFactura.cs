using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.DAL
{
    public class DALFactura : IDALFactura
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public FacturaEncabezado Save(FacturaEncabezado pFactura)
        {
            FacturaEncabezado oFacturaEncabezado = null;
            string sqlEncabezado = string.Empty;
            string sqlDetalle = string.Empty;
            string sqlElectronico = string.Empty;
            SqlCommand cmdFacturaEncabezado = new SqlCommand();
            SqlCommand cmdFacturaDetalle = new SqlCommand();
            SqlCommand cmdElectronico = new SqlCommand();
            List<IDbCommand> listaCommands = new List<IDbCommand>();
            double rows = 0;
            string msg = "";

            // Reenumerar
            pFactura.IdFactura = GetCurrentNumeroFactura();
            pFactura._ListaFacturaDetalle.ForEach(p => p.IdFactura = pFactura.IdFactura);

            sqlEncabezado = @"  
                            INSERT INTO [dbo].[FacturaEncabezado]
                                       ([IdFactura]
                                       ,[IdTarjeta]
                                       ,[FechaFacturacion]
                                       ,[IdCliente]
                                       ,[EstadoFactura]
                                       ,[TipoPago]
                                       ,TarjetaNumero )
                                 VALUES
                                        (@IdFactura
                                       ,@IdTarjeta
                                       ,getdate()
                                       ,@IdCliente
                                       ,@EstadoFactura
                                       ,@TipoPago
                                       ,@TarjetaNumero )  ";

            try
            {
                // Encabezado de factura
                cmdFacturaEncabezado.Parameters.AddWithValue("@IdFactura", pFactura.IdFactura);
                cmdFacturaEncabezado.Parameters.AddWithValue("@IdTarjeta", pFactura._Tarjeta.IdTarjeta);
                cmdFacturaEncabezado.Parameters.AddWithValue("@IdCliente", pFactura._Cliente.IdCliente);
                cmdFacturaEncabezado.Parameters.AddWithValue("@EstadoFactura", pFactura.EstadoFactura);
                cmdFacturaEncabezado.Parameters.AddWithValue("@TipoPago", pFactura.TipoPago);
                cmdFacturaEncabezado.Parameters.AddWithValue("@TarjetaNumero", pFactura.TarjetaNumero);
                cmdFacturaEncabezado.CommandText = sqlEncabezado;
                cmdFacturaEncabezado.CommandType = CommandType.Text;
                // Agregar a la lista de commands
                listaCommands.Add(cmdFacturaEncabezado);


                // Detalle de factura
                sqlDetalle = @" 
                    INSERT INTO[dbo].[FacturaDetalle]
                               ([IdFactura]
                               ,[Secuencia]
                               ,[IdElectronico]
                               ,[Cantidad]
                               ,[Precio]
                               ,[Impuesto])
                         VALUES
                               (@IdFactura
                               ,@Secuencia
                               ,@IdElectronico
                               ,@Cantidad
                               ,@Precio
                               ,@Impuesto) ";

                // Guardar el detalle de la factura y a la vez rebajar el saldo del producto en Electronico
                foreach (FacturaDetalle pFacturaDetalle in pFactura._ListaFacturaDetalle)
                {
                    cmdFacturaDetalle = new SqlCommand();
                    cmdFacturaDetalle.Parameters.AddWithValue("@IdFactura", pFacturaDetalle.IdFactura);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Secuencia", pFacturaDetalle.Secuencia);
                    cmdFacturaDetalle.Parameters.AddWithValue("@IdElectronico", pFacturaDetalle.IdElectronico);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Cantidad", pFacturaDetalle.Cantidad);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Precio", pFacturaDetalle.Precio);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Impuesto", pFacturaDetalle.Impuesto);
                    cmdFacturaDetalle.CommandText = sqlDetalle;
                    cmdFacturaDetalle.CommandType = CommandType.Text;
                    // Agregar a la lista de comandos
                    listaCommands.Add(cmdFacturaDetalle);

                    // Rebajar 
                    cmdElectronico = new SqlCommand();
                    cmdElectronico.Parameters.AddWithValue("@IdElectronico", pFacturaDetalle.IdElectronico);
                    cmdElectronico.Parameters.AddWithValue("@Cantidad", pFacturaDetalle.Cantidad);
                    sqlElectronico = @"Update Electronico 
                                       Set Cantidad =  Cantidad - @Cantidad 
                                       Where IdElectronico = @IdElectronico";
                    cmdElectronico.CommandText = sqlElectronico;
                    cmdElectronico.CommandType = CommandType.Text;
                    listaCommands.Add(cmdElectronico);
                }


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(listaCommands, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo

                if (rows == 0)
                {
                    throw new Exception("No se pudo salvar correctamente la factura");
                }
                else
                {
                    oFacturaEncabezado = GetFactura(pFactura.IdFactura);

                }

                // Crear un nuevo consecutivo de factura
                GetNextNumeroFactura();

                return oFacturaEncabezado;
            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, cmdElectronico));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Extraer un consecutivo para asignar el numero de factura
        ///  Investigue como crear secuencias en SQLServer
        /// http://technet.microsoft.com/es-es/library/ff878091.aspx
        /// CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;
        /// </summary>
        /// <returns>Num. de factura</returns>
        public int GetNextNumeroFactura()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"select NEXT VALUE FOR   SequenceNoFactura ";
            string msg = "";
            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }

        }

        public int GetCurrentNumeroFactura()
        {

            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoFactura'  ";
            DataTable dt = null;
            string msg = "";
            try
            {

                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }

        }

        public double GetTotalFactura(double pNumeroFactura)
        {

            double sumatoria = 0d;
            string sql = @"  select sum(Cantidad * Precio + Impuesto) from FacturaDetalle  f
                             where f.IdFactura = @pNumeroFactura";
            string msg = "";
            SqlCommand command = new SqlCommand();
            try
            {               
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@pNumeroFactura", pNumeroFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    sumatoria = db.ExecuteScalar(command);
                }

                return sumatoria;

            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public async Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal)
        {


            SqlCommand command = new SqlCommand();
            List<VentasDTO> lista = new List<VentasDTO>();
            string msg = "";
            try
            {

                string sql = @"SELECT   Year(FacturaEncabezado.FechaFacturacion) as Anno ,
                                    sum((FacturaDetalle.Cantidad * FacturaDetalle.Precio)+ FacturaDetalle.Impuesto) as TotalVenta
                            FROM    FacturaDetalle INNER JOIN
                                     FacturaEncabezado ON FacturaDetalle.IdFactura = FacturaEncabezado.IdFactura 
                            WHERE FacturaEncabezado.FechaFacturacion between  @pFechaInicial  and @pFechaFinal
                            GROUP  BY  Year(FacturaEncabezado.FechaFacturacion) ";


                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@pFechaInicial", pFechaInicial);
                command.Parameters.AddWithValue("@pFechaFinal", new DateTime(pFechaFinal.Year, pFechaFinal.Month, pFechaFinal.Day, 23, 59, 59));

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        VentasDTO oVentasDTO = new VentasDTO();
                        oVentasDTO.Anno = int.Parse(reader["Anno"].ToString());
                        oVentasDTO.TotalVenta = Convert.ToDouble(reader["TotalVenta"]);
                        lista.Add(oVentasDTO);
                    }

                    return lista;
                }
            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }

        }

        public FacturaEncabezado GetFactura(double pNumeroFactura)
        {
            string msg = "";
            FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
            DataSet ds = null;
            IDALCliente dalCliente = new DALCliente();
            IDALTarjeta dalTarjeta = new DALTarjeta();
            SqlCommand command = new SqlCommand();

            string sql = @"  ";


            sql = @"SELECT  FacturaEncabezado.IdFactura, 
                            FacturaEncabezado.IdTarjeta, 
                            FacturaEncabezado.IdCliente, 
                            FacturaEncabezado.FechaFacturacion, 
                            FacturaEncabezado.EstadoFactura, 
                            FacturaEncabezado.TipoPago, 
                            FacturaEncabezado.TarjetaNumero, 
                            FacturaDetalle.Secuencia, 
                            FacturaDetalle.IdElectronico, 
                            Electronico.DescripcionElectronico,
                            FacturaDetalle.Cantidad, 
                            FacturaDetalle.Precio, 
                            FacturaDetalle.Impuesto 
                    FROM            FacturaEncabezado INNER JOIN
                                                FacturaDetalle ON FacturaEncabezado.IdFactura = FacturaDetalle.IdFactura INNER JOIN
                                                Electronico ON FacturaDetalle.IdElectronico = Electronico.IdElectronico
                    WHERE        (FacturaEncabezado.IdFactura = @IdFactura) ";

            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@IdFactura", pNumeroFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oFacturaEncabezado = new FacturaEncabezado()
                    {
                        EstadoFactura = (bool)dr["EstadoFactura"],
                        FechaFacturacion = DateTime.Parse(dr["FechaFacturacion"].ToString()),
                        IdFactura = double.Parse(dr["IdFactura"].ToString()),
                        TarjetaNumero = dr["IdTarjeta"].ToString(),
                        _Cliente = dalCliente.GetById(dr["IdCliente"].ToString()),
                        _Tarjeta = dalTarjeta.GetById(int.Parse(dr["IdTarjeta"].ToString())),
                        TipoPago = (int)dr["TipoPago"]
                    };


                    foreach (DataRow rowDetalle in ds.Tables[0].Rows)
                    {
                        FacturaDetalle oFacturaDetalle = new FacturaDetalle();
                        oFacturaDetalle.IdElectronico = double.Parse(rowDetalle["IdElectronico"].ToString());
                        oFacturaDetalle.Cantidad = int.Parse(rowDetalle["Cantidad"].ToString());
                        oFacturaDetalle.Precio = double.Parse(rowDetalle["Precio"].ToString());
                        oFacturaDetalle.IdFactura = double.Parse(rowDetalle["IdFactura"].ToString());
                        // Calcular el Impuesto
                        oFacturaDetalle.Impuesto = double.Parse(rowDetalle["Impuesto"].ToString());
                        // Enumerar la secuencia
                        oFacturaDetalle.Secuencia = int.Parse(rowDetalle["Secuencia"].ToString());
                        oFacturaDetalle.DescripcionElectronico = rowDetalle["DescripcionElectronico"].ToString();
                        // Agregar
                        oFacturaEncabezado.AddDetalle(oFacturaDetalle);
                    }
                }


                return oFacturaEncabezado;
            }
            catch (SqlException er)
            {
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
    }
}
