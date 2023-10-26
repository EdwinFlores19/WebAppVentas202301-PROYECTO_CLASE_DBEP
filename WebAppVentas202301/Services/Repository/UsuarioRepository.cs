using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Services.Repository
{
    public class UsuarioRepository : IUsuario
    {
        private BdVentas bd = new BdVentas();


        public Usuario getValidarUsuario(Usuario usuario)
        {
            var obj = (from tusuario in bd.Usuarios
                       where tusuario.UsuUsuario == usuario.UsuUsuario &&
                       tusuario.UsuClave == usuario.UsuClave
                       select tusuario).FirstOrDefault();
            return obj;
        }
    }
}
