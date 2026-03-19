using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Interfaces;

namespace UTN.Winform.Electronics.Layers.BLL
{
    /// <summary>
    /// Leer del  webservice del BCCR
    /// </summary>
    class BLLDolar : IBLLDolar
    {
        public double GetVentaDolar()
        {
                        
            try
            {
                // programarlo
                return 0;
            }
            catch (Exception ex)
            {
                String error = ex.Message;
                return 0;
            }

        }
    }
}
