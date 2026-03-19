using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IDALBodega
    {
        List<Bodega> GetAll(); 
        Bodega GetById(int pId);
        Bodega Save(Bodega pBodega);
        Bodega Update(Bodega pBodega);
        bool Delete(int pId);
    }
}
