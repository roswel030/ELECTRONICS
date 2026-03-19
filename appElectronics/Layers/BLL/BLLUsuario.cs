using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.BLL
{
    public  class BLLUsuario : IBLLUsuario
    {
         
        public Usuario Login(string pLogin, string pPassword)
        {

            IDALUsuario dalUsuario = new DALUsuario();
            // Encriptar el password
            string crytpPasswd = Cryptography.EncrypthAES(pPassword);

            return dalUsuario.Login(pLogin, crytpPasswd);
        }

        public IEnumerable<Usuario> GetAll()
        {
            IDALUsuario dalUsuario = new DALUsuario();
            return dalUsuario.GetAll();
        }

        public Usuario Save(Usuario pUsuario)
        {
            IDALUsuario dalUsuario = new DALUsuario();
            string mensaje = "";
            Usuario oUsuario = null;

            if (!IsValidPassword(pUsuario.Password, ref mensaje))
            {
                throw new Exception(mensaje);
            }

            // Encriptar la contraseña.
            pUsuario.Password = Cryptography.EncrypthAES(pUsuario.Password);

            if (dalUsuario.GetById(pUsuario.Login) != null)
                oUsuario = dalUsuario.Update(pUsuario);
            else
                oUsuario = dalUsuario.Save(pUsuario);
            return oUsuario;
        }

        public Usuario GetById(string pLogin)
        {
            IDALUsuario dalUsuario = new DALUsuario();
            return dalUsuario.GetById(pLogin);
        }

        public bool Delete(string pLogin)
        {
            IDALUsuario dalUsuario = new DALUsuario();
            return dalUsuario.Delete(pLogin);
        }

        private bool IsValidPassword(string pPassword, ref string pMensaje)
        {
            if (pPassword.Trim().Length <= 6)
            {
                pMensaje = "El password debe ser mayor o igual a 6 caracteres";
                return false;
            }

            if (pPassword.Trim().Length > 10)
            {
                pMensaje = "El password debe ser mayor o igual a 6 caracteres y menor  o igual que 10";
                return false;
            }

            return true;
        }

    }
}
