using PruebaCore.DTO;
using PruebaDAL.Models;
using PruebaDAL.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PruebaDAL.Repositories.Implementations
{
    public class VentaRepositorio : IVentaRepositorio
    {
        public desarrollodeinterfacesContext context { get; set; }

        public VentaRepositorio(desarrollodeinterfacesContext context)
        {
            this.context = context;
        }

        public IEnumerable<VentaDTO> Get()
        {
            var ventas = context.Venta.ToList();
            List<VentaDTO> ventasDTO = new List<VentaDTO>();

            foreach (var v in ventas)
            {
                var venta = new VentaDTO
                {
                    NumSerial = v.NumSerial,
                    DNICliente = v.DniCliente,
                    DNIUsuario = v.DniUsuario,
                    Beneficios = v.Beneficios,
                    Plazo = v.Plazo
                };
                ventasDTO.Add(venta);
            }

            return ventasDTO;
        }
    }
}
