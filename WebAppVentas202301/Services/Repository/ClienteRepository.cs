using WebAppVentas202301.Models;
using WebAppVentas202301.Services.Interface;

namespace WebAppVentas202301.Services.Repository
{
    public class ClienteRepository : ICliente
    {
        private BdVentas bd = new BdVentas();

        public void Add(TbCliente cliente)
        {
            try
            {
                bd.TbClientes.Add(cliente);//insert into <tabla> values(datos)
                bd.SaveChanges();//actualizar en la BD
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);   
            }
        }

        public void Delete(string id)
        {
            var obj = (from tcliente in bd.TbClientes
                       where tcliente.CodCli == id
                       select tcliente).Single();
            bd.TbClientes.Remove(obj);//delete from <tabla> where <campo>=id
            bd.SaveChanges();
        }

        public IEnumerable<TbCliente> GetAllClientes()
        {
            return bd.TbClientes;
        }

        public TbCliente GetCliente(string id)
        {
            var obj = (from tcliente in bd.TbClientes
                       where tcliente.CodCli == id
                       select tcliente).Single();
            return obj; 
        }

        public void Update(TbCliente clienteConDatosModifiados)
        {
            var objAModificado = (from tcliente in bd.TbClientes
                                 where tcliente.CodCli == clienteConDatosModifiados.CodCli
                                 select tcliente).FirstOrDefault();
                if(objAModificado!= null)
                {
                    objAModificado.CodCli   = clienteConDatosModifiados.CodCli;
                    objAModificado.RazSocCli = clienteConDatosModifiados.RazSocCli;
                    objAModificado.RucCli = clienteConDatosModifiados.RucCli;
                    objAModificado.DirCli = clienteConDatosModifiados.DirCli;
                    objAModificado.TlfCli = clienteConDatosModifiados.TlfCli;
                    
                    bd.SaveChanges();   
                }
        }
    }
}
