using Microsoft.AspNetCore.Mvc;
using PruebaCore.DTO;
using PruebaDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaDAL.Repositories.Contracts
{
    public interface IVentaRepositorio
    {
        IEnumerable<VentaDTO> Get();
    }
}
