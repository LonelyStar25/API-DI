﻿using Microsoft.AspNetCore.Mvc;
using PruebaBL.Contracts;
using PruebaCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        public IUsuarioBL usuarioBL { get; set; }

        public LoginController(IUsuarioBL usuarioBL) {
            this.usuarioBL = usuarioBL;        
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
        public bool Login(UsuarioDTO usuarioDTO) { 
            return usuarioBL.Login(usuarioDTO);
        }
    }
}
