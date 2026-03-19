using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronics.Layers.Entities
{
    public class Provincia
    {
        public int IdProvincia { set; get; }
        public string Descripcion { set; get; }
        public override string ToString() => IdProvincia +" "+Descripcion;

    }
}
