using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.BLL
{
    public  class BLLRol : IBLLRol
    {
        public List<Rol> GetAll()
        {
            IDALRol dalRol = new DALRol();
            return dalRol.GetAll();
        }
    }
}
