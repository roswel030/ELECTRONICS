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
    public  class BLLTarjeta : IBLLTarjeta
    {
        public bool Delete(int pId)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> GetAll()
        {
            IDALTarjeta dalTarjeta = new DALTarjeta();
            return dalTarjeta.GetAll();
        }

        public Tarjeta GetById(string pIdTarjeta)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }

        public Tarjeta Save(Tarjeta pTarjeta)
        {
            throw new Exception("Ud debe desarrollarlo!");

        }
    }
}
