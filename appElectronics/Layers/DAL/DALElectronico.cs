using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;
using UTN.Winform.Electronics.Properties;

namespace UTN.Winform.Electronics.Layers.DAL
{
    public class DALElectronico : IDALElectronico
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public bool Delete(double pId)
        {

            string msg = "";
            double rows = 0;
            // Crear el SQL
            string sql = @" delete   from  [Electronico] where IdElectronico = @IdElectronico ";
            SqlCommand command = new SqlCommand();

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                return rows > 0;
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

        public List<ElectronicoBodegaDTO> GetAll()
        {
            string msg = "";
            DataSet ds = null;
            List<ElectronicoBodegaDTO> lista = new List<ElectronicoBodegaDTO>();
            SqlCommand command = new SqlCommand();

            string sql = @" SELECT   Electronico.IdElectronico,  Electronico.DescripcionElectronico, Electronico.Precio, Electronico.Cantidad, Electronico.Imagen, Electronico.Garantia, Electronico.IdBodega, Electronico.Documentacion, 
                              Electronico.FechaInclusion,  Bodega.DescripcionBodega
                            FROM    Bodega INNER JOIN
                              Electronico ON Bodega.IdBodega = Electronico.IdBodega ";
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {

                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ElectronicoBodegaDTO oElectronicoBodegaDTO = new ElectronicoBodegaDTO()
                        {
                            IdElectronico = double.Parse(dr["IdElectronico"].ToString()),
                            Cantidad = int.Parse(dr["Cantidad"].ToString()),
                            DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                            Documentacion = (byte[])dr["Documentacion"],
                            FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                            Imagen = (byte[])dr["Imagen"],
                            Precio = double.Parse(dr["Precio"].ToString()),
                            DescripcionBodega = dr["DescripcionBodega"].ToString(),
                            Garantia = (bool)dr["Garantia"],
                            IdBodega = int.Parse(dr["IdBodega"].ToString())
                        };

                        lista.Add(oElectronicoBodegaDTO);
                    }
                }

                return lista;
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

        public List<Electronico> GetByFilter(string pDescripcion)
        {
            string msg = "";

            SqlCommand command = new SqlCommand();
            List<Electronico> lista = new List<Electronico>();
            string sql = @" select * from  [Electronico] with (nolock,index(DescripcionElectronicoIDX))
                             where [DescripcionElectronico] like @DescripcionElectronico";

            try
            {
                // Pasar Parámetro
                command.Parameters.AddWithValue("@DescripcionElectronico", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (IDataReader dr = db.ExecuteReader(command))
                    {

                        while (dr.Read())
                        {
                            // Mapear la fila al Objeto
                            Electronico oElectronico = new Electronico()
                            {
                                IdElectronico = Convert.ToDouble(dr["IdElectronico"].ToString()),
                                Cantidad = Convert.ToInt16(dr["Cantidad"].ToString()),
                                DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                                Documentacion = (byte[])dr["Documentacion"],
                                FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                                Imagen = (byte[])dr["Imagen"],
                                Precio = Convert.ToDouble(dr["Precio"].ToString()),
                                Garantia = (bool)dr["Garantia"],
                                IdBodega = Convert.ToInt16(dr["IdBodega"].ToString())
                            };

                            lista.Add(oElectronico);
                        }
                    }

                } 

                return lista;
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

        public Electronico GetById(double pId)
        {
            string msg = "";
            DataSet ds = null;
            Electronico oElectronico = null;
            string sql = @" select * from  [Electronico] where IdElectronico = @IdElectronico";

            SqlCommand command = new SqlCommand();

            try
            {
                command.Parameters.AddWithValue("@IdElectronico", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si retornó valores 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Extraer la primera fila, como se buscó por Id entonces solo una debe devolver  
                    DataRow dr = ds.Tables[0].Rows[0];
                    oElectronico = new Electronico()
                    {
                        IdElectronico = Convert.ToDouble(dr["IdElectronico"].ToString()),
                        Cantidad = Convert.ToInt16(dr["Cantidad"].ToString()),
                        DescripcionElectronico = dr["DescripcionElectronico"].ToString(),
                        Documentacion = (byte[])dr["Documentacion"],
                        FechaInclusion = DateTime.Parse(dr["FechaInclusion"].ToString()),
                        Imagen = (byte[])dr["Imagen"],
                        Precio = Convert.ToDouble(dr["Precio"].ToString()),
                        Garantia = (bool)dr["Garantia"],
                        IdBodega = Convert.ToInt16(dr["IdBodega"].ToString())
                    };

                }

                return oElectronico;
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

        public Electronico Save(Electronico pElectronico)
        {
            string msg = "";
            Electronico oElectronico = null;
            string sql = @" 
                            INSERT INTO [dbo].[Electronico]
                                        ([IdElectronico],
                                         [DescripcionElectronico],
                                         [Precio],
                                         [Cantidad],
                                         [Imagen],
                                         [Documentacion],
                                         [Garantia] ,
                                         [IdBodega]
                                         )
                                    VALUES
                                        (@IdElectronico ,
                                         @DescripcionElectronico,  
                                         @Precio,  
                                         @Cantidad,  
                                         @Imagen, 
                                         @Documentacion,
                                         @Garantia, 
                                         @IdBodega)";


            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pElectronico.IdElectronico);
                command.Parameters.AddWithValue("@DescripcionElectronico", pElectronico.DescripcionElectronico.Trim());
                command.Parameters.AddWithValue("@Precio", pElectronico.Precio);
                command.Parameters.AddWithValue("@Cantidad", pElectronico.Cantidad);
                command.Parameters.AddWithValue("@Imagen", pElectronico.Imagen.ToArray());
                command.Parameters.AddWithValue("@Documentacion", pElectronico.Documentacion.ToArray());
                command.Parameters.AddWithValue("@Garantia", (bool)pElectronico.Garantia);
                command.Parameters.AddWithValue("@IdBodega", pElectronico.IdBodega);
                command.Parameters.AddWithValue("@FechaInclusion", pElectronico.FechaInclusion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oElectronico = GetById(pElectronico.IdElectronico);

                return oElectronico;
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

        public Electronico Update(Electronico pElectronico)
        {
            Electronico oElectronico = null;
            string sql = @" 
                            UPDATE [dbo].[Electronico]
                               SET 
                                   [DescripcionElectronico] =  @DescripcionElectronico
                                  ,[Precio] = @Precio
                                  ,[Cantidad] = @Cantidad
                                  ,[Imagen] = @Imagen
                                  ,[Garantia] = @Garantia
                                  ,[IdBodega] = @IdBodega 
                                  ,[Documentacion] = @Documentacion                                 
                             WHERE [IdElectronico] = @IdElectronico  ";



            SqlCommand command = new SqlCommand();
            double rows = 0;
            string msg = "";
            try
            {

                // Pasar parámetros
                command.Parameters.AddWithValue("@IdElectronico", pElectronico.IdElectronico);
                command.Parameters.AddWithValue("@DescripcionElectronico", pElectronico.DescripcionElectronico);
                command.Parameters.AddWithValue("@Precio", pElectronico.Precio);
                command.Parameters.AddWithValue("@Cantidad", pElectronico.Cantidad);
                command.Parameters.AddWithValue("@Imagen", pElectronico.Imagen.ToArray());
                command.Parameters.AddWithValue("@Documentacion", pElectronico.Documentacion.ToArray());
                command.Parameters.AddWithValue("@Garantia", (bool)pElectronico.Garantia);
                command.Parameters.AddWithValue("@IdBodega", pElectronico.IdBodega);
                command.Parameters.AddWithValue("@FechaInclusion", pElectronico.FechaInclusion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oElectronico = GetById(pElectronico.IdElectronico);

                return oElectronico;
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
