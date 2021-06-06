using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class Cls_Producto
    {
        public List<tb_producto> CargarProductosFiltro(String filtro)
        {
            List<tb_producto> tb_Producto = new List<tb_producto>();
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                tb_Producto = (from listadproductos in bd.tb_producto
                               where listadproductos.nombreProducto.Contains(filtro)
                               select listadproductos).ToList();
            }
            return tb_Producto;

        }

        public List<tb_producto> BusquedaID(int codigo)
        {
            List<tb_producto> tb_Producto = new List<tb_producto>();
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                tb_Producto = (from listadproductos in bd.tb_producto
                               where listadproductos.idProducto == codigo
                               select listadproductos).ToList();
            }
            return tb_Producto;

        }
    }
}
