using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IDALCliente
    {
        List<Cliente> GetByFilter(string pDescripcion);
        Cliente GetById(string pId);
        Task<IEnumerable<Cliente>> GetAll();
        Task<Cliente> Save(Cliente pCliente);
        Task<Cliente> Update(Cliente pCliente);
        Task<bool> Delete(string pId);


    }
}
