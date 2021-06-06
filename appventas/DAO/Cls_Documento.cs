using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class Cls_Documento
    {
        public List<tb_documento> CargarComboDocumento()
        {
            List<tb_documento> tb_Documento = new List<tb_documento>();
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                tb_Documento = bd.tb_documento.ToList();
            }
            return tb_Documento;

        }
    }
}
