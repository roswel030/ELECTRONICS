using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IDALFactura
    {
        FacturaEncabezado Save(FacturaEncabezado pFactura);
        int GetNextNumeroFactura();

        int GetCurrentNumeroFactura();

        Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal);
    }

}
