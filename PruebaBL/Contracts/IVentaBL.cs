using Microsoft.AspNetCore.Mvc;
using PruebaCore.DTO;
using PruebaDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaBL.Contracts
{
    public interface IVentaBL
    {
        IEnumerable<VentaDTO> Get();
    }
}
