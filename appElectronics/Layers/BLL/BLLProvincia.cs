using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;
using UTN.Winform.Electronics.Layers.Entities;
using UTN.Winform.Electronics.Layers.Entities.DTO;

namespace UTN.Winform.Electronics.Layers.BLL
{
    public class BLLProvincia : IBLLProvincia
    {
        public bool Delete(int pId)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }

        public List<Provincia> GetAll()
        {
            IDALProvincia dalProvincia = new DALProvincia();
            return dalProvincia.GetAll();
        }

        public Provincia GetById(int pId)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }

        /// <summary>
        /// Leerlo json de internet acceder https://github.com/lateraluz/Datos y buscar el archivo provincias.json
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        /// <exception cref=""></exception>
        public Provincia GetProvinciaFromInternet(int pId)
        {
            Provincia provincia = null;
            string json = "";

            // Leer del App.Config el URL con el Key URLPadron
            string url = ConfigurationManager.AppSettings["URLProvincia"];

             
            // Creates a GET request to fetch  
            WebRequest request = WebRequest.Create(url);
            // Verb GET
            request.Method = "GET";


            // GetResponse returns a web response containing the response to the request
            using (WebResponse webResponse = request.GetResponse())
            {
                // Reading data
                StreamReader reader = new StreamReader(webResponse.GetResponseStream());
                json = reader.ReadToEnd();
            }

            // Todas las provincias
            List<Provincia> lista = JsonSerializer.Deserialize<List<Provincia>>(json);

            provincia = lista.Find(p => p.IdProvincia == pId);

            return provincia;

        }

        public Provincia Save(Provincia pProvincia)
        {
            throw new Exception("Ud debe desarrollarlo!");
        }
    }
}
