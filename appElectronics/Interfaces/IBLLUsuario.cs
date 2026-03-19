using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IBLLUsuario
    {
        Usuario Login(string pLogin, string pPassword);
        IEnumerable<Usuario> GetAll();
        Usuario GetById(string pLogin);
        Usuario Save(Usuario pUsuario);
        bool Delete(string pLogin);
    }
}
