using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.BLL
{
    public class BLLFactura : IBLLFactura
    {
        public int GetNextNumeroFactura()
        {
            IDALFactura dalFactura = new DALFactura();
            return dalFactura.GetNextNumeroFactura();
        }

        public int GetCurrentNumeroFactura()
        {
            IDALFactura dalFactura = new DALFactura();
            return dalFactura.GetCurrentNumeroFactura();
        }

        public FacturaEncabezado Save(FacturaEncabezado pFactura)
        {
            IDALFactura dalFactura = new DALFactura();
            IBLLElectronico bllElectronico = new BLLElectronico();

            // Vuelve a validar que exista en inventario
            foreach (FacturaDetalle oFacturaDetalle in pFactura._ListaFacturaDetalle)
            {
                bllElectronico.AvabilityStock(oFacturaDetalle.IdElectronico, oFacturaDetalle.Cantidad); 
            }
             

            return dalFactura.Save(pFactura);  
        }


        public double GetTotalFactura(double pId) {
            DALFactura dalFactura = new DALFactura();            
            return dalFactura.GetTotalFactura(pId);
        }

        public double CalculateTax(double precio, int cantidad)
        {
            IBLLImpuesto bllImpuesto = new BLLImpuesto();
            double porcentaje = bllImpuesto.GetImpuesto().Porcentaje;
            return precio * cantidad * ( porcentaje /100d);
        }

        public async Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DALFactura dalFactura = new DALFactura();
            return await dalFactura.GetTotalVentasXFecha(pFechaInicial, pFechaFinal);
        }
    }
}
