using PruebaCore.DTO;
using PruebaDAL.Models;
using PruebaDAL.Repositories.Contracts;
using System.Linq;

namespace PruebaDAL.Repositories.Implementations
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public desarrollodeinterfacesContext context { get; set; }

        public UsuarioRepositorio(desarrollodeinterfacesContext context)
        {
            this.context = context;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            return context.Usuario.Any(u => u.Nombre == usuarioDTO.Username && u.Contraseña == usuarioDTO.Password && u.Profesión == "Jefe");
        }
    }
}
