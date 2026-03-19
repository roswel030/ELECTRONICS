using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.DAL
{
    public class DALBodega : IDALBodega
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public bool Delete(int pId)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }

        public List<Bodega> GetAll()
        {
            String msg = "";            
            List<Bodega> lista = new List<Bodega>();
            SqlCommand command = new SqlCommand();
            Bodega oBodega = null;
            string sql = @" select * from  Bodega WITH (NOLOCK)  ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (IDataReader reader = db.ExecuteReader(command))
                    {
                        while (reader.Read())
                        {
                            oBodega = new Bodega();
                            oBodega.IdBodega = int.Parse(reader["IdBodega"].ToString());
                            oBodega.DescripcionBodega = reader["DescripcionBodega"].ToString();
                            lista.Add(oBodega);
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

        public Bodega GetById(int pId)
        {
            Bodega oBodega = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"Select  IdBodega,DescripcionBodega  from  Bodega   Where (IdBodega = @IdBodega) ";
                command.Parameters.AddWithValue("@IdBodega", pId);
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (IDataReader dr = db.ExecuteReader(command))
                    {

                        while (dr.Read())
                        {
                            oBodega = new Bodega();

                            oBodega.IdBodega = Convert.ToInt16(dr["IdBodega"].ToString());
                            oBodega.DescripcionBodega = dr["DescripcionBodega"].ToString();
                            
                        }
                    }
                }



                return oBodega;
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

        public Bodega Save(Bodega pBodega)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }

        public Bodega Update(Bodega pBodega)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }
    }
}
