using PruebaCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaBL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
    }
}
