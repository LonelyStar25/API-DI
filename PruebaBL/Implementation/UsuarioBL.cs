using PruebaBL.Contracts;
using PruebaCore.DTO;
using PruebaDAL.Repositories.Contracts;

namespace PruebaBL.Implementation
{
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepositorio _usuarioRepositorio { get; set; }

        public UsuarioBL(IUsuarioRepositorio usu)
        {
            _usuarioRepositorio = usu;
        }

        public bool Login(UsuarioDTO usuarioDTO)
        {
            return _usuarioRepositorio.Login(usuarioDTO);
        }
    }
}
