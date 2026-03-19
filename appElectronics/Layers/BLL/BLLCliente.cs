using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Layers.BLL
{
    public  class BLLCliente : IBLLCliente
    {
        public List<Cliente> GetByFilter(string pDescripcion)
        {
            IDALCliente dalCliente = new DALCliente();
            return dalCliente.GetByFilter(pDescripcion);
        }

        public Cliente GetById(string pId)
        {
            IDALCliente dalCliente = new DALCliente();
            return dalCliente.GetById(pId);
        }


        public Task<IEnumerable<Cliente>> GetAll()
        {
            IDALCliente dalCliente = new DALCliente();
            return dalCliente.GetAll();
        }

        public Task<Cliente> Save(Cliente pCliente)
        {
            IDALCliente dalCliente = new DALCliente();
            Task<Cliente> oCliente = null;
             
            if (dalCliente.GetById(pCliente.IdCliente) == null)
                oCliente = dalCliente.Save(pCliente);
            else
                oCliente = dalCliente.Update(pCliente); 

            return oCliente;
        }

        public Task<bool> Delete(string pId)
        {
            IDALCliente dalCliente = new DALCliente();

            return dalCliente.Delete(pId);

        }
    }
}
