using Microsoft.AspNetCore.Mvc;
using PruebaBL.Contracts;
using PruebaBL.Implementation;
using PruebaCore.DTO;
using PruebaDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : ControllerBase
    {
        public IVentaBL ventaBL { get; set; }

        public VentaController()
        {
        }

        [HttpGet]
        public IEnumerable<VentaDTO> Get()
        {
            return ventaBL.Get();
        }
    }
}
