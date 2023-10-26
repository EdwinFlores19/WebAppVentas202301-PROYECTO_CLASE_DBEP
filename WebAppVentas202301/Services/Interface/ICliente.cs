using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Interface
{
    public interface ICliente
    {
        IEnumerable<TbCliente> GetAllClientes();
        void Add(TbCliente cliente);
        void Update(TbCliente cliente);
        void Delete(string id);
        TbCliente GetCliente(string id);
    }
}
