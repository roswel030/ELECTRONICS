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
    public  class BLLElectronico : IBLLElectronico
    {
        public bool Delete(double pId)
        {
            IDALElectronico dalElectronico = new DALElectronico();
            return dalElectronico.Delete(pId);
        }

        public List<ElectronicoBodegaDTO> GetAll()
        {
            IDALElectronico dalElectronico = new DALElectronico();
            return dalElectronico.GetAll();

        }

        public List<Electronico> GetByFilter(string pDescripcion)
        {
            IDALElectronico dalElectronico = new DALElectronico();
            return dalElectronico.GetByFilter(pDescripcion);
        }

        public Electronico GetById(double pId)
        {
            IDALElectronico dalElectronico = new DALElectronico();
            Electronico oElectronico = dalElectronico.GetById(pId);         
            return oElectronico;
        }

        public Electronico Save(Electronico pElectronico)
        {
            IDALElectronico dalElectronico = new DALElectronico();
            Electronico oElectronico = null;
            if (dalElectronico.GetById(pElectronico.IdElectronico) == null)
                oElectronico = dalElectronico.Save(pElectronico);
            else
                oElectronico = dalElectronico.Update(pElectronico);

            return oElectronico;
        }


        /// <summary>
        /// Valida la cantidad disponible en inventario
        /// </summary>
        /// <param name="pId">Codigo del artículo</param>
        /// <param name="pCantidadSolicitada">Cantidad solicitada</param>
        /// <returns></returns>
        public Electronico AvabilityStock(double pId, double pCantidadSolicitada)
        {
            IDALElectronico dalElectronico = new DALElectronico();
            Electronico oElectronico = dalElectronico.GetById(pId);

            if (oElectronico == null) {
                throw new Exception($"El código {pId} no existe!");
            }

            if (oElectronico.Cantidad < pCantidadSolicitada)
                throw new Exception($"No hay cantidad suficiente en inventario para el producto {oElectronico.IdElectronico} {oElectronico.DescripcionElectronico}, cantidad disponible: {oElectronico.Cantidad}");
            else
                return oElectronico;
        }
    }
}
