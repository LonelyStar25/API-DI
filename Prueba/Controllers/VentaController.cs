using Microsoft.AspNetCore.Mvc;
using PruebaBL.Contracts;
using PruebaCore.DTO;
using System.Collections.Generic;

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
