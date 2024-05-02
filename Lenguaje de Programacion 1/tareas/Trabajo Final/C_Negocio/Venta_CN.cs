using C_Dato;
using C_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Venta_CN
    {
        public int Insertar(Venta_CE venta_CE)
        {
            int id;
            Venta_CD venta_CD = new Venta_CD();
            id = venta_CD.Insertar(venta_CE);
            return id;
        }

    }
}
