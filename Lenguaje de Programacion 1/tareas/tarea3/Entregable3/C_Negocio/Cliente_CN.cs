using C_Dato;
using C_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class Cliente_CN
    {
        public Cliente_CE Buscarid(int id)
        {
            Cliente_CD cliente_CD = new Cliente_CD();
            Cliente_CE cliente_CE = cliente_CD.Buscarid(id);
            return cliente_CE;
        }
        public List<Cliente_CE> Getbuscarnombre(string buscar_nombre)
        {
            Cliente_CD cliente_CD = new Cliente_CD();
            List<Cliente_CE> ListCliente_CE = cliente_CD.Getbuscarnombre(buscar_nombre);
            return ListCliente_CE;
        }
        public int Insertar(Cliente_CE cliente_CE)
        {
            int id;
            Cliente_CD cliente_CD = new Cliente_CD();
            id = cliente_CD.Insertar(cliente_CE);
            return id;
        }
        public void Actualizar(Cliente_CE cliente_CE)
        {
            Cliente_CD cliente_CD = new Cliente_CD();
            cliente_CD.Actualizar(cliente_CE);

        }
        public void Eliminar(int eliminar_id)
        {
            Cliente_CD cliente_CD = new Cliente_CD();
            cliente_CD.Eliminar(eliminar_id); 
        }
    }
}
