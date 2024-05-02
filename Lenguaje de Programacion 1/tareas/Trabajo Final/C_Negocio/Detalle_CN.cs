using C_Dato;
using C_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Detalle_CN
    {
        public int Insertar(Detalle_CE detalle_CE)
        {
            int id;
            Detalle_CD detalle_CD = new Detalle_CD();
            id = detalle_CD.Insertar(detalle_CE);
            return id;
        }
    }
}
