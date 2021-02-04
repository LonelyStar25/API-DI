using PruebaCore.DTO;
using System.Collections.Generic;

namespace PruebaDAL.Repositories.Contracts
{
    public interface IVentaRepositorio
    {
        IEnumerable<VentaDTO> Get();
    }
}
