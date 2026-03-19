using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronics.Layers.Entities
{
   
    public class Pais
    {
        public string Codigo { get; set; } 
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}
