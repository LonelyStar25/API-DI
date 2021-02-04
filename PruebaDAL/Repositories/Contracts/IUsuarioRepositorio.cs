using PruebaCore.DTO;

namespace PruebaDAL.Repositories.Contracts
{
    public interface IUsuarioRepositorio
    {
        bool Login(UsuarioDTO usuarioDTO);
    }
}
