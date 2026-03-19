using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;

namespace UTN.Winform.Electronics.Layers.Entities
{
    public  class Bodega  
    {
        public string DescripcionBodega { set; get; } 
        public int IdBodega { set; get; }   
        public override string ToString() =>  $"{IdBodega} - {DescripcionBodega}";
           
           
    }
}
