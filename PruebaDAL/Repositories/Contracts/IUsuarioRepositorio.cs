using PruebaCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaDAL.Repositories.Contracts
{
    public interface IUsuarioRepositorio
    {
        bool Login(UsuarioDTO usuarioDTO);
    }
}
