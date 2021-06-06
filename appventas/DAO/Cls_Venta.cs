using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class Cls_Venta
    {
        public List<tb_venta> UltimaVenta()
        {
            List<tb_venta> consultarultimaventa = new List<tb_venta>();

            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                consultarultimaventa = bd.tb_venta.ToList();
            }
            return null;
        }

    }

    
}
