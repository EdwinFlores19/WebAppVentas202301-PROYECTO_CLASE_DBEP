using WebAppVentas202301.Services.Interface;
using WebAppVentas202301.Models;

namespace WebAppVentas202301.Services.Repository
{
    public class ProveedoresRepository : IProveedores
    {
        private BdVentas bd = new BdVentas();
        public IEnumerable<TbProveedor> GetAllProveedores()
        {
            return bd.TbProveedors.ToList();
        }

        public void Add(TbProveedor proveedor)
        {
            try
            {
                bd.TbProveedors.Add(proveedor);//insert into <tabla> values(datos)
                bd.SaveChanges();//actualizar en la BD
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Delete(string id)
        {
            var objProveedor = (from tproveedor in bd.TbProveedors
                       where tproveedor.CodPrv == id
                       select tproveedor).Single();
            bd.TbProveedors.Remove(objProveedor);//delete from <tabla> where <campo>=id
            bd.SaveChanges();
        }

        public void Update(TbProveedor proveedorConDatosModifiados)
        {
            var objAModificado = (from tproveedor in bd.TbProveedors
                                  where tproveedor.CodPrv == proveedorConDatosModifiados.CodPrv
                                  select tproveedor).FirstOrDefault();
            if (objAModificado != null)
            {
                objAModificado.CodPrv = proveedorConDatosModifiados.CodPrv;
                objAModificado.RazSocPrv = proveedorConDatosModifiados.RazSocPrv;
                objAModificado.DirPrv = proveedorConDatosModifiados.DirPrv;
                objAModificado.TelPrv = proveedorConDatosModifiados.TelPrv;
                objAModificado.RepVen = proveedorConDatosModifiados.RepVen;

                bd.SaveChanges();
            }
        }

        TbProveedor IProveedores.GetProveedor(string id)
        {
            var objProveedor = (from tproveedor in bd.TbProveedors
                       where tproveedor.CodPrv == id
                       select tproveedor).Single();
            return objProveedor;
        }

        public void CantidadDeOrdenes(string id)
        {
            //int Contador = 0;
            //var objProveedor = (from tproveedor in bd.TbProveedors
            //                    where tproveedor.CodPrv == id
            //                    select tproveedor).Single();
            //Contador = objProveedor.Count();

            //return Contador;
        }
    }
}
