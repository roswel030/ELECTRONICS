using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IDALTarjeta
    {
        List<Tarjeta> GetAll();
        Tarjeta GetById(int pId);
        Tarjeta Save(Tarjeta pTarjeta);
        bool Delete(string pId);
        Tarjeta Update(Tarjeta pTarjeta);
    }
}
