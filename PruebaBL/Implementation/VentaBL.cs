using Microsoft.AspNetCore.Mvc;
using PruebaBL.Contracts;
using PruebaCore.DTO;
using PruebaDAL.Models;
using PruebaDAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

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
