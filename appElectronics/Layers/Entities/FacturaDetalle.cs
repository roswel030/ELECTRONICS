using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronics.Layers.Entities
{
    public  class FacturaDetalle
    {
        public double IdFactura { set; get; }
        public String DescripcionElectronico { set; get; }
        public int Secuencia { set; get; } 
        public double IdElectronico { set; get; } 
        public int Cantidad { set; get; }         
        public double Precio { set; get; }
        public double Impuesto { set; get; }

    }
}
