using PruebaCore.DTO;

namespace PruebaBL.Contracts
{
    public interface IUsuarioBL
    {
        bool Login(UsuarioDTO usuarioDTO);
    }
}
