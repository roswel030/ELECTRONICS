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
    public  class DALUsuario : IDALUsuario
    {
        private static readonly ILog _myLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public Usuario Save(Usuario pUsuario )
        {
            string msg = "";
            SqlCommand command = new SqlCommand();          
            Usuario oUsuario = null;
            string sql = @"Insert into Usuario(Login,IdRol,Password,Nombre ) values (@Login,@IdRol,@Password,@Nombre )";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@Login", pUsuario.Login);
                command.Parameters.AddWithValue("@IdRol", pUsuario.IdRol);
                command.Parameters.AddWithValue("@Password", pUsuario.Password);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
               

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oUsuario = GetById(pUsuario.Login);

                return oUsuario;
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


        public Usuario Update(Usuario pUsuario)
        {
            
            SqlCommand command = new SqlCommand();
            Usuario oUsuario = null;
            string sql = @"Update Usuario SET IdRol=@IdRol, Password=@Password, Nombre= @Nombre Where (Login = @Login)"; 
            double row = 0;
            string msg = "";
            try
            {
                command.Parameters.AddWithValue("@Login", pUsuario.Login);
                command.Parameters.AddWithValue("@IdRol", pUsuario.IdRol);
                command.Parameters.AddWithValue("@Password", pUsuario.Password);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                if (row > 0)
                    oUsuario = GetById(pUsuario.Login);

                return oUsuario;
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

        public Usuario Login(string pLogin, string pPassword)
        {
             
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Usuario oUsuario = null;
            string msg = "";
            try
            {
                command.CommandText = @"select * from usuario with (rowlock)  where Login = @pLogin and Password = @pPassword";
                command.Parameters.AddWithValue("@pLogin", pLogin);
                command.Parameters.AddWithValue("@pPassword", pPassword);
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oUsuario = new Usuario();
                        oUsuario.Login = reader["Login"].ToString();
                        oUsuario.IdRol = int.Parse(reader["IdRol"].ToString());
                        oUsuario.Password = reader["Password"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                    }
                }

                return oUsuario;
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

        public Usuario GetById(string pLogin)
        {
          
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Usuario oUsuario = null;
            string msg = "";
            try
            {
                command.CommandText = @"select * from usuario with (rowlock)   where Login = @login";
                command.Parameters.AddWithValue("@login", pLogin);

                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oUsuario = new Usuario();
                        oUsuario.Login = reader["Login"].ToString();
                        oUsuario.IdRol = int.Parse(reader["IdRol"].ToString());
                        oUsuario.Password = reader["Password"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                    }
                }

                return oUsuario;
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

        public IEnumerable<Usuario> GetAll()
        {
            string msg = "";
            SqlCommand command = new SqlCommand();
            IDataReader reader = null;
            Usuario oUsuario = null;
            IList<Usuario> lista = new List<Usuario>() ;
            try
            {
                command.CommandText = @"select * from usuario with (rowlock)  ";
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        oUsuario = new Usuario();
                        oUsuario.Login = reader["Login"].ToString();
                        oUsuario.IdRol = int.Parse(reader["IdRol"].ToString());
                        oUsuario.Password = reader["Password"].ToString();
                        oUsuario.Nombre = reader["Nombre"].ToString();
                        oUsuario.Estado = bool.Parse(reader["Estado"].ToString());
                        lista.Add(oUsuario);
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

        public bool Delete(string pLogin)
        {
            StringBuilder conexion = new StringBuilder();
            SqlCommand command = new SqlCommand();
            string msg = "";
            string sql = @"Delete  from  Usuario  where login = @Login";
            double row = 0;
            try
            {
                command.Parameters.AddWithValue("@Login", pLogin);
                command.CommandText = sql;
                command.CommandType = CommandType.Text; 

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    row = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }
 
                
                return row > 0 ?true : false ;
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
