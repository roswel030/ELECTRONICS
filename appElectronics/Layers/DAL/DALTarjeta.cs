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
    public  class DALTarjeta : IDALTarjeta
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");

      
        public bool Delete(string pId)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> GetAll()
        {
            IDataReader reader = null;
            List<Tarjeta> lista = new List<Tarjeta>();
            Tarjeta oTarjeta = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Tarjeta  With (NoLock)";
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);
                    // Si devolvió filas
                    while (reader.Read())
                    {
                        oTarjeta = new Tarjeta();
                        oTarjeta.IdTarjeta = int.Parse(reader["IdTarjeta"].ToString());
                        oTarjeta.DescripcionTarjeta = reader["DescripcionTarjeta"].ToString();                         
                        lista.Add(oTarjeta);
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


        public Tarjeta GetById(int pId)
        {
            string msg = "";
            DataSet ds = null;
            Tarjeta oTarjeta = null;
            SqlCommand command = new SqlCommand();
            string sql = @" select * from  Tarjeta  With (NoLock)
                               where IdTarjeta = @IdTarjeta";

            try
            {
                command.Parameters.AddWithValue("@idTarjeta", pId);
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
                        oTarjeta = new Tarjeta();
                        oTarjeta.IdTarjeta = int.Parse(dr["IdTarjeta"].ToString());
                        oTarjeta.DescripcionTarjeta = dr["DescripcionTarjeta"].ToString();

                    }
                }

                return oTarjeta;
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

        public Tarjeta Save(Tarjeta pTarjeta)
        {

            throw new NotImplementedException();
        }

        public Tarjeta Update(Tarjeta pTarjeta)
        {
            throw new NotImplementedException();
        }
    }
}
