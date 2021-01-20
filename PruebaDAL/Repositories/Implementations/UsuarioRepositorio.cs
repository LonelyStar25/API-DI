using PruebaCore.DTO;
using PruebaDAL.Models;
using PruebaDAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PruebaDAL.Repositories.Implementations
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public desarrollodeinterfacesContext context { get; set; }

        public UsuarioRepositorio(desarrollodeinterfacesContext context) {
            this.context = context;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            return context.Usuario.Any(u=>u.Nombre==usuarioDTO.Username && u.Contraseña==usuarioDTO.Password);
        }
    }
}
