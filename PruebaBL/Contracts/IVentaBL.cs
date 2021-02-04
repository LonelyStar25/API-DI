using PruebaCore.DTO;
using System.Collections.Generic;

namespace PruebaBL.Contracts
{
    public interface IVentaBL
    {
        IEnumerable<VentaDTO> Get();
    }
}
