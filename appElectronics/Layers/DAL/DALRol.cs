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
    public  class DALRol : IDALRol
    {

        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");
 
        public List<Rol> GetAll()
        {
            StringBuilder conexion = new StringBuilder();

            IDataReader reader = null;
            List<Rol> lista = new List<Rol>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            string sql = @" select * from  Rol ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Rol oRol = new Rol();
                        oRol.IdRol = int.Parse(reader["IdRol"].ToString());
                        oRol.DescripcionRol = reader["DescripcionRol"].ToString();
                        lista.Add(oRol);
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


    }

}
