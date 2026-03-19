using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Interfaces
{
    public interface IBLLFactura
    {
        FacturaEncabezado Save(FacturaEncabezado pFactura);
       
        int GetNextNumeroFactura();

        int GetCurrentNumeroFactura();

        double CalculateTax(double precio, int cantidad);

        Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal);
    }
}
