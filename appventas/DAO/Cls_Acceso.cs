using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class Cls_Acceso
    {
        public int acceso(String usuario, String Password)
        {
            int variabledeacceso = 0;
            using (sistema_ventasEntities1 bd = new sistema_ventasEntities1())
            {
                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == Password
                               select user;

                if (consulta.Count() > 0)
                {
                    variabledeacceso = 1;

                }
            }

            return variabledeacceso;
        }
    }
}
