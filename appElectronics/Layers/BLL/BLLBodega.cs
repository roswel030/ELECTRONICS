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
    public class BLLBodega : IBLLBodega
    {
        public bool Delete(int pId)
        {
            throw new Exception("Ud debe desarrollarlo!");

        }

        public List<Bodega> GetAll()
        {
            IDALBodega dalBodega = new DALBodega();
            return dalBodega.GetAll();
        }

        public Bodega GetById(int pId)
        {
            IDALBodega dalBodega = new DALBodega();
            return dalBodega.GetById(pId);

        }

        public Bodega Save(Bodega pBodega)
        {
            throw new Exception("Ud debe desarrollarlo!");

        }
    }
}
