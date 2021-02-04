using PruebaBL.Contracts;
using PruebaCore.DTO;
using PruebaDAL.Repositories.Contracts;
using System.Collections.Generic;

namespace PruebaBL.Implementation
{
    public class VentaBL : IVentaBL
    {
        public IVentaRepositorio _ventaRepositorio { get; set; }

        public VentaBL(IVentaRepositorio usu)
        {
            _ventaRepositorio = usu;
        }

        public IEnumerable<VentaDTO> Get()
        {
            return _ventaRepositorio.Get();
        }
    }
}
