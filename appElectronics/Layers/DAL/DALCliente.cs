using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Extensions;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.DAL
{
    public class DALCliente : IDALCliente
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> Delete(string pId)
        {
            String msg = "";
            bool retorno = false;
            double rows = 0d;

            SqlCommand command = new SqlCommand();
            try
            {

                string sql = @"Delete from  Cliente Where (IdCliente = @IdCliente) ";

                command.Parameters.AddWithValue("@IdCliente", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    retorno = true;

                return retorno;
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


        public async Task<IEnumerable<Cliente>> GetAll()
        {

            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Cliente  WITH (NOLOCK)  ";
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (SqlDataReader reader = await db.ExecuteReaderAsync(command))
                    {
                        // Iterar en todas las filas 
                        while (await reader.ReadAsync())
                        {

                            // Mapearlas
                            Cliente oCliente = new Cliente();
                            oCliente.IdCliente = reader["IdCliente"].ToString();
                            oCliente.Nombre = reader["Nombre"].ToString();
                            oCliente.Apellido1 = reader["Apellido1"].ToString();
                            oCliente.Apellido2 = reader["Apellido2"].ToString();
                            oCliente.Email = reader["Email"].ToString();
                            oCliente.FechaNacimiento = DateTime.Parse(reader["FechaNacimiento"].ToString());
                            oCliente.IdProvincia = Convert.ToInt32(reader["IdProvincia"].ToString());
                            oCliente.Sexo = Convert.ToInt32(reader["Sexo"].ToString());

                            lista.Add(oCliente);
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

        public List<Cliente> GetByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                // Observe que se fuerza a utilizar el indice
                string sql = @" select  * from cliente 
                                 with (nolock,index([NombreApellidosIDX])) 
                                Where Nombre+Apellido1+Apellido2 like @filtro ";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
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
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = dr["IdCliente"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido1 = dr["Apellido1"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Email = dr["Email"].ToString();
                        oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oCliente.IdProvincia = Convert.ToInt32(dr["IdProvincia"].ToString());
                        oCliente.Sexo = Convert.ToInt32(dr["Sexo"].ToString());

                        lista.Add(oCliente);
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

        public Cliente GetById(string pId)
        {

            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {

                string sql = @" select * from  Cliente Where IdCliente = @IdCliente ";
                command.Parameters.AddWithValue("@IdCliente", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (IDataReader dr = db.ExecuteReader(command))
                    {

                        while (dr.Read())
                        {
                            oCliente = new Cliente();

                            oCliente.IdCliente = dr["IdCliente"].ToString();
                            oCliente.Nombre = dr["Nombre"].ToString();
                            oCliente.Apellido1 = dr["Apellido1"].ToString();
                            oCliente.Apellido2 = dr["Apellido2"].ToString();
                            oCliente.Email = dr["Email"].ToString();
                            oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                            oCliente.IdProvincia = Convert.ToInt32(dr["IdProvincia"].ToString());
                            oCliente.Sexo = Convert.ToInt32(dr["Sexo"].ToString());
                        }
                    }
                }

                

                return oCliente;
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


        public async Task<Cliente> Save(Cliente pCliente)
        {
            string msg = "";
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into Cliente(IdCliente,Nombre,Apellido1,Apellido2,Email,Sexo,FechaNacimiento,IdProvincia)
                            values (@IdCliente,@Nombre,@Apellido1,@Apellido2,@Email,@Sexo,@FechaNacimiento,@IdProvincia)";
            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Email", pCliente.Email);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@IdProvincia", pCliente.IdProvincia);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oCliente = this.GetById(pCliente.IdCliente);
                }

                return oCliente;

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

        public async Task<Cliente> Update(Cliente pCliente)
        {
            string msg = "";
            string sql = @"Update Cliente SET IdCliente = @IdCliente, Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2,Email = @Email, Sexo = @Sexo, FechaNacimiento = @FechaNacimiento, IdProvincia = @IdProvincia  Where (IdCliente = @IdCliente) ";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Cliente oCliente = new Cliente();
            try
            {
                command.Parameters.AddWithValue("@IdCliente", pCliente.IdCliente);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido1", pCliente.Apellido1);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Email", pCliente.Email);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@FechaNacimiento", pCliente.FechaNacimiento);
                command.Parameters.AddWithValue("@IdProvincia", pCliente.IdProvincia);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetById(pCliente.IdCliente);

                return oCliente;

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
